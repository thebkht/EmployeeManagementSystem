using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
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
/*            Console.WriteLine(">>> 3. Track attendance");
            Console.WriteLine(">>> 4. Manage payroll");*/
            Console.WriteLine(">>> 0. Logout");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ManageEmployees();
                    Admin();
                    break;
                case 2:
                    ManageTasks();
                    Admin();
                    break;
                /*case 3:
                    break;
                case 4:
                    break;*/
                case 0:
                    Auth.Logout();
                    break;
            }
        }

        Employee FindEmployee(string username)
        {
            foreach (Employee emp in Program.employeeList.GetAllEmployees())
            {
                if (emp.Username == username)
                {
                    return emp;
                }
            }
            return null;
        }
        void User()
        {
            Employee currentEmployee = FindEmployee(Auth.currentUser);

            Console.WriteLine($"\n{Greet()}, {currentEmployee.Name}\nTasks for {DateTime.Today.ToString("dddd")}:\n");

            if (Program.tasksList.GetAllTasks().Any())
            {
                Console.WriteLine("{0, -5} {1, -48} {2, -15} {3, -15} {4, -30}", "ID", "Description", "Status", "Due Date", "Assigned To");

                foreach (Tasks item in Program.tasksList.GetAllTasks().Where(item => item.DueDate.Date == DateTime.Today.Date))
                    item.Display();
            }
            else
            {
                Console.WriteLine("There is no any tasks for today!");
            }

            Console.WriteLine("\nMenu:\n");
            Console.WriteLine(">>> 1. Change task status");
            Console.WriteLine(">>> 2. Change password");
            Console.WriteLine(">>> 4. Logout");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    MarkAsCompleted(currentEmployee);
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
        }

        public void MarkAsCompleted(Employee employee)
        {
            Console.WriteLine("Enter the ID of the task you want to mark as completed:");
            if (int.TryParse(Console.ReadLine(), out int taskId))
            {
                var task = Program.tasksList.GetTask(taskId);
                if (task != null)
                {
                    employee.MarkTaskCompleted(task);
                }
                else
                {
                    Console.WriteLine("Task not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid task ID.");
            }
        }

        private void ChangePassword()
        {
            Console.WriteLine("Please enter your current password:");
            var currentPassword = Console.ReadLine();
            if (currentPassword != _employee.Password)
            {
                Console.WriteLine("Invalid password. Please try again.");
                ChangePassword();
            }
            else
            {
                Console.WriteLine("Please enter a new password:");
                var newPassword = Console.ReadLine();
                _employee.Password = newPassword;
                Console.WriteLine("Password successfully changed.");
                Show();
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
                char choice = char.Parse(Console.ReadLine());

                switch (choice)
                {
                    case '1':
                        Console.Write("Enter Employee Name: ");
                        string empName = Console.ReadLine();
                        Console.Write("Enter Employee Username: ");
                        string empUsername = Console.ReadLine();
                        string empPassword = PasswordGenerator.RandomPassword();
                        Console.WriteLine($"Password for this employee: {empPassword}");
                        Console.Write("Enter Employee Salary: ");
                        double empSalary = double.Parse(Console.ReadLine());
                        Employee newEmp = new Employee(empUsername, empPassword, empName, empSalary);
                        employees.AddEmployee(newEmp);
                        Console.WriteLine("\nEmployee Added Successfully!");
                        ManageEmployees();
                        break;

                    case '2':
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
                        ManageEmployees();
                        break;

                    case '3':
                        Console.WriteLine("\n========== Employee List ==========");
                        Console.WriteLine("{0,-5} {1,-15} {2,-20} {3,-20}", "ID", "Name", "Completed Tasks", "Uncompleted Tasks");
                        foreach (Employee emp in employees.GetAllEmployees())
                        {
                            emp.Display();
                        }
                        Console.WriteLine("===================================");
                        Console.ReadLine();
                        break;

                    case '4':
                        Admin();
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("\nInvalid Choice! Please try again.");
                        ManageEmployees();
                        break;
                }

            } while (!exit);
        }

        public void AddTask(Tasks task, Employee employee)
        {
            if (task != null)
            {
                Program.tasksList.GetAllTasks().Add(task);
                if (employee != null)
                {
                    employee.AssignedTasks.Add(task);
                }
                Console.WriteLine("Task added successfully.");
            }
            else
            {
                Console.WriteLine("Task could not be added.");
            }
        }

        public void ManageTasks()
        {
            Employee employ;
            Console.Clear();
            Console.WriteLine("\n======= Tasks Management =======");

            if (Program.tasksList.GetAllTasks().Any())
            {
                Console.WriteLine("{0, -5} {1, -48} {2, -15} {3, -15} {4, -30}", "ID", "Description", "Status", "Due Date", "Assigned To");

                foreach (Tasks item in Program.tasksList.GetAllTasks().Where(item => item.DueDate.Date == DateTime.Today.Date))
                    item.Display();
            }

            Console.WriteLine("\n1. Add a new task");
            Console.WriteLine("2. Remove a task");
            Console.WriteLine("3. Edit a task");
            Console.WriteLine("4. Go back to main menu");

            int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter a description for the new task: ");
                        string desc = Console.ReadLine();

                    if (desc == "")
                    {
                        desc = "Untitled task";
                    }

                        Console.WriteLine("Enter the due date for the new task (MM/DD/YYYY): ");
                        DateTime due = DateTime.Parse(Console.ReadLine());

                        Console.WriteLine("Enter an ID to assign the employee: ");
                        Console.WriteLine("{0,-5} {1,-15} {2,-25} {3,-25}", "ID", "Name", "Completed Tasks", "Uncompleted Tasks");
                        foreach (Employee emp in Program.employeeList.GetAllEmployees())
                        {
                            emp.Display();
                        }
                        int id = int.Parse(Console.ReadLine());
                        Employee assignedEmployee = Program.employeeList.GetEmployee(id);
                        assignedEmployee.UncompletedTasks = Program.employeeList.GetAssignedTaskCount(assignedEmployee);
                        Tasks newTask = new Tasks(desc, due, assignedEmployee.Name);
                        AddTask(newTask, assignedEmployee);
                        ManageTasks();
                        break;

                    case 2:
                        Console.Write("\nEnter Task ID to Remove: ");
                        int taskIdToRemove = int.Parse(Console.ReadLine());
                        bool isTaskRemoved = Program.tasksList.RemoveTask(taskIdToRemove);
                        if (isTaskRemoved)
                        {
                            Console.WriteLine("\nTask Removed Successfully!\n");
                        }
                        else
                        {
                            Console.WriteLine("\nTask with ID {0} not found!\n", taskIdToRemove);
                        }
                    ManageTasks();
                        break;

                    case 3:
                        Console.WriteLine("====== Edit Task ======");

                        Console.Write("Enter the ID of the task to edit: ");
                        if (!int.TryParse(Console.ReadLine(), out id))
                        {
                            Console.WriteLine("Invalid input. Press any key to try again...");
                            Console.ReadKey();
                            return;
                        }

                        Tasks task = Program.tasksList.GetTask(id);

                        if (task == null)
                        {
                            Console.WriteLine("Task not found. Press any key to try again...");
                            Console.ReadKey();
                            return;
                        }

                        Console.WriteLine($"Editing Task: {task.Description} (ID: {task.Id})");
                        Console.WriteLine("Leave a field blank to keep existing value.");

                        Console.Write("Title: ");
                        string title = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(title))
                        {
                            task.Description = title;
                        }

                        Console.Write("Description: ");
                        string description = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(description))
                        {
                            task.Description = description;
                        }

                        Console.Write("Assigned Employee ID: ");
                        int employeeId;
                        if (int.TryParse(Console.ReadLine(), out employeeId))
                        {
                            Employee employee = Program.employeeList.GetEmployee(employeeId);
                            if (employee != null)
                            {
                                task.AssignedTo = employee.Name;
                            }
                        }

                        Console.Write("Due Date (yyyy-MM-dd): ");
                        DateTime dueDate;
                        if (DateTime.TryParse(Console.ReadLine(), out dueDate))
                        {
                            task.DueDate = dueDate;
                        }

                        Console.WriteLine("Task updated successfully. Press any key to continue...");
                        Console.ReadKey();
                    ManageTasks();
                        break;

                    case 4:
                        Admin();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
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
