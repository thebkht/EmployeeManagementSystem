﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class Auth
    {
        private bool isLoggedIn = false;
        private static string currentUser;

        private static Dictionary<string, string> users = new Dictionary<string, string>()
    {
        {"admin", "admin"},
    };

        public static bool Login()
        {
            Console.Write("Please enter your username: ");
            string username = Console.ReadLine().Trim().ToLower();
            Console.WriteLine(Environment.NewLine);

            Console.Write("Please enter your password: ");
            string password = Console.ReadLine().Trim();
            Console.WriteLine(Environment.NewLine);

            if (users.ContainsKey(username) && users[username] == password)
            {
                currentUser = username;
                return true;
            }

            // Check if the username and password match any employee in the employee list
            foreach (Employee employee in Program.employeeList.GetAllEmployees())
            {
                if (employee.Username == username && employee.Password == password)
                {
                    return true;
                }
            }

            // If the username and password do not match any admin or employee, authentication fails
            return false;
        }

        public void Logout()
        {
            isLoggedIn = false;
            currentUser = null;
        }

        public bool IsLoggedIn()
        {
            return isLoggedIn;
        }

        public static bool isUserAdmin()
        {
            if (currentUser == "admin")
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
