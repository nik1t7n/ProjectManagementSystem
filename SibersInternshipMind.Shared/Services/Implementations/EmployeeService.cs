

using SibersInternshipMind.Shared.Data;
using SibersInternshipMind.Shared.DTOs;
using SibersInternshipMind.Shared.Entities;
using SibersInternshipMind.Shared.Services.Contracts;
using System.Xml.Linq;

namespace SibersInternshipMind.Shared.Services.Implementations
{
    public class EmployeeService : IEmployeeService
    {
        private readonly DataContext _dataContext;
        public EmployeeService(DataContext dataContext) 
        { 
            _dataContext = dataContext;
        }
        public bool AddEmployee(EmployeeDTO employeeDto)
        {
            Employee employeeToAdd = new Employee()
            {
                FirstName = employeeDto.FirstName,
                Surname = employeeDto.Surname,
                MiddleName = employeeDto.MiddleName,
                Email = employeeDto.Email,
            };

            _dataContext.Add(employeeToAdd);
            
            return _dataContext.SaveChanges() > 0;
        }

        public bool DeleteEmployee(int employeeId)
        {
            Employee? employeeToDelete = _dataContext.Employees.Find(employeeId);

            if (employeeToDelete == null)
            {
                return false;
            }

            _dataContext.Employees.Remove(employeeToDelete);

            return _dataContext.SaveChanges() > 0;
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = _dataContext.Set<Employee>().ToList();
            return employees;
        }

        public Employee GetEmployeeById(int employeeId)
        {
            Employee? employee = _dataContext.Find<Employee>(employeeId);

            if (employee != null)
            {
                return employee;
            }
            else
            {
                throw new Exception("Employee not found!");
            }
           
        }

        public bool UpdateEmployee(int employeeId, EmployeeDTO employeeDto)
        {
            Employee? existingEmployee = _dataContext.Employees.Find(employeeId);

            if (existingEmployee == null)
            {
                return false;
            }

            existingEmployee.FirstName = employeeDto.FirstName;
            existingEmployee.Surname = employeeDto.Surname;
            existingEmployee.MiddleName = employeeDto.MiddleName;
            existingEmployee.Email = employeeDto.Email;

            return _dataContext.SaveChanges() > 0;
        }

    }
}
