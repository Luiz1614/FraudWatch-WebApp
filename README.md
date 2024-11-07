# Odontoprev Register

Odontoprev Register is a web application built with .NET 8 that helps manage and monitor dentists' and analysts' information. The application provides functionalities to create, read, update, and delete records for both dentists and analysts.

## Features

- List all dentists and analysts
- View details of a specific dentist or analyst
- Edit dentist or analyst information
- Delete a dentist or analyst record
- Add a new dentist or analyst

## Technologies Used

- .NET 8
- ASP.NET Core MVC
- Entity Framework Core
- Razor Pages
- Bootstrap (for styling)

## Getting Started

### Prerequisites

- .NET 8 SDK
- Visual Studio 2022 or later

### Installation

1. Clone the repository:
    
  git clone https://github.com/yourusername/Odontoprev-Register.git

2. Navigate to the project directory:

  cd Odontoprev-Register

3. Restore the dependencies:
    
  dotnet restore

### Configuration

1. Open the `appsettings.json` file located in the `FraudWatch-WebApp` project.
2. Update the connection string to point to your database:

"ConnectionStrings": {
    "DefaultConnection": "Server=your_server;Database=your_database;User Id=your_user;Password=your_password;"
}

### Running the Application

1. Open the solution in Visual Studio.
2. Build the solution to ensure all dependencies are correctly installed.
3. Run the application using IIS Express or your preferred web server.
