# My Simple Task Tracker (CLI)
NOTES: Hi! I'm a first-year university student learning how to code, and this is one of my very first working projects. I found it on this website -> (https://roadmap.sh/projects). Even though I used to study C# briefly in highschool, with the help of AI tools i managed to finish the whole project. It's not really polished nor is it something impressive, but i gave my best shot at it i guess. I encourage others to try to replicate it too. :)

## This program is a digital To-Do list, which allows the user to:
- **add, edit, or delete** tasks
- label them as `todo` (need to do it), `in-progress` (working on it right now), or `done` (finished).
- save your tasks in a file (`tasks.json`) and allow you to access them again later

## How to try it yourself (Beginner-friendly Guide)

Never used GitHub or a command terminal before? No problem! Here is a simple, step-by-step guide to test my program on your own computer.

**Step 1: Get the code**
Go to the top of this page, click the green **"<> Code"** button, and select **"Download ZIP"**. Extract (unzip) the downloaded folder somewhere easy to find, like your Desktop. Open the extracted folder.

**Step 2: Open the Command Terminal**
Click on the address bar at the top of the folder window (where it says the folder path), delete the text, type `cmd`, and press **Enter**. A black screen (the terminal) will pop up. You are now ready!

*(Note: Make sure you have the .NET SDK installed on your computer to run C# code).*

**Step 3: Create a "secret" file**
Let's create a file to protect. In the black terminal, type this exactly and press Enter:
> `echo "Hello" > secret.txt`
*(Result: You just created a text file named 'secret.txt' in the folder. This is the file we want to protect from hackers).*

**Step 4: Lock it in (Save the fingerprint)**
Now, let's tell the program to remember exactly how this file looks. Type:
> `dotnet run -- init secret.txt`
*(Result: The program successfully saves a mathematical "fingerprint" of your file. If even a single byte changes later, the fingerprint won't match).*

**Step 5: Check if everything is safe**
Let's make sure our file is untouched. Type:
> `dotnet run -- check secret.txt`
*(Result: You will see **Status: Unmodified**. This means nobody has messed with your file).*

**Step 6: Play the Hacker!**
Let's simulate an attack. Open the `secret.txt` file normally with Notepad, add an extra space or change "Hello" to "Hello!", and save it. 

**Step 7: Catch the change**
Run the check command one more time in the terminal:
> `dotnet run -- check secret.txt`
*(Result: You will see **Status: Modified (Hash mismatch)**. The program instantly caught the unauthorized change because the new fingerprint doesn't match the original one!)*
If you open the `tasks.json` file now, you will see that 
the task is completely removed from the database).

# Description
**Honestly to save time describing everything, I'm just going to give you a link to the description of the project and you can follow how to do which and what: https://roadmap.sh/projects/task-tracker?fl=0
 (sorry if that's unethical/unacceptable lol)**
