using Microsoft.AspNetCore.Mvc;
using SibersInternshipMind.Shared.DTOs;
using SibersInternshipMind.Shared.Entities;
using SibersInternshipMind.Shared.Services.Contracts;
using System;

namespace SibersInternshipMind.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet("Get")]
        public ActionResult<List<Project>> GetAllProjects()
        {
            return _projectService.GetAllProjects();
        }

        [HttpGet("GetById/{id}")]
        public ActionResult<Project> GetProjectById(int id)
        {
            try
            {
                var project = _projectService.GetProjectById(id);
                return project;
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost("Add")]
        public IActionResult AddProject(ProjectDTO projectDto)
        {
            if (_projectService.AddProject(projectDto))
            {
                return Ok("Project added successfully");
            }
            else
            {
                return BadRequest("Failed to add project");
            }
        }

        [HttpPut("Update/{projectId}")]
        public IActionResult UpdateProject(int projectId, ProjectDTO projectDto)
        {
            if (_projectService.UpdateProject(projectId, projectDto))
            {
                return Ok("Project updated successfully");
            }
            else
            {
                return BadRequest("Failed to update project");
            }
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult DeleteProject(int id)
        {
            if (_projectService.DeleteProject(id))
            {
                return Ok("Project deleted successfully");
            }
            else
            {
                return NotFound("Project not found");
            }
        }
    }
}
