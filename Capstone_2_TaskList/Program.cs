using System;
using TaskList.Library;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capstone_2_TaskList
{
    class Program
    {
        static void Main(string[] args)
        {
            var taskList = new TasksList();
            bool repeat = true;
            do
            {

                Console.WriteLine("Welcome to the Task Manager!");
                Console.WriteLine("\t1.\tList tasks");
                Console.WriteLine("\t2.\tAdd task");
                Console.WriteLine("\t3.\tDelete task");
                Console.WriteLine("\t4.\tMark task complete");
                Console.WriteLine("\t5.\tQuit");
                Console.WriteLine("What would you like to do?");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        taskList.ListTasks();
                        break;
                    case "2":
                        taskList.AddTask();
                        break;
                    case "3":
                        taskList.DeletTask();
                        break;
                    case "4":
                        taskList.MarkComplete();
                        break;
                    case "5":
                        repeat = false;
                        break;
                }
                
            } while (repeat == true);
            Console.WriteLine("Have a great day!");
            Console.ReadKey();
            
        }
    }
}
