using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class EmployeeList
    {
        List<Employee> employeeSet = new List<Employee>();

        public EmployeeList(List<Employee> employee)
        {
            employeeSet = employee;
        }

        public void AddEmployee(Employee employee)
        {
            // Generate a new unique ID
            int newId = employeeSet.Count > 0 ? employeeSet.Max(emp => emp.Id) + 1 : 1;
            employee.Id = newId;

            employeeSet.Add(employee);

        }

        public bool RemoveEmployee(int id)
        {
            Employee employeeToRemove = null;
            foreach (Employee employee in employeeSet)
            {
                if (employee.Id == id)
                {
                    employeeToRemove = employee;
                    break;
                }
            }

            if (employeeToRemove != null)
            {
                employeeSet.Remove(employeeToRemove);
                return true;
            }
            else
            {
                Console.WriteLine($"Employee with ID {id} not found.");
                return false;
            }
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
