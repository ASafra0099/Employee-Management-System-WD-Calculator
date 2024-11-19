using EmployeeManagement_system.Data;
using EmployeeManagement_system.Models;
using EmployeeManagement_system.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement_system.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _dbContext;

        public EmployeeRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Add a new employee
        public async Task AddAsync(EmployeeViewModel employee)
        {
            var newEmployee = new Employee
            {
                EmployeeID = employee.EmployeeID,
                Name = employee.Name,
                Email = employee.Email,
                JobPosition = employee.JobPosition
            };

            await _dbContext.Employees.AddAsync(newEmployee);
            await _dbContext.SaveChangesAsync();
        }

        // Delete an employee by ID
        public async Task DeleteAsync(int id)
        {
            var employee = await _dbContext.Employees.FindAsync(id);
            if (employee != null)
            {
                _dbContext.Employees.Remove(employee);
                await _dbContext.SaveChangesAsync();
            }
        }

        // Retrieve all employees
        public async Task<List<EmployeeViewModel>> GetAllAsync()
        {
            var employees = await _dbContext.Employees.ToListAsync();
            return employees.Select(employee => new EmployeeViewModel
            {
                EmployeeID = employee.EmployeeID,
                Name = employee.Name,
                Email = employee.Email,
                JobPosition = employee.JobPosition
            }).ToList();
        }

        // Retrieve an employee by ID
        public async Task<EmployeeViewModel> GetByIdAsync(int id)
        {
            var employee = await _dbContext.Employees.FindAsync(id);
            if (employee == null)
                return null;

            return new EmployeeViewModel
            {
                EmployeeID = employee.EmployeeID,
                Name = employee.Name,
                Email = employee.Email,
                JobPosition = employee.JobPosition
            };
        }

        // Update an existing employee
        public async Task UpdateAsync(EmployeeViewModel employeeUpdated)
        {
            var employee = await _dbContext.Employees.FindAsync(employeeUpdated.EmployeeID);
            if (employee != null)
            {
                employee.Name = employeeUpdated.Name;
                employee.Email = employeeUpdated.Email;
                employee.JobPosition = employeeUpdated.JobPosition;

                _dbContext.Employees.Update(employee);
                await _dbContext.SaveChangesAsync();
            }
        }

        // Fetch public holidays within a date range
        public async Task<IEnumerable<DateTime>> GetPublicHolidays(DateTime startDate, DateTime endDate)
        {
            return await _dbContext.PublicHolidays
                .Where(h => h.Date >= startDate && h.Date <= endDate)
                .Select(h => h.Date)
                .ToListAsync();
        }
    }
}
