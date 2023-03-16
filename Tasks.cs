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

        public void Display()
        {
            Console.WriteLine($"| {Description, -48} | {(isCompleted ? "'Completed'" : "'Not completed'"), -15} | {DueDate.ToString("dddd HH:mm"), -14} | {AssignedTo, -30} |");
        }
    }
}
