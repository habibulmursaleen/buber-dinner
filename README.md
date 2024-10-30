## BuberDinner

- [BuberDinner](#buberdinner)
  - [Requirements](#requirements)
  - [Architecture Overview](#architecture-overview)
  - [Setup](#setup)
    - [Step 1: Clone the Repository](#step-1-clone-the-repository)
    - [Step 2: Set Up Database](#step-2-set-up-database)
    - [Step 3: Apply Migrations](#step-3-apply-migrations)
    - [Step 4: Build and run](#step-4-build-and-run)
    - [Other Commands](#other-commands)


### Requirements

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0) or later
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or any database of your choice)
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/) (Recommended for development)

### Architecture Overview

This project is structured based on Clean Architecture, with separation into the following main layers:

- **Core** - Contains the Domain layer, including entities, aggregates, value objects, and domain services.
- **Application** - Contains use cases, DTOs, and interfaces.
- **Infrastructure** - Contains the implementations of repositories, data access, and integrations.
- **WebApi** - The entry point for the API, handling requests and responses.


### Setup
You can run the application in two ways:
1. Local application
> ⚠️ This way need to have separate database running on your local machine for some requests.


####  Step 1: Clone the Repository

```bash
git clone https://github.com/habibulmursaleen/NorskApi
cd NorskApi
```

####  Step 2: Set Up Database
Ensure your SQL Server is running. Update the connection string in appsettings.Development.json located in the WebApi project:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=MyDatabase;User Id=your-username;Password=your-password;"
  }
}

```

####  Step 3: Apply Migrations
Navigate to the Infrastructure layer where the DbContext is located and run the following commands to apply migrations:
```bash
dotnet ef migrations add InitialCreate --project src/Infrastructure --startup-project src/WebApi
dotnet ef database update --project src/Infrastructure --startup-project src/WebApi
```

#### Step 4: Build and run
Navigate to the WebApi project directory and start the API:

```
dotnet run --project .\BuberDinner.Api\
```

#### Other Commands

```
dotnet test
dotnet watch
dotnet run
dotnet build
```


1. Docker

Application has `docker-compose` file for running the application with MSSQL Server database in container. 
To run the application using Docker you have to have it installed on your machine. Then close (or downlaod) this repository. 
In the main folder type the command:
```
docker-compose up -d --build
```

In both ways of running the application, you have to use migrations for creating tables to fully use the application.
