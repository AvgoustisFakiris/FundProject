using TestProject.dto;
using TestProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Service
{
    public class ProjectService : IProjectService
    {
        private readonly CrmDbContext _db;

        public ProjectService(CrmDbContext db)
        {
            _db = db;
        }
        public void CreateProject(Project project)
        {

            _db.Projects.Add(project);
            try { _db.SaveChanges(); }
            catch { }
        }

   

        public bool DeleteProject(int id)
        {
            var dbProject = _db.Projects.Find(id);
            if (dbProject == null) return false;
            _db.Projects.Remove(dbProject);
            return _db.SaveChanges() == 1;
        }

        public Project ReadProject(int id)
        {
            return _db.Projects.Find(id);
        }

        public List<Project> ReadProject(int pageCount, int pageSize)
        {
            if (pageCount <= 0) pageCount = 1;
            if (pageSize <= 0 || pageSize > 20) pageSize = 20;
            return _db.Projects
                .Skip((pageCount - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public Project UpdateProject(int projectId, Project project)
        {
            var dbProject = _db.Projects.Find(projectId);
            if (dbProject == null) throw new KeyNotFoundException();
            dbProject.Title = project.Title;
            dbProject.Description = project.Description;

     
            _db.SaveChanges();
            return dbProject;
        }

    }
}