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

        public void AddEmployee(Employee employee)
        {
            Employee[] newEmployees = new Employee[employeeSet.Length + 1];

            for (int i = 0; i < employeeSet.Length; i++)
            {
                newEmployees[i] = employeeSet[i];
            }

            newEmployees[employeeSet.Length] = employee;

            employeeSet = newEmployees;
        }

        public void RemoveEmployee(int index)
        {
            Employee[] newEmployees = new Employee[employeeSet.Length - 1];

            for (int i = 0; i < index; i++)
            {
                newEmployees[i] = employeeSet[i];
            }
            for (int i = index + 1; i < employeeSet.Length; i++)
            {
                newEmployees[i - 1] = employeeSet[i];
            }

            employeeSet = newEmployees;
        }

        public Employee GetEmployee(int index)
        {
            return employeeSet[index];
        }

        public Employee[] GetAllEmployees() => employeeSet;
    }
}
