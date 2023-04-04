using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class RulesView
    {
        public void Show()
        {
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", 33)));

            string welcome = "Welcome to the Employee Management System!";
            Console.WriteLine(welcome);
            string description = "This program allows you to manage your employees' tasks and attendance.\n";
            Console.WriteLine(description);

            Console.Write("[Press ENTER to continue...]");
            if (Regex.IsMatch(Console.ReadLine(), @"\.*"))
            {
                Console.WriteLine(Environment.NewLine);
                System.Threading.Thread.Sleep(800);
            }
        }
    }
}