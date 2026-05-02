# My Simple Task Tracker (CLI)
NOTES: Hi! I'm a first-year university student learning how to code, and this is one of my very first working projects. I found it on this website -> (https://roadmap.sh/projects). Even though I used to study C# briefly in highschool, with the help of AI tools i managed to finish the whole project. It's not really polished nor is it something impressive, but i gave my best shot at it i guess. I encourage others to try to replicate it too. :)

## This program is a digital To-Do list, which allows the user to:
- **add, edit, or delete** tasks
- label them as `todo` (need to do it), `in-progress` (working on it right now), or `done` (finished).
- save your tasks in a file (`tasks.json`) and allow you to access them again later

## 🛠️ How to try it yourself (Beginner-friendly Guide)

If you are not a developer and want to see how this works, follow these simple steps. We will use the Command Terminal to add and manage tasks.

**Step 1: Get the code**
Click the green **"<> Code"** button at the top of this GitHub page and choose **"Download ZIP"**. Unzip the folder on your Desktop and open it.

**Step 2: Open the Command Terminal**
Click on the folder's address bar at the top, type `cmd`, and press **Enter**. A black terminal window will open up. You are now inside the project!

*(Note: You will need the .NET SDK installed on your PC to run the commands below).*

**Step 3: Add your first task**
Let's imagine you need to remember to buy groceries. In the terminal, type this and press Enter:
> `dotnet run -- add "Buy milk and eggs"`
*(Result: You will see **Task added successfully (ID: 1)**. The program just created a hidden `tasks.json` file in your folder to save your task. Even if you restart your PC, it will remember it!)*

**Step 4: View your task list**
Let's check what tasks we have. Type:
> `dotnet run -- list`
*(Result: The terminal will print out your tasks. You will see your grocery task with an ID of 1, its status [todo], and the exact time you created it).*

**Step 5: Update the task**
Let's say you just came back from the store and bought the milk. Let's mark the task as finished. Type:
> `dotnet run -- mark-done 1`
*(Result: The program updates task number 1. If you type the `dotnet run -- list` command again, you will see the status has changed from "todo" to "done").*

**Step 6: Clean up (Delete)**
If you want to clear your list and delete the task forever, simply type:
> `dotnet run -- delete 1`
*(Result: The task is completely erased from the database).*

# Description
**Honestly to save time describing everything, I'm just going to give you a link to the description of the project and you can follow how to do which and what: https://roadmap.sh/projects/task-tracker?fl=0
 (sorry if that's unethical/unacceptable lol)**
