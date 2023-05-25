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

        public void AddUser(User user)
        {
            if (userSet.Any(e => e.Username == user.Username))
            {
                throw new DublicateUsernameException("Username already exists in the system.");
            }
            else
            {
                // Generate a new unique ID
                int newId = userSet.Any() ? (userSet.Max(usr => usr.Id) + 1) : 0;
                user.Id = newId;

                userSet.Add(user);
            }
        }

        public bool RemoveUser(int id)
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



        public User GetUser(int id)
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

        public User GetByUsername(string username)
        {
            foreach (User user in userSet)
            {
                if (user.Username == username)
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

        public List<User> GetAllUsers() => userSet;

        public List<User> GetAllEmployees() => userSet.Where(user => user.IsEmployee == true).ToList();

    }
}
