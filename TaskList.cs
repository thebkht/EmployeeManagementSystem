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

        public Tasks GetTask(int id)
        {
            foreach (Tasks task in tasksSet)
            {
                if (task.Id == id)
                {
                    return task;
                }
            }
            return null;
        }


        public void AddTask(Tasks tasks)
        {
            // Generate a new unique ID
            int newId = tasksSet.Count > 0 ? tasksSet.Max(t => t.Id) + 1 : 1;
            tasks.Id = newId;

            tasksSet.Add(tasks);

        }

        public bool RemoveTask(int id)
        {
            Tasks taskToRemove = null;
            foreach (Tasks task in tasksSet)
            {
                if (task.Id == id)
                {
                    taskToRemove = task;
                    break;
                }
            }

            if (taskToRemove != null)
            {
                tasksSet.Remove(taskToRemove);
                return true;
            }
            else
            {
                Console.WriteLine($"Task with ID {id} not found.");
                return false;
            }
        }
    }
}