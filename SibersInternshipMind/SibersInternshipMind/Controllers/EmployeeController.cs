using Microsoft.AspNetCore.Mvc;
using SibersInternshipMind.Shared.DTOs;
using SibersInternshipMind.Shared.Entities;
using SibersInternshipMind.Shared.Services.Contracts;
using System;
using System.Collections.Generic;

namespace SibersInternshipMind.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("GetAll")]
        public ActionResult<List<Employee>> GetAllEmployees()
        {
            return _employeeService.GetAllEmployees();
        }

        [HttpGet("GetById/{id}")]
        public ActionResult<Employee> GetEmployeeById(int id)
        {
            try
            {
                var employee = _employeeService.GetEmployeeById(id);
                return employee;
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost("Add")]
        public IActionResult AddEmployee(EmployeeDTO employeeDto)
        {
            if (_employeeService.AddEmployee(employeeDto))
            {
                return Ok("Employee added successfully");
            }
            else
            {
                return BadRequest("Failed to add employee");
            }
        }

        [HttpPut("Update/{employeeId}")]
        public IActionResult UpdateEmployee(int employeeId, EmployeeDTO employeeDto)
        {
            if (_employeeService.UpdateEmployee(employeeId, employeeDto))
            {
                return Ok("Employee updated successfully");
            }
            else
            {
                return BadRequest("Failed to update employee");
            }
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            if (_employeeService.DeleteEmployee(id))
            {
                return Ok("Employee deleted successfully");
            }
            else
            {
                return NotFound("Employee not found");
            }
        }
    }
}
