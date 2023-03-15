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
        static void Main(string[] args)
        {
            Console.Title = "Employee Management System (version 1.0.0.0)";

            mainView = new MainView();

            mainView.Show();

            Console.WriteLine();
        }
    }
}
