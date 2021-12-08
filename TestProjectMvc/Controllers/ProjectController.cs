using Microsoft.AspNetCore.Mvc;
using TestProject.Model;
using TestProject.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace TestProject.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectService projectService;

        public ProjectController(IProjectService projectService)
        {
            this.projectService = projectService;
        }

        public IActionResult Index()
        {
            List<Project> projects = projectService.ReadProject(1, 10);
            return View(projects);
        }

        public IActionResult Get(int id)
        {
            Project project = projectService.ReadProject(id);
            return View(project);
        }

    }
}