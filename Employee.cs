using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public class Employee
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public double HourlyRate { get; set; }
        public List<Tasks> AssignedTasks { get; set; }
        public int CompletedTasks { get; set; }
        public int UncompletedTasks { get; set; }

        public Employee(string username, string password, string name, double rate)
        {
            Username = username;
            Password = password;
            Name = name;
            HourlyRate = rate;
            AssignedTasks = new List<Tasks>();
            CompletedTasks = 0;
            UncompletedTasks = 0;
        }

        public void Display()
        {
            Console.WriteLine($"{Id, -5} {Name, -15} {CompletedTasks, -20} {UncompletedTasks, -20}");
        }

        public void AddCompletedTask()
        {
            CompletedTasks++;
        }

        public void MarkTaskCompleted(Tasks task)
        {
            if (AssignedTasks.Contains(task))
            {
                task.isCompleted = true;
                AddCompletedTask();
                Console.WriteLine("Task marked as completed!");
            }
            else
            {
                Console.WriteLine("You are not assigned to this task.");
            }
        }
    }
}
