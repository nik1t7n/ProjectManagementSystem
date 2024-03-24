

using SibersInternshipMind.Shared.Data;
using SibersInternshipMind.Shared.Entities;
using SibersInternshipMind.Shared.DTOs;

namespace SibersInternshipMind.Shared.Services.Contracts
{
    public interface IEmployeeService
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployeeById(int employeeId);
        bool AddEmployee(EmployeeDTO employeeDto);
        bool UpdateEmployee(int employeeId, EmployeeDTO employeeDto);
        bool DeleteEmployee(int employeeId);
    }
}
