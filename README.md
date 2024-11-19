# Employee-Management-System-WD-Calculator

This is a web application built using C# and MVC that allows users to manage a list of employees (CRUD operations). The system includes functionalities such as adding, updating, and deleting employee records. Additionally, the system provides a working days calculator that computes the number of working days between two dates, excluding weekends and public holidays.

-- NOTE --
In this project, the public holidays data is manually seeded into the database using custom code. The seeding process doesn't rely on any external APIs or libraries. This ensures that the public holidays are available for the working days calculation without any dependencies.

Technologies Used:

- C# (.NET 9.0 Core MVC)
- Entity Framework (EF) Core
- LINQ ( for querying the database and filtering data efficiently)
- ADO.NET (Code First approach)
- Memory Caching (for caching results)
- Bootstrap (for responsive design)
- Delegates (for calculation of working days and caching mechanisms)

Features:

- Employee Management: Create, Update, Delete employee records.
- Working Days Calculator: Calculate working days between two dates, excluding weekends and public holidays.
- Caching: Cached results for faster retrieval of working days calculations.
- Public Holidays Management: Ability to define public holidays in the system.

How to Use:

1. Navigate to the Employee Management page to add, update, or delete employee records.
2. On the Working Days Calculator page, select a start and end date (ensuring the start date is a weekday).
3. The system will display the number of working days, excluding weekends and public holidays.

Code Structure:

- Controllers/
  - EmployeeController.cs: Handles employee-related actions and Manages the working days calculation logic.

- Models/
  - Employee.cs: Represents the employee entity.
  - PublicHoliday.cs: Represents the public holiday entity.

- Services/
  - WorkingDaysService.cs: Contains business logic for calculating working days and caching results.

- Repositories/
  - EmployeeRepository.cs: Handles database operations related to employees and Manages public holiday data operations.

Caching Mechanism:

- The `CachedLong` function caches results indefinitely until manually cleared.
- The `Cached` function caches results for 5 minutes to improve performance.

Installation Instructions:

- Clone the repository to your local machine:
  ```bash
   git clone https://github.com/ASafra0099/Employee-Management-System-WD-Calculator.git
- Navigate to the Project Directory
    ```bash
    cd Employee-Management-System-WD-Calculator
- Restore the required NuGet packages:
    ```bash
    dotnet restore
- Set Up the Database:
    ```bash
    "ConnectionStrings": {
  "DefaultConnection": "Server=yourserver;Database=EmployeeDB;Trusted_Connection=True;MultipleActiveResultSets=true"}
- Apply Migrations:
    ```bash
    dotnet ef database update
- Run the Application:
    ```bash
    dotnet run
