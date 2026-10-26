# Customer Management API

## Description

This API is built with C#, ASP.NET Core, Entity Framework Core, and SQLite. It provides CRUD operations that allow users to create, read, update, and delete customer records stored in a SQLite database.

## Technologies

- **C#** - Programming language used to build the application logic.
- **ASP.NET Core** - Web framework used to build the API and handle HTTP requests, routing, and responses.
- **Entity Framework Core (EF Core)** - Allows the C# application to interact with the database using C# objects and methods.
- **SQLite** - Stores application data persistently in a local database.

## Features

- Create a new customer using POST
- Retrieve all customers using GET
- Retrieve a customer by ID using GET
- Update an existing customer using PUT
- Delete an existing customer using DELETE

## API Endpoints

| Method | Endpoint              | Description                              |
| ------ | --------------------- | ---------------------------------------- |
| GET    | `/api/customers`      | Retrieve all customers                   |
| GET    | `/api/customers/{id}` | Retrieve a customer by the specified ID  |
| POST   | `/api/customers`      | Creates a new customer                   |
| PUT    | `/api/customers/{id}` | Updates a customer with the specified ID |
| DELETE | `/api/customers/{id}` | Deletes a customer with the specified ID |

## Database Setup

The SQLite database file is not included in the repository. The database can be created locally using the included Entity Framework Core migrations.

### Requirements

- .NET 10 SDK
- Entity Framework Core tools (`dotnet-ef`)

### Create the Database

Restore the project dependencies:

```bash
dotnet restore
```

Create the database:

```bash
dotnet ef database update
```

## Running the Application

Start the API:

```bash
dotnet run
```

The API will start on the local URL displayed in the terminal.

## Example Request

Create a new customer:

```bash
curl -X POST http://localhost:5047/api/customers \
-H "Content-Type: application/json" \
-d '{
  "firstName": "David",
  "lastName": "Brown",
  "email": "david@example.com",
  "active": true
}'
```
