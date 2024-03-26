# Project Name: Project Management System

## Overview
This project is a web application designed for managing projects, employees, and documents within a company. It provides functionalities for adding, updating, and deleting projects and employees, as well as managing project-related documents. The application also allows for communication between employees and project management.

## Features
- **Project Management**: Add, update, and delete projects with details such as name, start date, end date, priority, and associated employees.
- **Employee Management**: Manage employee information including first name, surname, middle name, and email address.
- **Document Management**: Upload and manage project-related documents with name, file path, file type, and associated project.
- **Communication**: Add and remove employees from projects, view all employees associated with a project, and see all projects of a specific employee.

## Architecture
The project follows a layered architecture with separate components for entities, DTOs (Data Transfer Objects), services, and controllers. The entities represent the database tables, DTOs are used for data transfer between layers, services handle business logic, and controllers manage API endpoints.

## Logic
- **Data Validation**: Data validation is implemented using Data Annotations in the entity classes to ensure that required fields are provided and have the correct data types.
- **Sorting**: Sorting functionality is implemented in the Projects.razor file to allow users to sort projects based on specific criteria.
- **Filters**: Filtering functionality is available in the Projects.razor file, enabling users to filter projects based on project ID, start date, and priority.
- **Error Handling**: Error handling is managed in the States folder, where custom error pages are stored. In case of an error, users are redirected to these error pages to provide a better user experience.

## Data Validation
Data validation is enforced using Data Annotations in the entity classes. Required fields are marked with the `[Required]` attribute, ensuring that essential information is provided when creating or updating entities.

---
 Likewise, it is allowed to filter and sort Projects and Employees!
 
 ---

## Sorting 
Click on the column header to sort the projects by that column. Clicking again on the same column header will reverse the sorting order.

## Filtering
If you want to filter the projects, click the "Show Filters" button. It will reveal filter options for Project ID (Min and Max), Start Date (Min and Max), and Priority (Min and Max). Enter the desired filter values and click "Apply Filters" to see the filtered projects.

To reset the sorting, click the "Reset Sorting" button. To reset the filters, click the "Reset Filters" button. You can hide the filters by clicking the "Hide Filters" button.

To sort just click on the column header ^_^

## Error Handling
Error handling is crucial for providing a smooth user experience. Custom error pages are stored in the States folder, and users are redirected to these pages in case of an error to ensure that they receive informative feedback and guidance.

## Project Demostration
You can check all of screenshots in the [Project Demonstration](ProjectDemonstration.md) file
.
