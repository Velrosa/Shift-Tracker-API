# Shift Tracker API
- A C# ASP.NET Core Web API, Consumers can CRUD Shift data via HTTP requests.
- an API that handles HTTP requests (GET, POST, PUT, DELETE)
- Requests are sent through a Controller <-> IRepository <-> Repository <-> Entity Framework <-> SQL server (database)
- Has a Console Application which consumes the API: https://github.com/Velrosa/Shift-Tracker-Console-App

# Features

* ![API-Project-Layout](https://user-images.githubusercontent.com/101323127/163812270-1b4f5b76-16a3-479a-b8bd-8e006356ee03.png)

* Shift Controller for handling HTTP requests

* Shift Model for handling of data
  - ![API-Shift-Model](https://user-images.githubusercontent.com/101323127/163812821-9213023a-0f2b-4446-87a0-ce4eb8e4ace7.png)
* Shift Context for creation of entitys (entity framework)

* IShiftRepository for abstraction layer between Controller and Repository

* ShiftRepository for concrete implementation of Entity context database handling

* App.config for storage of connection strings

# Packages

* Microsoft.EntityFrameworkCore.SqlServer
* System.Configuration.ConfigurationManager
