using TestProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Service
{
    public class UserService : IUserService
    {
        private readonly CrmDbContext dbContext;

        public UserService(CrmDbContext adbContext)
        {
            dbContext = adbContext;
        }


        public void CreateUser(User user)
        {
            dbContext.Users.Add(user);
            try { dbContext.SaveChanges(); }
            catch { }
        }

        public User ReadUser(int id)
        {

            User user = dbContext.Users.Find(id);
            return user;
        }

        public List<User> ReadUser()
        {
            return dbContext.Users.ToList();
        }
    }

}
