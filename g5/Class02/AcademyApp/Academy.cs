using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp
{
    class Academy
    {
        public string Name { get; set; }
        public List<IUserLike> Users { get; set; }
        public List<Course> Courses { get; set; }
        public IUserLike CurrentUser { get; private set; }

        public Academy(string name)
        {
            Name = name;
            Users = new List<IUserLike>();
            Courses = new List<Course>();
        }

        public void AddUser(IUserLike user)
        {
            Users.Add(user);
            user.Academy = this;
        }

        public void Login(string username)
        {
            try
            {
                CurrentUser = Users.SingleOrDefault(u => u.Username == username);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Log something");
                // throw ex; // Don't do this!!!

                // Catch - and - release, continues the original exception
                // throw; 

                // Creates a new exception that contains the original one, and adds information
                throw new ApplicationException($"More than one user found with username {username}", ex);
            }
        }

        public void LoginWithWhere(string username)
        {
            var allUsersWithagivenUsername = Users.Where(u => u.Username == username).ToList();

            if (allUsersWithagivenUsername.Count == 0)
            {
                CurrentUser = null;
            }
            else if (allUsersWithagivenUsername.Count == 1)
            {
                CurrentUser = allUsersWithagivenUsername[0];
            }
            else
            {
                throw new ApplicationException($"More than one user found with username {username}");
            }

        }
    }
}
