using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public class MainView
    {
        public void Show()
        {
            for (int i = 0; i < 120; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            Console.Write("* 1. Manage employee          ");
            Console.Write("* 2. Track attendance         ");
            Console.Write("* 3. Manage payroll           ");
            Console.WriteLine("* 4. Manage performance      *");

            for (int i = 0; i < 120; i++)
            {
                Console.Write("*");
            }
        }
    }
}
