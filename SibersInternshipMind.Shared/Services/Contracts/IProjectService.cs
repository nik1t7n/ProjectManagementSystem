

using SibersInternshipMind.Shared.DTOs;
using SibersInternshipMind.Shared.Entities;

namespace SibersInternshipMind.Shared.Services.Contracts
{
    public interface IProjectService
    {
        List<Project> GetAllProjects();
        Project GetProjectById(int projectId);
        bool AddProject(ProjectDTO projectDto);
        bool UpdateProject(int projectId, ProjectDTO projectDto);
        bool DeleteProject(int projectId);
    }
}
