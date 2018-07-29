using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList
{
    public class Task
    {
        public Menu(double selection)
        {
            
        }
        
        public string ListTasks()
        {
            Console.WriteLine($"{0, -10} {1, -15} {2, -20} {3, -30}", "Done?","Due Date", "Team Member", "Description");
            for (int i = 0; i < List.Capacity; i++)
            {

            }

            Console.WriteLine($"{0,-10} {1,-15} {2,-20} {3,-30}", List[i], List[1], List[2], List[3]);
        }
        public void AddTask()
        {
            List<bool> done = new List<bool>();
            List<DateTime> dueDate = new List<DateTime>();
            List<string> teamMember = new List<string>();
            List<string> description = new List<string>();
            TaskList.Add
                (
                done,
                dueDate,
                teamMember,
                description
                );
                
        }
        public void DeletTask()
        {

        }
        public void MarkComplete()
        {

        }
        public void Quit()
        {

        }
        public List<List<string>> TaskList { get; set; }
    }
}
