using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class TaskList
    {
        List<Tasks> tasksSet;

        public TaskList(List<Tasks> tasks)
        {
            tasksSet = tasks;
        }

        public List<Tasks> GetAllTasks() => tasksSet;

    }
}