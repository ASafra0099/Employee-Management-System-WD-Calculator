using EmployeeManagement_system.Models;
using EmployeeManagement_system.ViewModels;

namespace EmployeeManagement_system.Repositories
{
    public interface IEmployeeRepository
    {
        Task<EmployeeViewModel> GetByIdAsync(int id);    // Fetches a specific employee by their ID
        Task<List<EmployeeViewModel>> GetAllAsync();      // Fetches a list of all employees
        Task AddAsync(EmployeeViewModel employee);    // Adds a new employee to the database
        Task UpdateAsync(EmployeeViewModel employee);      // Updates the details of an existing employee
        Task DeleteAsync(int id);   // Deletes an employee from the database based on their ID
        Task<IEnumerable<DateTime>> GetPublicHolidays(DateTime startDate, DateTime endDate);   // Task to fetch public holidays within a specified date range
    }
}
