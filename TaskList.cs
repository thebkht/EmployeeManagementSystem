using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class TaskList : DbContext
    {
        DbSet<Tasks> tasksSet;

        public TaskList(DbSet<Tasks> tasks)
        {
            tasksSet = tasks;
        }

        public DbSet<Tasks> GetAllTasks() => tasksSet;

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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MyDatabase;");
        }

        public void AddTask(Tasks tasks)
        {
            // Generate a new unique ID
            /*int newId = tasksSet.Count > 0 ? tasksSet.Max(t => t.Id) + 1 : 1;*/
            /*tasks.Id = newId;*/

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