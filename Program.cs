using System;
using System.Collections.Generic;
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

            var tasks = new[]
            {
                new Tasks("Finish project", new DateTime(2023, 3, 31, 12, 35, 0), "Bakhtiyor Yusupov"),
                new Tasks("Finish project2", new DateTime(2023, 3, 16, 12, 35, 0), "Bakhtiyor Yusupov"),
                new Tasks("Finish project4", new DateTime(2023, 3, 19, 12, 39, 0), "Bakhtiyor Yusupov")
            };   

            mainView = new MainView();
            tasksList = new TaskList(tasks);

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
