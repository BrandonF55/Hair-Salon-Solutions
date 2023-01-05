Hair Salon
By Brandon James Fenk
Eau Calvin's HairSalon Shop Website
Technologies Used
C#
.NET
HTML
CSS
MySQL
Entity
Description
Website designed with the employees in mind to track current and past stylists, and clients. More specifically, what clients were under a specific stylist, stylist hiring date, client normal haircut, times visited, last visit, and name.

Setup/Installation Requirements
Open up your terminal and navigate to the desired landing folder
In terminal enter, ' "git clone https://github.com/BrandonF55/Hair-Salon-Solutions.git'
In terminal enter 'code .' to open files in Visual Studio Code
In VS Code terminal navigate to the HairSalon directory 
Configure files with '$ dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0' & '$ dotnet add '
Run '$ dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 6.0.0' to install
Run '$ dotnet restore'
Create file names 'appsettings.json'
Enter the following into the file
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=Brandon_Fenk;uid=root;pwd=YOUR_PASSWORD;"
  }
}
To setup the database you open up MySQL and under 'Administration' select 'Data Import'
Check the 'Import from self contained file' option and enter the file path of the Database within HairSalon, then start Import
Enter '$ dotnet run to start program'
Known Bugs
License
MIT

Copyright (c) 2022 Brandon James Fenk.