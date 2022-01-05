using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NorthParallelProjectManagmentSoftware.Data
{
    public class ProjectServices
    {
        private readonly ApplicationDbContext _appDBContext;

        public ProjectServices(ApplicationDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        //Get list of all projects
        public async Task<List<Project>> GetAllProjectsAsync()
        {
            return await _appDBContext.Project.ToListAsync();
        }

        //Add new project
        public async Task<bool> InsertProjectAsync(Project project)
        {
            await _appDBContext.Project.AddAsync(project);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        public async Task<Project> GetProjectByuserId(int Id)
        {
            Project projectByUid = new Project();
            List<User> user = await _appDBContext.User.ToListAsync();
            List<Project> project = await _appDBContext.Project.ToListAsync();
            foreach (var users in user)
            {
                if (users.UserId == Id)
                {

                    foreach (var prj in project)
                    {

                        if (prj.ProjectName == users.UserAssignedProjects.ProjectName)
                        {

                            projectByUid = prj;
                        }
                    }
                }
            }

            return projectByUid;
        }

        //Get project by ProjectId
        public async Task<Project> GetProjectAsync(int Id)
        {
            Project project = await _appDBContext.Project.FirstOrDefaultAsync(c => c.ProjectId.Equals(Id));
            return project;
        }
        //Get project by ProjectCompany
        public async Task<List<Project>> GetProjectByCompanyAsync(string Company)
        {
            List<Project> projectByCompany = new List<Project>();
            List<Project> project = await _appDBContext.Project.ToListAsync();
            foreach (var prj in project)
            {

                if (prj.ProjectCompany.CompanyName.ToString() == Company)
                {

                    projectByCompany.Add(prj);
                }

            }

            return projectByCompany;
        }

        public async Task<List<Project>> GetProjectByMainCompanyAsync(string MainCompany)
        {
            List<Project> projectByCompany = new List<Project>();
            List<Project> project = await _appDBContext.Project.ToListAsync();
            foreach (var prj in project)
            {

                if (prj.MainCompany == MainCompany)
                {

                    projectByCompany.Add(prj);
                }

            }

            return projectByCompany;
        }

        //Update project
        public async Task<bool> UpdateProjectAsync(Project project)
        {
            _appDBContext.Project.Update(project);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        //Delete project
        public async Task<bool> DeleteProjectAsync(Project project)
        {
            _appDBContext.Project.Remove(project);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
    }
}
