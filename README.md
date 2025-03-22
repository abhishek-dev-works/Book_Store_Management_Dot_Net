# Book Store Management - Backend

## Overview

This is the backend service for the **Book Store Management** system, built using **.NET 6**. It provides APIs for managing users, books, and borrowing records. The system allows users to borrow multiple books, update records, and filter records based on various criteria.

## Technologies Used

- **.NET 6** (C#)
- **Entity Framework Core** (ORM)
- **SQL Server** (Database)
- **Swagger** (API Documentation)
- **Dependency Injection**

## Setup Instructions

### Prerequisites

- Install **.NET 6 SDK**
- Install **SQL Server**
- Ensure **Visual Studio 2022** or **VS Code** is installed

### Installation

1. Clone the repository:
   ```sh
   git clone https://github.com/your-repo/bookstore-management.git
   ```
2. Navigate to the backend project:
   ```sh
   cd Book_Store_Management_Dot_Net
   ```
3. Restore dependencies:
   ```sh
   dotnet restore
   ```
4. Update database (Ensure connection string is set in `appsettings.json`):
   ```sh
   dotnet ef database update
   ```
5. Run the application:
   ```sh
   dotnet run
   ```

## Configuration - `appsettings.json`

Ensure the `appsettings.json` file contains the correct configurations for the application:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=BookStoreDB;User Id=YOUR_USER;Password=YOUR_PASSWORD;"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "JwtSettings": {
    "Secret": "your_jwt_secret_key",
    "Issuer": "your_issuer",
    "Audience": "your_audience",
    "ExpirationInMinutes": 60
  }
}
```

## API Endpoints

### User Management

| Method | Endpoint          | Description       |
| ------ | ----------------- | ----------------- |
| POST   | `/api/users`      | Create a new user |
| GET    | `/api/users`      | Get all users     |
| GET    | `/api/users/{id}` | Get a user by ID  |

### Book Management

| Method | Endpoint          | Description      |
| ------ | ----------------- | ---------------- |
| POST   | `/api/books`      | Add a new book   |
| GET    | `/api/books`      | Get all books    |
| GET    | `/api/books/{id}` | Get a book by ID |

### Record Management

| Method | Endpoint                | Description                                                 |
| ------ | ----------------------- | ----------------------------------------------------------- |
| POST   | `/api/records`          | Add a new record                                            |
| POST   | `/api/records/multiple` | Add multiple records for a user                             |
| PUT    | `/api/records/{id}`     | Update a record by ID                                       |
| GET    | `/api/records`          | Get all records                                             |
| GET    | `/api/records/filter`   | Get records by filters (User ID, Book ID, Due Date, Status) |

## Features

- Borrow multiple books in a single request.
- Filter records using user ID, book ID, due date (up to a specified date), and status.
- Uses **React Hook Form**, **Redux Toolkit**, and **MUI** in the frontend (upcoming).

## Swagger Documentation

Once the application is running, you can access the **Swagger UI**:

```
http://localhost:{PORT}/swagger/index.html
```

## Contribution

Feel free to open an issue or pull request if you'd like to contribute!

---

**Author:** Abhishek Wilson 🚀

