
using SibersInternshipMind.Shared.Entities;

namespace SibersInternshipMind.Shared.Services.Contracts
{
    public interface ICommunicationService
    {
        bool AddEmployeeToProject(int projectId, int employeeId);
        bool DeleteEmployeeFromProject(int projectId, int employeeId);
        List<Employee> GetAllEmployeesFromProject(int projectId);
        List<Project> GetAllProjectsOfOneEmployee(int employeeId);
    }
}
