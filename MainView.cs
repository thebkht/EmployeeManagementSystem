using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public class MainView
    {
        public string Greet()
        {
            string greeting;
            DateTime now = DateTime.Now;

            if (now.Hour < 12)
            {
                greeting = "Good morning";
            }
            else if (now.Hour < 18)
            {
                greeting = "Good afternoon";
            }
            else
            {
                greeting = "Good evening";
            }

            return greeting;
        }

        void listLines()
        {
            Console.Write("|");
            Console.Write(string.Concat(Enumerable.Repeat("-", 50)));
            Console.Write("|");
            Console.Write(string.Concat(Enumerable.Repeat("-", 17)));
            Console.Write("|");
            Console.Write(string.Concat(Enumerable.Repeat("-", 16)));
            Console.Write("|");
            Console.Write(string.Concat(Enumerable.Repeat("-", 32)));
            Console.WriteLine("|");
        }

        void Admin()
        {
            Console.Clear();
            Console.WriteLine("Menu:\n");
            Console.WriteLine(">>> 1. Manage employee");
            Console.WriteLine(">>> 2. Manage tasks");
            Console.WriteLine(">>> 3. Track attendance");
            Console.WriteLine(">>> 4. Manage payroll");
            Console.WriteLine(">>> 5. Logout");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ManageEmployees();
                    Admin();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }
        }
        void User()
        {

            Console.WriteLine($"\n{Greet()}\nTasks for {DateTime.Today.ToString("dddd")}:\n");

            var sortedList = Program.tasksList.GetAllTasks().Where(item => item.DueDate.Date == DateTime.Today.Date);

            listLines();
            Console.WriteLine("| Description                                      | Status          | Due Date       | Assigned To                    |");
            listLines();

            foreach (Tasks item in sortedList)
                item.Display();
            listLines();

            Console.WriteLine("\nMenu:\n");
            Console.WriteLine(">>> 1. Change task status");
            Console.WriteLine(">>> 2. View payroll");
            Console.WriteLine(">>> 3. View attendance");
            Console.WriteLine(">>> 4. Logout");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
        }

        public void ManageEmployees()
        {
            var employees = Program.employeeList;
            bool exit = false;

            do
            {
                Console.Clear();
                Console.WriteLine("========== Manage Employees ==========");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Remove Employee");
                Console.WriteLine("3. View Employees");
                Console.WriteLine("4. Back to Main Menu");
                Console.WriteLine("======================================");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Employee Name: ");
                        string empName = Console.ReadLine();
                        Console.Write("Enter Employee Username: ");
                        string empUsername = Console.ReadLine();
                        string empPassword = PasswordGenerator.RandomPassword();
                        Console.WriteLine($"Password for this employee: {empPassword}");
                        Console.Write("Enter Employee Salary: ");
                        double empSalary = double.Parse(Console.ReadLine());
                        Employee newEmp = new Employee(empUsername, empPassword, empName, empSalary);
                        /*if (employees == null)
                        {
                            employees = new List<Employee>();
                        }*/
                        employees.AddEmployee(newEmp);
                        Console.WriteLine("\nEmployee Added Successfully!");
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.Write("Enter Employee ID: ");
                        int empId = int.Parse(Console.ReadLine());
                        if (employees.RemoveEmployee(empId))
                        {
                            Console.WriteLine("\nEmployee Removed Successfully!");
                        }
                        else
                        {
                            Console.WriteLine("\nEmployee Not Found!");
                        }
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine("\n========== Employee List ==========");
                        Console.WriteLine("{0,-5} {1,-15} {2,-15} {3,-15}", "ID", "Name", "Completed Tasks", "Uncompleted Tasks");
                        foreach (Employee emp in employees.GetAllEmployees())
                        {
                            emp.Display();
                        }
                        Console.WriteLine("===================================");
                        Console.ReadLine();
                        break;

                    case 4:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("\nInvalid Choice! Please try again.");
                        Console.ReadLine();
                        break;
                }

            } while (!exit);
        }

        public void Show()
        {

            if (Auth.isUserAdmin())
            {
                Admin();
            }
            else
            {
                User();
            }
        }
    }
}
