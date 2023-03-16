using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public class Tasks
    {
        public string Description { get; set; }
        public bool isCompleted { get; set; }
        public DateTime DueDate { get; set; }
        public string AssignedTo { get; set; }

        public Tasks(string description, DateTime dueDate, string assignedTo)
        {
            Description = description;
            isCompleted = false;
            DueDate = dueDate;
            AssignedTo = assignedTo;
        }

        void menuLine(int n)
        {
            Console.Write("|");
            Console.Write(string.Concat(Enumerable.Repeat("-", n-1)));
            Console.Write("|");
            Console.Write(string.Concat(Enumerable.Repeat("-", n-1)));
            Console.Write("|");
            Console.Write(string.Concat(Enumerable.Repeat("-", n-1)));
            Console.Write("|");
            Console.Write(string.Concat(Enumerable.Repeat("-", n-2)));
            Console.WriteLine("|");
        }

        public void Show()
        {
            Console.WriteLine($"| {Description, -46} | {(isCompleted ? "'Completed'" : "'Not completed'"), -15} | {DueDate.ToString("HH:mm"), -15} | {AssignedTo, -30} |");
            Console.WriteLine("Welcome to the Employee Management System!");
            Console.WriteLine("Today's tasks:");

            var todaysTasks = Program.tasksList.Where(item => item.DueDate.Date == DateTime.Today.Date);

            if (todaysTasks.Any())
            {
                foreach (var task in todaysTasks)
                {
                    Console.WriteLine($"{task.Description} (due by {task.DueDate.ToShortDateString()}){(string.IsNullOrEmpty(task.AssignedTo) ? "" : $" - assigned to {task.AssignedTo}")}");
                }
            }
            else
            {
                Console.WriteLine("No tasks due today.");
            }

            Console.WriteLine();
        }
    }
}
