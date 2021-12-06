using TestProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Service
{
    public interface IUserService
    {
        public void CreateUser(User user);
        public User ReadUser(int id);

        public List<User> ReadUser();
    }
}