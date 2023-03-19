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

        public void AddEmployee(Employee employee)
        {
            employeeSet.Add(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            employeeSet.Remove(employee);
        }

        public Employee GetEmployee(string id)
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
