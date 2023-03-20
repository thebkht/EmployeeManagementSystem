using System;
using System.Collections.Generic;
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
        public List<Task> AssignedTasks { get; set; }
        public int CompletedTasks { get; set; }
        public int UncompletedTasks { get; set; }

        public Employee(int id, string username, string password, string name, double rate)
        {
            Id = id;
            Username = username;
            Password = password;
            Name = name;
            HourlyRate = rate;
            AssignedTasks = new List<Task>();
            CompletedTasks = 0;
            UncompletedTasks = 0;
        }

        p/*ublic Employee(string name, double rate)
        {
            Name = name;
            HourlyRate = rate;
        }*/

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
