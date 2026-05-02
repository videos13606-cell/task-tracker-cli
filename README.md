\# Task Tracker CLI



A simple command-line interface (CLI) application to track and manage your tasks. Built with C# and .NET as part of the \[roadmap.sh](https://roadmap.sh) backend projects.



\## Project URL



This project is part of the Task Tracker challenge on roadmap.sh:



\*\*https://roadmap.sh/projects/task-tracker\*\*



\## Features



\- Add, Update, and Delete tasks

\- Mark a task as `todo`, `in-progress`, or `done`

\- List all tasks

\- Filter tasks by status (`done`, `todo`, `in-progress`)

\- Persistent JSON storage (tasks survive after closing the program)

\- No external libraries — pure C# and .NET standard library



\## Requirements



\- \[.NET SDK](https://dotnet.microsoft.com/en-us/download) (10.0 or later)



\## How to Run



1\. Clone the repository:

git clone https://github.com/videos13606-cell/task-tracker-cli



cd task-tracker-cli/TaskCli



text



2\. Run the application:

dotnet run add "Buy groceries"

dotnet run list



text



\## Available Commands



| Command | Description |

|---|---|

| `dotnet run add "description"` | Add a new task |

| `dotnet run update \[id] "new description"` | Update a task |

| `dotnet run delete \[id]` | Delete a task |

| `dotnet run mark-in-progress \[id]` | Mark task as in progress |

| `dotnet run mark-done \[id]` | Mark task as done |

| `dotnet run list` | List all tasks |

| `dotnet run list done` | List completed tasks |

| `dotnet run list todo` | List pending tasks |

| `dotnet run list in-progress` | List tasks in progress |



\## Example

$ dotnet run add "Buy groceries"

Task added successfully (ID: 1)



$ dotnet run add "Walk the dog"

Task added successfully (ID: 2)



$ dotnet run mark-in-progress 1

Task 1 marked as in-progress.



$ dotnet run list

\[1] \[in-progress] Buy groceries

\[2] \[todo] Walk the dog

