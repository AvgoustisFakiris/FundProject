using System;
using TestProject.Model;
using TestProject.Service;
using System.Collections.Generic;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add users to Database
            AddUser();
        }

        static void AddUser()
        {
            using var crmDbContext = new CrmDbContext();
            IUserService userService = new UserService(crmDbContext);

            var newUser = new User
            {
                FirstName = "Test",
                LastName = "Testakis",
                Email = "test@gmail.com",
                Password = "12345"
            };


            var usersService = new UserService(crmDbContext);

            usersService.CreateUser(newUser);
            Console.WriteLine($"id= {newUser.Id}");


        }


    }
}
