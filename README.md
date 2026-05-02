# My Simple Task Tracker (CLI)
NOTES: Hi! I'm a first-year university student learning how to code, and this is one of my very first working projects. I found it on this website -> (https://roadmap.sh/projects). Even though I used to study C# briefly in highschool, with the help of AI tools i managed to finish the whole project. It's not really polished nor is it something impressive, but i gave my best shot at it i guess. I encourage others to try to replicate it too. :)

# This program is a digital To-Do list, which allows the user to:
- **add, edit, or delete** tasks
- label them as `todo` (need to do it), `in-progress` (working on it right now), or `done` (finished).
- save your tasks in a file (`tasks.json`) and allow you to access them again later

## Try it yourself (Step-by-Step Guide)

Want to see how it works? Follow these quick steps to create and manage tasks directly from your terminal:

**Step 1:** Open your terminal (Command Prompt, PowerShell, or Bash) in the project folder.

**Step 2:** Let's add our first task! Type:
> `task-cli add "Apply for an internship"`
**Expected result:** `Task added successfully (ID: 1)`

The program just created a `tasks.json` file in the same folder and saved your task there. Even if you turn off your computer, your task is safe!

**Step 3:** Let's see the list of all tasks. Type:
> `task-cli list`

Here you will see your task, its ID number (1), its status (todo), and exactly when it was created).*

**Step 4:** Let's start working on the task! Let's change its status:
> `task-cli mark-in-progress 1`

We use ID number 1 to tell the program exactly which task we are
changing. If you run `task-cli list` again, you will see that the status is now updated).

**Step 5:** We finished the job. Let's mark it as done:
> `task-cli mark-done 1`

**Step 6 (Optional):** If you don't need the task anymore, you can just delete it from the list forever:
> `task-cli delete 1`

If you open the `tasks.json` file now, you will see that 
the task is completely removed from the database).

# Description
**Honestly to save time describing everything, I'm just going to give you a link to the description of the project and you can follow how to do which and what: https://roadmap.sh/projects/task-tracker?fl=0
 (sorry if that's unethical/unacceptable lol)**
