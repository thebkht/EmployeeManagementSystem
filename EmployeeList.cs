using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class EmployeeList
    {
        Employee[] employeeSet;

        public EmployeeList(Employee[] employee)
        {
            employeeSet = employee;
        }

        public Employee[] GetAllEmployees() => employeeSet;
    }
}
