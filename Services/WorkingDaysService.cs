using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Caching.Memory;
using EmployeeManagement_system.Models;
using EmployeeManagement_system.Repositories;
using EmployeeManagement_system.Data;

namespace EmployeeManagement_system.Services
{
    public class WorkingDaysService : IWorkingDaysService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly AppDbContext _context; // DbContext to access PublicHolidays
        private readonly IMemoryCache _cache;  // MemoryCache for caching

        // Delegate to calculate working days
        public delegate int CalculateWorkingDaysDelegate(DateTime startDate, DateTime endDate, List<DateTime> publicHolidays);

        public WorkingDaysService(IEmployeeRepository employeeRepository, AppDbContext context, IMemoryCache cache)
        {
            _employeeRepository = employeeRepository;
            _context = context; // Inject DbContext
            _cache = cache;     // Inject MemoryCache
        }

        // Method to calculate working days excluding weekends and public holidays
        public int CalculateWorkingDays(DateTime startDate, DateTime endDate)
        {
            if (startDate > endDate)
            {
                throw new ArgumentException("Start date must be before end date.");
            }

            // Generate a cache key based on the date range
            var cacheKey = $"WorkingDays_{startDate.ToString("yyyyMMdd")}_{endDate.ToString("yyyyMMdd")}";

            // Try to get the cached value
            if (_cache.TryGetValue(cacheKey, out int cachedWorkingDays))
            {
                return cachedWorkingDays; // Return cached value if available
            }

            // Get the public holidays within the date range
            var publicHolidays = _context.PublicHolidays
                .Where(ph => ph.Date >= startDate && ph.Date <= endDate)
                .Select(ph => ph.Date)
                .ToList();

            // Create delegate and assign the method to use for calculation
            CalculateWorkingDaysDelegate calculateWorkingDaysDelegate = CalculateWorkingDaysExcludeWeekendsAndHolidays;

            // Use the delegate to calculate the working days
            int workingDays = calculateWorkingDaysDelegate(startDate, endDate, publicHolidays);

            // Store the result in cache for 5 minutes
            _cache.Set(cacheKey, workingDays, TimeSpan.FromMinutes(5));

            return workingDays;
        }

        // Method to calculate working days excluding weekends and public holidays
        public int CalculateWorkingDaysExcludeWeekendsAndHolidays(DateTime startDate, DateTime endDate, List<DateTime> publicHolidays)
        {
            int workingDays = 0;

            // Iterate over the dates in the given range
            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                // Skip weekends (Saturday and Sunday)
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    continue;
                }

                // Skip public holidays
                if (publicHolidays.Contains(date.Date))
                {
                    continue;
                }

                // Count this as a working day
                workingDays++;
            }

            return workingDays;
        }

        // Method to get public holidays in the given date range
        public List<PublicHoliday> GetPublicHolidaysInRange(DateTime startDate, DateTime endDate)
        {
            // Retrieve the public holidays that fall within the given date range
            return _context.PublicHolidays
                           .Where(ph => ph.Date >= startDate && ph.Date <= endDate)
                           .ToList();
        }
    }
}
