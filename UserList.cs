using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class UserList
    {
        List<User> userSet = new List<User>();

        public UserList(List<User> user)
        {
            userSet = user;
        }

        public void AddEmployee(User user)
        {
            // Generate a new unique ID
            int newId = userSet.Count > 0 ? userSet.Max(usr => user.Id) + 1 : 1;
            user.Id = newId;

            userSet.Add(user);

        }

        public bool RemoveEmployee(int id)
        {
            User userToRemove = null;
            foreach (User u in userSet)
            {
                if (u.Id == id)
                {
                    userToRemove = u;
                    break;
                }
            }

            if (userToRemove != null)
            {
                userSet.Remove(userToRemove);
                return true;
            }
            else
            {
                Console.WriteLine($"User with ID {id} not found.");
                return false;
            }
        }



        public User GetEmployee(int id)
        {
            foreach (User user in userSet)
            {
                if (user.Id == id)
                {
                    return user;
                }
            }
            return null;
        }

        public int GetAssignedTaskCount(User user)
        {
            int assignedTasks = 0;

            foreach (Tasks task in Program.tasksList.GetAllTasks())
            {
                if (task.AssignedTo == user.Name)
                {
                    assignedTasks++;
                }
            }

            return assignedTasks;
        }

        public List<User> GetAllEmployees() => userSet;

    }
}
