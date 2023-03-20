using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class EmployeeList
    {
        List<Employee> employeeSet;

        public EmployeeList(List<Employee> employee)
        {
            employeeSet = employee;
        }

        public Employee GetEmployee(int id)
        {
            foreach (Employee employee in employeeSet)
            {
                if (employee.Id == id)
                {
                    return employee;
                }
            }
            return null;
        }

        public List<Employee> GetAllEmployees() => employeeSet;

    }
}
