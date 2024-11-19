using System;
using System.Collections.Generic;
using EmployeeManagement_system.Models;

namespace EmployeeManagement_system.Services
{
    public interface IWorkingDaysService
    {
        // Method to calculate the number of working days between two dates
        int CalculateWorkingDays(DateTime startDate, DateTime endDate);

        // Method to get public holidays within a specified date range
        List<PublicHoliday> GetPublicHolidaysInRange(DateTime startDate, DateTime endDate);
    }
}
