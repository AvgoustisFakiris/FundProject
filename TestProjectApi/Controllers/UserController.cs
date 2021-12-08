using Microsoft.AspNetCore.Mvc;
using TestProject.Model;
using TestProject.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet("/ping")]
        public string Ping()
        {
            return "it works";
        }


        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return userService.ReadUser();
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return userService.ReadUser(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public User Post([FromBody] User user)
        {
            userService.CreateUser(user);
            return user;
        }


    }
}
