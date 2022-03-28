# Pierre's Sugary and Sweet Treats

#### By _**Ryan Bass** (/probablynotryan)_ 

#### _Epicodus Independent Project Week 12: Another MVC website demonstrating familiarity with using authorization/authentation and SQL databases (many-to-many)._

## Technologies Used

* C#
* HTML
* Javascript
* CSS
* Bootstrap
* ASP .NET Core
* MySql
* Entity / Linq / Razor

## Description

This MVC site will allow a user to register a email address with an preferred password, and then allow that user to add Flavors/Sweets to a many-to-many database that anonymous views can view on the splash page!

## Setup/Installation Requirements

* Download or clone this repository to your computer.
* Install [.NET 5](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net) if it is not installed already.
* In order to properly run the database, [install MySQL](https://dev.mysql.com/downloads/mysql/).
* In your terminal, type in ```dotnet tool install --global dotnet-ef``` to install dotnet ef.
* Navigate to the project folder of this downloaded repository and enter ```touch appsettings.json```. You can then edit that created file with a code editor of your choice and enter this on in it, followed by saving the file. (Be sure to replace PASSWORD with the password you provided during installation).: 
  ```csharp
  {
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=ryan_bass;uid=root;pwd=PASSWORD;"
    }
  } 
  ```
* (Guess what: we're still using terminal from inside PSST/) Enter ```dotnet build```
* After a successful build, run the project by entering ```dotnet ef database update``` (you guessed it: in terminal). This will create the database we use throughout this project, so make sure MySQL is running.
* Once that's successfully built, enter ```dotnet run`` to start the mvc site.
* You should get a _Now listening on:_ line with the path of where its running. (ie: http://localhost.5000) Hold command and click it to open it up with your default browser.
* On the bottom of the page, create a user by clicking "Log in" and then "Register". Enter whatever email/password you'd like to use, and then log in. After a successful login, new buttons should appear at the bottom of the splash page. Go wild!

## Known Bugs

* No reported bugs (yet)

## License

MIT
Copyright (c) _2022_ _Ryan Bass_