using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using EmployeeManagement_system.Models;
using EmployeeManagement_system.ViewModels;
using EmployeeManagement_system.Repositories;
using EmployeeManagement_system.Services;
using System.Threading.Tasks;
using System;

namespace EmployeeManagement_system.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IWorkingDaysService _workingDaysService;
        public EmployeeController(IEmployeeRepository employeeRepository, IWorkingDaysService workingDaysService)
        {
            _employeeRepository = employeeRepository;
            _workingDaysService = workingDaysService;
        }
        public async Task<IActionResult> Index(string searchString)
        {
            var employees = await _employeeRepository.GetAllAsync();

            return View(employees);
        }

        //GET: Employee//Add
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        //POST: Employee//Add
        [HttpPost]
        public async Task<IActionResult> Add(EmployeeViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);  //return to the form with validations
            }

            //Insert data to the database
            await _employeeRepository.AddAsync(model);
            //Redirect to list all employees
            return RedirectToAction("Index", "Employee");
        }


        //GET: Employee//Update
        [HttpGet]
        public async Task<IActionResult>Update(int id)
        {
            //Fetch the employee details
            var employee = await _employeeRepository.GetByIdAsync(id);
            return View(employee);
        }

        //POST: Employee//Update
        [HttpPost]
        public async Task<IActionResult> Update(EmployeeViewModel employee)
        {

            if (!ModelState.IsValid)
            {
                return View(employee); // Return to the form with validation errors
            }
            //Update the database with modified details
            await _employeeRepository.UpdateAsync(employee);

            // Redirect to List all employee page
            return RedirectToAction("Index", "Employee");
        }

        //GET: Employee//Dalete
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            //Delete the data from database
            await _employeeRepository.DeleteAsync(id);
            // Redirect to List all employee page
            return RedirectToAction("Index", "Employee");
        }

        // GET: Employee/CalculateWorkingDays
        [HttpGet]
        public IActionResult CalculateWorkingDays()
        {
            return View();
        }

        // POST: Employee/CalculateWorkingDays
        [HttpPost]
        public IActionResult CalculateWorkingDays(DateTime startDate, DateTime endDate)
        {
            // Ensure start date is not on a weekend
            if (startDate.DayOfWeek == DayOfWeek.Saturday || startDate.DayOfWeek == DayOfWeek.Sunday)
            {
                ModelState.AddModelError("startDate", "Start date must be a weekday (Monday to Friday).");
                return View();
            }

            // Ensure start date is before end date
            if (startDate > endDate)
            {
                ModelState.AddModelError("", "Start date must be before end date.");
                return View();
            }

            // Get the public holidays within the date range
            var publicHolidays = _workingDaysService.GetPublicHolidaysInRange(startDate, endDate);

            int workingDays = 0;
            List<string> holidaysAndWeekends = new List<string>();

            // Loop through each day in the given range, including both start and end dates
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                // Check if it's a weekend
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysAndWeekends.Add($"Weekend ({date:dd/MM/yyyy})");
                }
                else
                {
                    // Check if it's a public holiday
                    var holiday = publicHolidays.FirstOrDefault(ph => ph.Date.Date == date.Date);
                    if (holiday != null)
                    {
                        holidaysAndWeekends.Add($"{holiday.Description} ({date:dd/MM/yyyy})");
                    }
                    else
                    {
                        // Increment working days if it's not a holiday
                        workingDays++;
                    }
                }
            }

            // Store the working days and holidays/ weekends information in ViewBag
            ViewBag.WorkingDays = workingDays;
            ViewBag.HolidaysAndWeekends = holidaysAndWeekends;

            return View();
        }




    }
}
