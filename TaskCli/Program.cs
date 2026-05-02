using TaskCli;
using System.Text.Json;


string filePath = "tasks.json";

List<TaskItem> tasks = new List<TaskItem>();


if (File.Exists(filePath))
{
    string jsonString = File.ReadAllText(filePath);
    if (!string.IsNullOrWhiteSpace(jsonString))
    {
        tasks = JsonSerializer.Deserialize<List<TaskItem>>(jsonString) ?? new List<TaskItem>();
    }
}

int nextId = tasks.Count > 0 ? tasks.Max(t => t.Id) + 1 : 1;


void SaveTasks()
{
    string jsonString = JsonSerializer.Serialize(tasks, new JsonSerializerOptions { WriteIndented = true });
    File.WriteAllText(filePath, jsonString);
}


if (args.Length == 0)
{
    Console.WriteLine("Please provide a command. Example: task-cli add \"Buy groceries\"");
    return;
}

string command = args[0].ToLower();

if (command == "add")
{
    if (args.Length < 2)
    {
        Console.WriteLine("Error: Please provide a task description.");
        return;
    }

    TaskItem newTask = new TaskItem();
    newTask.Id = nextId++;
    newTask.Description = args[1];
    newTask.Status = "todo";
    newTask.CreatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    newTask.UpdatedAt = newTask.CreatedAt;

    tasks.Add(newTask);
    SaveTasks();
    Console.WriteLine($"Task added successfully (ID: {newTask.Id})");
}


else if (command == "list")
{
    string? filter = args.Length > 1 ? args[1].ToLower() : null;

    List<TaskItem> filteredTasks;
    if (filter == "done")
        filteredTasks = tasks.Where(t => t.Status == "done").ToList();
    else if (filter == "todo")
        filteredTasks = tasks.Where(t => t.Status == "todo").ToList();
    else if (filter == "in-progress")
        filteredTasks = tasks.Where(t => t.Status == "in-progress").ToList();
    else
        filteredTasks = tasks;

    if (filteredTasks.Count == 0)
    {
        Console.WriteLine("No tasks found.");
        return;
    }

    foreach (TaskItem task in filteredTasks)
    {
        Console.WriteLine($"[{task.Id}] [{task.Status}] {task.Description}");
    }
}


else if (command == "update")
{
    if (args.Length < 3)
    {
        Console.WriteLine("Error: Please provide an ID and new description.");
        return;
    }

    if (!int.TryParse(args[1], out int id))
    {
        Console.WriteLine("Error: Please provide a valid numeric ID.");
        return;
    }

    TaskItem? taskToUpdate = tasks.FirstOrDefault(t => t.Id == id);
    if (taskToUpdate == null)
    {
        Console.WriteLine($"Error: No task found with ID {id}.");
        return;
    }

    taskToUpdate.Description = args[2];
    taskToUpdate.UpdatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    SaveTasks();
    Console.WriteLine($"Task {id} updated successfully.");
}


else if (command == "delete")
{
    if (args.Length < 2)
    {
        Console.WriteLine("Error: Please provide an ID to delete.");
        return;
    }

    if (!int.TryParse(args[1], out int id))
    {
        Console.WriteLine("Error: Please provide a valid numeric ID.");
        return;
    }

    TaskItem? taskToDelete = tasks.FirstOrDefault(t => t.Id == id);
    if (taskToDelete == null)
    {
        Console.WriteLine($"Error: No task found with ID {id}.");
        return;
    }

    tasks.Remove(taskToDelete);
    SaveTasks();
    Console.WriteLine($"Task {id} deleted successfully.");
}


else if (command == "mark-in-progress")
{
    if (args.Length < 2)
    {
        Console.WriteLine("Error: Please provide an ID.");
        return;
    }

    if (!int.TryParse(args[1], out int id))
    {
        Console.WriteLine("Error: Please provide a valid numeric ID.");
        return;
    }

    TaskItem? task = tasks.FirstOrDefault(t => t.Id == id);
    if (task == null)
    {
        Console.WriteLine($"Error: No task found with ID {id}.");
        return;
    }

    task.Status = "in-progress";
    task.UpdatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    SaveTasks();
    Console.WriteLine($"Task {id} marked as in-progress.");
}


else if (command == "mark-done")
{
    if (args.Length < 2)
    {
        Console.WriteLine("Error: Please provide an ID.");
        return;
    }

    if (!int.TryParse(args[1], out int id))
    {
        Console.WriteLine("Error: Please provide a valid numeric ID.");
        return;
    }

    TaskItem? task = tasks.FirstOrDefault(t => t.Id == id);
    if (task == null)
    {
        Console.WriteLine($"Error: No task found with ID {id}.");
        return;
    }

    task.Status = "done";
    task.UpdatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    SaveTasks();
    Console.WriteLine($"Task {id} marked as done.");
}


else
{
    Console.WriteLine($"Unknown command: '{command}'.");
    Console.WriteLine("Available commands: add, list, update, delete, mark-in-progress, mark-done");
}
