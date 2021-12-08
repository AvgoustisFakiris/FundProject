using TestProject.dto;
using TestProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Service
{
    public interface IProjectService
    {
        public void CreateProject(Project project);
        public Project ReadProject(int id);
        public bool DeleteProject(int id);

        public List<Project> ReadProject(int pageCount, int pageSize);

    }
}
