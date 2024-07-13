# Employee Management Module -.NET Backend

This project is a.NET 8 Web API for managing employee records. It utilizes Entity Framework Core with a SQLite database to store employee data.

## Project Setup

To get started with this project, follow these steps:

1. **Prerequisites**

    Ensure you have the following installed:
    -.NET 8 SDK
    - Any compatible IDE (Visual Studio, VS Code, etc.)

2. **Clone the Repository**

    Clone this repository to your local machine:
    

```bash
    git clone https://github.com/SouhailELAFOUI/Employee-Management-Module---.Net-Backend.git
    

    Open and Build the Project

    Open the solution file in your IDE and build the project to restore the necessary NuGet packages.

    Create the Database

    The project uses Entity Framework Core with a SQLite database. To set up the database, run the following command in your terminal or Package Manager Console:

 bash

    dotnet ef database update
    

    Run the Application

    Start the application via your IDE or by running:

 bash

    dotnet run
    

Employee Object

The employee records are stored with the following properties:

    Id (GUID): A unique identifier for the employee.
    FirstName: The first name of the employee.
    LastName: The last name of the employee.
    Email: The email address of the employee.
    PhoneNumber: The phone number of the employee.
    Position: The job position of the employee.
    Department: The department in which the employee works.

API Endpoints

The application exposes the following RESTful endpoints to manage the employees:

    GET /api/employees
        Retrieves a list of all employees.

    GET /api/employees/{id}
        Retrieves details of a specific employee by their ID.

    POST /api/employees
        Creates a new employee record.
        Request body should include FirstName LastName Email PhoneNumber Position and Department.

    PUT /api/employees/{id}
        Updates an existing employee record.
        Request body should include any of FirstName LastName Email PhoneNumber Position and Department fields that are being updated.

    DELETE /api/employees/{id}
        Deletes an employee record by their ID.


 


Feel free to customize this README file as necessary to better fit your project specifics or coding conventions.
