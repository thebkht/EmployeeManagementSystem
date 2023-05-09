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
        public int Id { get; set; }
        public bool isCompleted { get; set; }
        public DateTime DueDate { get; set; }
        public string AssignedTo { get; set; }
        public DateTime? CompletionTime { get; set; }

        public Tasks(string description, DateTime dueDate, string assignedTo)
        {
            Description = description;
            isCompleted = false;
            DueDate = dueDate;
            AssignedTo = assignedTo;
            CompletionTime = null;
        }
        
        public void Display()
        {
            Console.WriteLine($"{Id, -5} {Description, -48} {(isCompleted ? "Completed" : "Not completed"), -15} {DueDate.ToString("dddd HH:mm"), -15} {AssignedTo, -30}");
        }

        public void MarkAsCompleted()
        {
            isCompleted = true;
            CompletionTime = DateTime.Now;
        }
    }
}
