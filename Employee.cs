using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeManagementSystem
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Tasks> Tasks { get; set; }

        public Employee(string name, int age)
        {
            Name = name;
            Age = age;
            Tasks = new List<Tasks>();
        }


    }
}
