Hair Salon
By Brandon James Fenk
Technologies Used
C#
.NET 6
ASP.NET Core MVC
Entity
MySQL
HTML
CSS
Description
This application allows the user to track stylists and their clients for a hair salon using a MySQL database.

Setup/Installation Requirements
Open up your terminal and navigate to the desired landing folder

In terminal Run: git clone https://github.com/BrandonF55/Hair-Salon-Solutions.git

In terminal enter code . to open files in Visual Studio Code

In VS Code open a new terminal

In VS Code termainl run: dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0
In VS Code terminal run: dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0
Run: dotnet restore
_Import database dump with MySql WorkBench

Open MySql WorkBench
Select Server at top of window
Select Data Import
Select brandon_fenk.sql file in drowndown
Click Start Import
Create a new file called appsettings.json within the HairSalon directory

In VS Code terminal:
Run: cd HairSalon
Run: touch appsettings.json
Enter the following into the file:

    {
      "ConnectionStrings": {
          "DefaultConnection": "Server=localhost;Port=3306;database=brandon_fenk;uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
      }
  }
  
Make sure to set uid and pwd
Open MySQL and select Administration select Data Import
Check Import from self contained file option and enter file path of the HairSalon Database, then start import
Run: dotnet run in VS Code termainl to start the program
Known Bugs
No known bugs
License
MIT

Copyright (c) 2022 Brandon James Fenk_