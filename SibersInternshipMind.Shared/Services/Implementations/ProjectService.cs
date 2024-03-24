

using SibersInternshipMind.Shared.Data;
using SibersInternshipMind.Shared.DTOs;
using SibersInternshipMind.Shared.Entities;
using SibersInternshipMind.Shared.Services.Contracts;

namespace SibersInternshipMind.Shared.Services.Implementations
{
    public class ProjectService : IProjectService
    {
        private readonly DataContext _dataContext;
        public ProjectService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public bool AddProject(ProjectDTO projectDto)
        {
            Project projectToAdd = new Project()
            {
                Name = projectDto.Name,
                ClientCompany = projectDto.ClientCompany,
                VendorCompany = projectDto.VendorCompany,
                ManagerId = projectDto.ManagerId,
                StartDate = projectDto.StartDate,
                EndDate = projectDto.EndDate,
                Priority = projectDto.Priority,
            };

            _dataContext.Add(projectToAdd);

            return _dataContext.SaveChanges() > 0;
        }

        public bool DeleteProject(int projectId)
        {
            Project? projectToDelete = _dataContext.Projects.Find(projectId);

            if (projectToDelete == null)
            {
                return false;
            }

            _dataContext.Projects.Remove(projectToDelete);

            return _dataContext.SaveChanges() > 0;
        }

        public List<Project> GetAllProjects()
        {
            List<Project> projects = _dataContext.Set<Project>().ToList();
            return projects;
        }

        public Project GetProjectById(int projectId)
        {
            Project? project = _dataContext.Find<Project>(projectId);

            if (project != null)
            {
                return project;
            }
            else
            {
                throw new Exception("Project not found!");
            }
        }

        public bool UpdateProject(int projectId, ProjectDTO projectDto)
        {
            Project? existingProject = _dataContext.Projects.Find(projectId);

            if (existingProject == null)
            {
                return false;
            }

            existingProject.Name = projectDto.Name;
            existingProject.ClientCompany = projectDto.ClientCompany;
            existingProject.VendorCompany = projectDto.VendorCompany;
            existingProject.ManagerId = projectDto.ManagerId;
            existingProject.StartDate = projectDto.StartDate;
            existingProject.EndDate = projectDto.EndDate;
            existingProject.Priority = projectDto.Priority;

            return _dataContext.SaveChanges() > 0;
        }
    }
}
