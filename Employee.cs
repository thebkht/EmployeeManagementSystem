using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeManagementSystem
{
    public class Employee
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public double HourlyRate { get; set; }
        public List<Tasks> Tasks { get; set; }
        public int CompletedTasks { get; set; }
        public int UncompletedTasks { get; set; }

        public Employee(string name, double rate)
        {
            Name = name;
            HourlyRate = rate;
            Tasks = new List<Tasks>();
            CompletedTasks = 0;
            UncompletedTasks = 0;
        }

        public void Display()
        {
            Console.WriteLine($"{Name}: Completed Tasks: {CompletedTasks} | Uncompleted Tasks : {UncompletedTasks}");
        }

        public void AddCompletedTask()
        {
            CompletedTasks++;
        }

        public void AddUncompletedTask()
        {
            UncompletedTasks++;
        }
    }
}
