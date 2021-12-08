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
            //   AddUser();

            //Add project to Database
            AddProject();
        }

        static void AddUser()
        {
            using var crmDbContext = new CrmDbContext();
            IUserService userService = new UserService(crmDbContext);

            var newUser = new User
            {
                FirstName = "Testb",
                LastName = "Testakisb",
                Email = "testb@gmail.com",
                Password = "12345"
            };


            var usersService = new UserService(crmDbContext);

            usersService.CreateUser(newUser);
            Console.WriteLine($"id= {newUser.Id}");


        }

        static void AddProject()
        {
            using var crmDbContext = new CrmDbContext();
            IUserService userService = new UserService(crmDbContext);

            var newProject = new Project
            {
              //  Title = "TestPro",
                Description = "give money",
                CurrentAmount = 0,
                TotalBackers = 0,
                GoalAmount = 100,
                Category = Category.Cars,
                FundPackages = FundPackage.GOLD,
                User = userService.ReadUser(5)

            };


            var projectService = new ProjectService(crmDbContext);

            projectService.CreateProject(newProject);




        }


    }
}
