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
            /*employeeList.AddEmployee(new Employee("employee1", "12345678", "Bakhtiyor", 10.0));

            Employee assignedEmployee = Program.employeeList.GetEmployee(0);
            tasksList.GetAllTasks().Add(new Tasks("Finish project", new DateTime(2023, 3, 31, 12, 35, 0), assignedEmployee.Name));*/

            mainView = new();
            employeeList = new(employees);

            /*mainView.ManageEmployees();*/
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