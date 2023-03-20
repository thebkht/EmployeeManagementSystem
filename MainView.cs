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
        void menuLine(int n)
        {
            Console.Write("|");
            Console.Write(string.Concat(Enumerable.Repeat("-", n-1)));
            Console.Write("|");
            Console.Write(string.Concat(Enumerable.Repeat("-", n-1)));
            Console.Write("|");
            Console.Write(string.Concat(Enumerable.Repeat("-", n-1)));
            Console.Write("|");
            Console.Write(string.Concat(Enumerable.Repeat("-", n-2)));
            Console.WriteLine("|");
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
            Console.WriteLine("Menu:\n");
            Console.WriteLine(">>> 1. Manage employee");
            Console.WriteLine(">>> 2. Manage tasks");
            Console.WriteLine(">>> 3. Track attendance");
            Console.WriteLine(">>> 4. Manage payroll");
            Console.WriteLine(">>> 5. Logout");

            int choise = Console.Read();

            switch(choise)
            {
                case 1:
                    ManageEmployees();
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
            Console.WriteLine($"\nTasks for {DateTime.Today.ToString("dddd")}:\n");

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

            int choise = Console.Read();

            switch (choise)
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
            while (true)
            {
                Console.WriteLine("---- Manage Employees ----");
                Console.WriteLine("1. View all employees");
                Console.WriteLine("2. Add a new employee");
                Console.WriteLine("3. Update an employee's information");
                Console.WriteLine("4. Delete an employee");
                Console.WriteLine("5. Back to Main Menu");
                Console.Write("Enter your choice (1-5): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("---- All Employees ----");
                        foreach (Employee emp in Program.employeeList.GetAllEmployees())
                        {
                            emp.Display();
                        }
                        Console.WriteLine("------------------------");
                        break;
                    case "2":
                        Console.WriteLine("---- Add Employee ----");
                        Console.Write("Enter employee name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter employee position: ");
                        string position = Console.ReadLine();
                        Console.Write("Enter employee hourly rate: ");
                        double rate = double.Parse(Console.ReadLine());
                        Program.employeeList.GetAllEmployees().Add(new Employee(name, rate));
                        Console.WriteLine("Employee added successfully!");
                        break;
                    case "3":
                        Console.WriteLine("---- Update Employee ----");
                        Console.Write("Enter employee ID: ");
                        string id = Console.ReadLine();
                        Employee empToUpdate = Program.employeeList.GetEmployee(id);
                        if (empToUpdate != null)
                        {
                            Console.WriteLine("Employee found!");
                            Console.Write("Enter new name (leave blank to keep the same): ");
                            string newName = Console.ReadLine();
                            if (!string.IsNullOrEmpty(newName))
                            {
                                empToUpdate.Name = newName;
                            }
                            Console.Write("Enter new hourly rate (leave blank to keep the same): ");
                            string newRateStr = Console.ReadLine();
                            if (!string.IsNullOrEmpty(newRateStr))
                            {
                                double newRate = double.Parse(newRateStr);
                                empToUpdate.HourlyRate = newRate;
                            }
                            Console.WriteLine("Employee updated successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Employee not found.");
                        }
                        break;
                    case "4":
                        Console.WriteLine("---- Delete Employee ----");
                        Console.Write("Enter employee ID: ");
                        string idToDelete = Console.ReadLine();
                        Employee empToDelete = Program.employeeList.GetEmployee(idToDelete);
                        if (empToDelete != null)
                        {
                            Program.employeeList.GetAllEmployees().Remove(empToDelete);
                            Console.WriteLine("Employee deleted successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Employee not found.");
                        }
                        break;
                    case "5":
                        Show();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
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
