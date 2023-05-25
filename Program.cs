using Microsoft.Data.SqlClient;
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
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=E:\\REPOS\\EMPLOYEEMANAGEMENTSYSTEM\\DATABASE.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        static void Main(string[] args)
        {
            Console.Title = "Employee Management System (version 1.0.0.0)";

            /*using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // SQL commands will be executed here

                string sql = "INSERT INTO Person (Name, Age) VALUES (@Name, @Age)";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    foreach (Person person in people)
                    {
                        command.Parameters.AddWithValue("@Name", person.Name);
                        command.Parameters.AddWithValue("@Age", person.Age);
                        command.ExecuteNonQuery();
                    }
                }
            }*/



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