using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList.Library
{
    public class TasksList : List<Task>
    {


        public void AddTask()
        {
            bool done = false;
            Console.WriteLine("Please enter a due date: (dd/mm/yyyy)");
            DateTime dueDate =DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a team member name: ");
            string teamMember = Console.ReadLine();
            Console.WriteLine("Please enter a description:");
            string description = Console.ReadLine();
            this.Add(new Task(done, dueDate, teamMember, description));
        }

        public void ListTasks()
        {
            Console.WriteLine("{0,-10} {1,-15} {2,-20} {3,-30}", "Done?", "Due Date", "Team Member", "Description");
            try
            {
                for (int i = 0; i < this.Count; i++)
                {                  
                    Console.WriteLine($"{0,-10}{1,-15}{2,-20}{3,-30}", this[i], this[i], this[i], this[i]);
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("There are currently no tasks.");
            }
        }

        public void MarkComplete()
        {
            throw new NotImplementedException();
        }

        public void DeletTask()
        {
            Console.WriteLine("Enter a number of a task to be deleted:");
            int choice = int.Parse(Console.ReadLine());
            for (int i = 0; i < Count; i++)
            {
                if (choice == (i + 1))
                {
                    Console.WriteLine("Are you sure you want to delete this? (y/n)");
                    Console.WriteLine(this[i]);
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "y")
                    {
                        this.Remove(this[i]);
                    }
                    else if (answer == "n")
                    {
                        break;
                    }
                }
            }
        }
        public void MarkComplete(List<bool> Done)
        {
            Console.Write("Please enter a task number to be marked complete: ");
            int taskChoice = int.Parse(Console.ReadLine());
            for (int i = 0; i < this.Count; i++)
            {
                if (taskChoice == (i + 1))
                {
                    Console.WriteLine("Are you sure you want to mark this task Complete? (Y/N)");


                    string answer = Console.ReadLine().ToLower();
                    if (answer == "y")
                    {
                        Done[1] = true;
                    }
                    else if (answer == "n")
                    {
                        break;
                    }
                }
            }
        }
    }
}   

