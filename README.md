EmployeeManager5

Hello developer! 👋

EmployeeManager is a .NET 10 Blazor Server application for managing employees and departments. It provides full CRUD functionality, communicates with a backend Web API for data operations, and demonstrates clean separation between UI, API, and domain layers. The application is designed following SOLID principles, ensuring maintainable, scalable, and testable code.

Getting Started
Step 1 — Clone and Run EmployeeManager3

Clone the original solution:

git clone https://github.com/shamshar/EmployeeManager3.git


Open the solution in Visual Studio 2022 or newer.

Run database migrations via Package Manager Console:

Update-Database


This creates the local database used by the API.

Step 2 — Clone EmployeeManager5

Clone the repository containing the updated UI and API setup:

git clone https://github.com/shamshar/EmployeeManager5.git


Once opened, ensure the appsettings.json inside the API project contains a valid connection string.
Use the same connection string that was used in Step 1 for EmployeeManager3.

This ensures both projects connect to the same database (schema + seeded data).

Step 3 — Run the Application

Set both API and UI as startup projects and run the solution.

Access the UI at:

https://localhost:<port>/employees

Tech Stack

.NET 10

Blazor Server (UI)

ASP.NET Web API (Backend)

Entity Framework Core (Data access)

SQL Server LocalDB (Database)

Bootstrap 5 (Styling + responsive layout)

HttpClient (Service communication)

Features

✔ Employees Management — Create, edit, delete, and view details

✔ Departments Management — Create, edit, delete, and view details

✔ Form Validation — Required fields & validation

✔ Navigation — Top navigation + sidebar

✔ Responsive UI — Bootstrap for desktop + mobile

✔ Not Found Pages — Handles missing or invalid routes

Architecture Overview
Layer	Responsibility
Domain	DTOs, shared contracts, service interfaces
API	Controllers, EF Core DbContext, services
UI (Blazor Server)	Pages/components calling the API via HttpClient

The application follows SOLID principles, ensuring:

Each layer has a single responsibility

Dependencies are injected appropriately

Code is maintainable, extensible, and testable

Project Structure
EmployeeManager/
├── Domain/          # DTOs + service interfaces
├── Application/     # API controllers, DbContext, EF services
└── UI/              # Blazor Server pages, components, HttpClient services

Notes for Developers

UI communicates with API using typed HttpClient services

Full CRUD implemented for Employees + Departments

Bootstrap styling + validation on all forms

Database shared between EmployeeManager3 + EmployeeManager5

Compatible with Visual Studio 2022 and .NET 10

Designed following SOLID principles for clean, maintainable, and scalable code
