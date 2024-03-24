using Microsoft.AspNetCore.Mvc;
using SibersInternshipMind.Shared.Services.Contracts;

namespace SibersInternshipMind.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommunicationController : ControllerBase
    {
        private readonly ICommunicationService _communicationService;

        public CommunicationController(ICommunicationService communicationService)
        {
            _communicationService = communicationService;
        }

        [HttpPost("AddEmployeeToProject")]
        public IActionResult AddEmployeeToProject(int projectId, int employeeId)
        {
            var result = _communicationService.AddEmployeeToProject(projectId, employeeId);
            if (result)
            {
                return Ok("Employee added to project successfully");
            }
            else
            {
                return BadRequest("Failed to add employee to project");
            }
        }

        [HttpDelete("DeleteEmployeeFromProject")]
        public IActionResult DeleteEmployeeFromProject(int projectId, int employeeId)
        {
            var result = _communicationService.DeleteEmployeeFromProject(projectId, employeeId);
            if (result)
            {
                return Ok("Employee deleted from project successfully");
            }
            else
            {
                return BadRequest("Failed to delete employee from project");
            }
        }

        [HttpGet("GetAllEmployeesFromProject")]
        public IActionResult GetAllEmployeesFromProject(int projectId)
        {
            var employees = _communicationService.GetAllEmployeesFromProject(projectId);
            return Ok(employees);
        }

        [HttpGet("GetAllProjectsOfOneEmployee")]
        public IActionResult GetAllProjectsOfOneEmployee(int employeeId)
        {
            var projects = _communicationService.GetAllProjectsOfOneEmployee(employeeId);
            return Ok(projects);
        }
    }
}
