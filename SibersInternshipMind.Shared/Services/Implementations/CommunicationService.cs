

using SibersInternshipMind.Shared.Data;
using SibersInternshipMind.Shared.Entities;
using SibersInternshipMind.Shared.Services.Contracts;

namespace SibersInternshipMind.Shared.Services.Implementations
{
    public class CommunicationService : ICommunicationService
    {
        private readonly DataContext _dataContext;
        private readonly IEmployeeService _employeeService;
        private readonly IProjectService _projectService;

        public CommunicationService(DataContext dataContext, IEmployeeService employeeService, IProjectService projectService)
        {
            _dataContext = dataContext;
            _employeeService = employeeService;
            _projectService = projectService;
        }

        public bool AddEmployeeToProject(int projectId, int employeeId)
        {
            var activeProject = new ActiveProject
            {
                ProjectId = projectId,
                EmployeeId = employeeId
            };

            _dataContext.ActiveProjects.Add(activeProject);

            return _dataContext.SaveChanges() > 0;
        }

        public bool DeleteEmployeeFromProject(int projectId, int employeeId)
        {
            var employeeToDeleteFromProject = _dataContext.ActiveProjects.FirstOrDefault(ap => ap.ProjectId == projectId && ap.EmployeeId == employeeId);

            if (employeeToDeleteFromProject == null)
            {
                return false;
            }

            _dataContext.ActiveProjects.Remove(employeeToDeleteFromProject);

            return _dataContext.SaveChanges() > 0;
        }

        public List<Employee> GetAllEmployeesFromProject(int projectId)
        {
            // find all records in the table ActiveProject, where ProjectId equals specified projectId
            var activeProjects = _dataContext.ActiveProjects.Where(ap => ap.ProjectId == projectId).ToList();

            // create a list to store employees
            var employees = new List<Employee>();

            // to each record in table ActiveProject find employee by his EmployeeId and add him to the List
            foreach (var activeProject in activeProjects)
            {
                var employee = _employeeService.GetEmployeeById(activeProject.EmployeeId);
                if (employee != null)
                {
                    employees.Add(employee);
                }
            }

            return employees;
        }

        public List<Project> GetAllProjectsOfOneEmployee(int employeeId)
        {
            var activeProjects = _dataContext.ActiveProjects.Where(ap => ap.EmployeeId == employeeId).ToList();

            var projects = new List<Project>();

            foreach (var activeProject in activeProjects)
            {
                var project = _projectService.GetProjectById(activeProject.ProjectId);
                if (project != null && !projects.Contains(project))
                {
                    projects.Add(project);
                }
            }

            return projects;
        }
    }
}
