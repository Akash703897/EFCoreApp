EF Core Student Management App
A simple CRUD application built using ASP.NET Core and Entity Framework Core to manage student data.

EFCoreApp/
│
├── Models/
│   └── Student.cs
│
├── Data/
│   └── AppDbContext.cs
│
├── Services/
│   └── StudentService.cs
│
├── Controllers/
│   └── StudentController.cs
│
├── Migrations/
│   └── (Generated EF Core migration files)
│
├── Program.cs
├── Startup.cs (if applicable)
├── EFCoreApp.csproj
└── README.md
Setup Instructions
Install EF Core Packages
Open terminal and run:


dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Pomelo.EntityFrameworkCore.MySql
Add Your MySQL Connection String
In appsettings.json:


"ConnectionStrings": {
  "DefaultConnection": "server=localhost;database=StudentDB;user=root;password=Akash@123"
}

Create Initial Migration


dotnet ef migrations add InitialCreate
Update the Database


dotnet ef database update
🚀 Features
Add, View, Update, Delete students.

RESTful API architecture.

Uses Dependency Injection with Services.

🔧 Technologies Used
ASP.NET Core

Entity Framework Core

MySQL (via Pomelo provider)

Visual Studio Code / Visual Studio


# Create a new model
echo > Models/Student.cs

# Create DbContext
echo > Data/AppDbContext.cs

# Create Student Service
echo > Services/StudentService.cs

# Create controller
echo > Controllers/StudentController.cs

# Run Migration
dotnet ef migrations add InitialCreate

# Apply Migration to Database
dotnet ef database update
