using Microsoft.AspNetCore.Mvc;
using TestProject.Model;
using TestProject.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Authorization;

namespace TestProjectMvc.Controllers
{
    public class LoginController : Controller
    {
/*
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Index(User user)
        {
            CrmDbContext db = new CrmDbContext();
            var obj = db.Users.Where(a => a.Email.Equals(user.Email) && a.Password.Equals(user.Password)).FirstOrDefault();
           

                string message = string.Empty;
            switch (obj.Value)
            {
                case -1:
                    message = "Username and/or password is incorrect.";
                    break;
                case -2:
                    message = "Account has not been activated.";
                    break;
                default:
                    FormsAuthentication.SetAuthCookie(user.Username, user.RememberMe);
                    return RedirectToAction("Profile");
            }

            ViewBag.Message = message;
            return View(user);
        }
*/















        /*
            CrmDbContext db = new CrmDbContext();
            //GET: HOME

            public IActionResult Index()
            {
                return View();
            }

            [HttpPost]
            public ActionResult Index(User user)
            {
                if (ModelState.IsValid)
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                }
                return View();
            }
        */
    }
}
