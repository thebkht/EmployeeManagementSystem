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
        public static UserList userList;
        static void Main(string[] args)
        {
            Console.Title = "Employee Management System (version 1.0.0.0)";

            List<User> users = new List<User>();
            List<Tasks> tasks = new List<Tasks>();

            mainView = new();
            userList = new(users);
            tasksList = new(tasks);

            User user = new User("yusupovbg", "1234", "Bakhtiyor", 10.0, true);
            userList.AddUser(user);
            Admin admin = new Admin("admin", "admin", "Admin", 0, false);
            userList.AddUser(admin);

            RulesView rulesView = new();
            rulesView.Show();
            begin:
            while (!Auth.Login())
            {
                Console.WriteLine("Incorrect username or password!");
                rulesView.Show();
            }
            mainView.Show();
            if (!Auth.isLoggedIn)
            {
                goto begin;
            }
            Console.WriteLine();
        }
    }
}