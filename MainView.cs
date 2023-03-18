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
        public void Show()
        {

            menuLine(30);

            Console.WriteLine("| 1. Manage employee          | 2. Track attendance         | 3. Manage payroll           | 4. Manage performance      |");

            menuLine(30);

            Console.WriteLine($"\nTasks for {DateTime.Today.ToString("dddd")}:\n");

            var sortedList = Program.tasksList.GetAllTasks().Where(item => item.DueDate.Date == DateTime.Today.Date);

            listLines();
            Console.WriteLine("| Description                                      | Status          | Due Date       | Assigned To                    |");
            listLines();

            foreach (Tasks item in sortedList)
                item.Display();
            listLines();

            Console.Write("\nChoose from menu: ");
            int choise = Console.Read();

            /*switch(choise)
            {
                case 1:
                    Employee.ManageEmployees(); break;
                case 2:
            }*/
        }
    }
}
