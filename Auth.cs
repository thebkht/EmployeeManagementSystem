using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class Auth
    {
        private static Dictionary<string, string> _users = new Dictionary<string, string>()
    {
        {"admin", "admin"},
        {"employee1", "password1"},
        {"employee2", "password2"}
    };

        public static bool Login()
        {
            Console.Write("Please enter your username:");
            string username = Console.ReadLine().Trim().ToLower();
            Console.WriteLine(Environment.NewLine);

            Console.Write("Please enter your password:");
            string password = Console.ReadLine().Trim();
            Console.WriteLine(Environment.NewLine);

            if (_users.ContainsKey(username) && _users[username] == password)
            {
                System.Threading.Thread.Sleep(800);
                Console.Write($"Welcome, {username}!");
                Console.WriteLine(Environment.NewLine);
                return true;
            }
            else
            {
                System.Threading.Thread.Sleep(800);
                Console.WriteLine("Invalid username or password.");
                Console.WriteLine(Environment.NewLine);
                return false;
            }
        }
    }
}
