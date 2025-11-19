# IntegrApi

[![.NET](https://img.shields.io/badge/.NET-8+-blue)](https://dotnet.microsoft.com/)  

> A clean, minimal API example implemented in **C# .NET**, designed as a lightweight template and learning resource.

---

## 💡 Table of Contents

- [About](#about)  
- [Features](#features)  
- [Getting Started](#getting-started)  
  - [Prerequisites](#prerequisites)  
  - [Installation](#installation)  
  - [Running the API](#running-the-api)  
- [API Overview](#api-overview)  
- [Project Structure](#project-structure)  
- [Configuration](#configuration)  
- [Testing & Requests](#testing--requests)  
- [Contributing](#contributing)  
- [Contact](#contact)

---

## About

IntegrApi is a minimalist example of a RESTful API built using the **.NET minimal API** style (available since .NET 6), focused on simplicity and best practices. The goal is to serve both as:

- A **boilerplate** for microservices or small backend services.  
- A learning tool to understand how to set up and organize a minimal API in C#.

Minimal APIs reduce boilerplate compared to traditional controller-based ASP.NET projects, making them ideal for lightweight apps, microservices, or rapid prototyping. :contentReference[oaicite:0]{index=0}

---

## Features

- 🚀 Minimal setup with **Program.cs** as the entry point  
- 📡 Simple CRUD endpoints  
- 🔧 Configuration using `appsettings.json`  
- 📁 Layered architecture: Models, Properties, etc.  
- 💬 HTTP request examples using `.http` file  
- 🧪 Ready for further integration with testing suites or middleware  

---

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download) (or later)  
- A code editor such as [Visual Studio](https://visualstudio.microsoft.com/), [VS Code](https://code.visualstudio.com/) or [Rider](https://www.jetbrains.com/rider/)  
- (Optional) Postman, curl, or HTTP client to test API endpoints  

---

### Installation

1. Clone the repository:

   ```bash
	git clone https://github.com/dannylbr/IntegrApi.git
	cd IntegrApi
	```

2. Restore NuGet packages:
   ```bash
   dotnet restore
   ```

3. Build the project:
   ```bash
   dotnet build
   ```

### Running the API
To run the API locally, use the following command:
```bash
   dotnet run --project IntegrApi
   ```

By default, the application will start listening on a configured port (as defined in `appsettings.json`, if any). You can explore the HTTP endpoints or run the `.http` file included in the repo to test it quickly.

### API Overview

Below is a conceptual overview of the possible endpoints:

| Method   | Route            | Description               |
| -------- | ---------------- | ------------------------- |
| `GET`    | `/`			  | Return "Elegant."         |
| `GET`    | `/user/{id}`     | Return a boilerplate User |

### Project Structure

```graphql
IntegrApi/
│
├── Models/                   # Domain models (e.g., DTOs, business objects)
│   └── User.cs
│
├── Properties/               # Auto-generated or project metadata files
│   └── launchSettings.json
│
├── Program.cs                # Entry point: minimal API + routing + DI
│
├── appsettings.json          # Default config
├── appsettings.Development.json # Dev overrides
│
├── IntegrApi.http            # Pre-made HTTP requests (for VSCode, etc.)
│
├── IntegrApi.sln              # Solution file
│
├── .gitignore                # Git ignore rules
|
└── README.md                 # Project documentation
```

### Configuration

- `appsettings.json`: holds the configuration for the application (ports, logging, etc.).

- `appsettings.Development.json`: overrides for development environment.

You can easily extend this to support secret storage, connection strings, or feature flags.

### Testing & Requests

While this project does not include automated tests yet, you can:

1. Use the IntegrApi.http file to send HTTP requests directly from VS Code (using the REST Client extension).
2. Use tools like Postman or curl for manual testing.

Here’s a sample curl request to get all entities (change localhost:5000 to your running port):

```bash
curl -X GET http://localhost:5000/entities
```

### Contributing

Contributions are very welcome! Here are a few ways you could help:

- Add unit / integration tests
- Implement middleware (e.g., logging, validation, authentication)
- Provide error handling / validation
- Add OpenAPI / Swagger integration
- Improve documentation or expand the .http file with more example requests

Feel free to open issues or pull requests — I appreciate your help!

### Contact

- GitHub: [dannylbr](https://github.com/dannylbr)
- Email: integraesol@gmail.com
- LinkedIn: [Daniel Soares](https://www.linkedin.com/in/daniel-soares-82b71189/)

Thank you for checking out IntegrApi! 

If you're a recruiter or hiring manager, this repo demonstrates:

- My familiarity with modern .NET minimal APIs
- Clean project structure and best practices
- A mindset for building scalable, maintainable code