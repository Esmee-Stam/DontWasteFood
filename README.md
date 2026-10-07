# Server-Side Web Development – Meal Reservation System

## About this project

This project is a web application for reducing food waste at Avans University. The application allows canteen employees to offer leftover food packages at a reduced price, which students can reserve and collect at a later time.

The application was developed using **ASP.NET Core 8 and C#** and follows the **Clean/Onion Architecture** principle. The solution is separated into different layers, including the domain, application logic, infrastructure, web application, and web API.

## Features

- Students can view available food packages and their reservations
- Students can reserve available packages
- Canteen employees can create, edit, and remove packages
- Packages can contain multiple products
- Age restrictions for packages containing alcohol
- Filtering packages by location and meal type
- Prevention of duplicate reservations
- Authentication and authorization using Microsoft Identity
- RESTful Web API
- GraphQL endpoint
- Swagger API documentation

## Architecture

The application follows the **Clean/Onion Architecture**, with the domain model and business logic at the core of the application.

The project uses:

- **ASP.NET Core 8**
- **C#**
- **Entity Framework Core** with Code First and migrations
- **SQL Server**
- **Microsoft Identity** for authentication and authorization
- **Repository pattern** using interfaces
- **Dependency Injection**
- **RESTful Web API (RMM Level 2)**
- **GraphQL**
- **Unit testing and mocking**
- **Postman** for API testing

## Testing

Business rules are covered with unit tests, including both successful and invalid scenarios. Mocking is used to isolate dependencies such as repositories.

The Web API endpoints are also tested using Postman.

## Project Context

The application was developed as part of the Server-Side Web Development course. The assignment focused on building a maintainable, scalable and testable web application while applying software architecture principles and automated development practices.
