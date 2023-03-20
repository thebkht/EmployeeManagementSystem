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
        int size;

        public EmployeeList(Employee[] employee)
        {
            employeeSet = employee;
            size = 0;
        }

        public void Add(Employee employee)
        {
            if (size == employeeSet.Length)
            {
                throw new Exception("Employee list is full");
            }

            size = employeeSet.Length;

            employeeSet[size] = employee;
            /*size++;*/
        }

        public void Remove(Employee employee)
        {
            int index = -1;
            for (int i = 0; i < size; i++)
            {
                if (employeeSet[i].Equals(employee))
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                throw new Exception("Employee not found in list");
            }

            for (int i = index; i < size - 1; i++)
            {
                employeeSet[i] = employeeSet[i + 1];
            }

            size--;
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

        public Employee[] GetAllEmployees() => employeeSet;

    }
}
