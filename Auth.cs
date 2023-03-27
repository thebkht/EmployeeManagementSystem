using Intercom.Data;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class Auth
    {
        public static bool isLoggedIn = true;
        public static string currentUser;
        /*public static bool isUserEmp = false;
        public static bool isUserAdmin = false;*/

        public static ConcurrentDictionary<string, string> admins = new ConcurrentDictionary<string, string>();

        public static bool Login()
        {
            Console.Clear();
            Console.Write("Username: ");
            string username = Console.ReadLine().Trim().ToLower();
            Console.WriteLine(Environment.NewLine);

            Console.Write("Password: ");
            string password = Console.ReadLine().Trim();
            Console.WriteLine(Environment.NewLine);

            if (admins.TryGetValue(username, out string savedPassword))
            {
                // Check if the provided password matches the stored password
                if (savedPassword == password)
                {
                    // Authentication successful
                    currentUser = username;
                    return true;
                }
            }

            // Check if the username and password match any employee in the employee list
            foreach (Employee employee in Program.employeeList.GetAllEmployees())
            {
                if (employee.Username == username && employee.Password == password)
                {
                    currentUser = username;
                    return true;
                }
            }

            isLoggedIn = true;
            // If the username and password do not match any admin or employee, authentication fails
            return false;
        }

        public static void Logout()
        {
            isLoggedIn = false;
            currentUser = null;
            //Program.mainView()
        }

        public bool IsLoggedIn()
        {
            return isLoggedIn;
        }

        public static bool isUserAdmin()
        {
            return admins.ContainsKey(currentUser);
        }
    }
}
