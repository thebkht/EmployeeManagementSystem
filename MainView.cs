using System;
using System.Collections.Generic;
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
        public void Show()
        {

            menuLine(30);

            Console.WriteLine("| 1. Manage employee          | 2. Track attendance         | 3. Manage payroll           | 4. Manage performance      |");

            menuLine(30);
        }
    }
}
