using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class Program
    {
        public static MainView mainView;
        public static TaskList tasksList;
        public static EmployeeList employeeList;
        static void Main(string[] args)
        {
            Console.Title = "Employee Management System (version 1.0.0.0)";

            List<Employee> employees = new List<Employee>();
            List<Tasks> tasks = new List<Tasks>();

            mainView = new();
            employeeList = new(employees);
            tasksList = new(tasks);

            Employee emp = new Employee("yusupovbg", "1234", "Bakhtiyor", 10.0);
            employeeList.AddEmployee(emp);

            RulesView rules = new RulesView();
            rules.Show();
            while (!Auth.Login())
            {

            }
            mainView.Show();
            Console.WriteLine();
        }
    }
}