# Sweet and Savory Treats

#### MVC web application with user authentication and a many-to-many SQL relationships. 

#### By Roman Kolivashko

## Technologies Used:
* C#
* .Net v5
* Entity Framework Core
* Identity Framework
* Migrations
* Razor
* MySQL 
* HTML
* CSS3


## User Stories

* The application should have user authentication. A user should be able to log in and log out. Only logged in users should have create, update and delete functionality. All users should be able to have read functionality.

* There should be a many-to-many relationship between Treats and Flavors. A treat can have many flavors (such as sweet, savory, spicy, or creamy) and a flavor can have many treats. For instance, the "sweet" flavor could include chocolate croissants, cheesecake, and so on.

* A user should be able to navigate to a splash page that lists all treats and flavors. Users should be able to click on an individual treat or flavor to see all the treats/flavors that belong to it.

## Setup/Installation Requirements

* Download and install .NET Core
* Download and install MySQL Workbench
* _Clone this repository_ `git clone https://github.com/romankolivashko/SweetandSavory.git`
* _Navigate to `/SweetAndSavory.Solution/SweetAndSavory` directory_
* _Run `dotnet restore` command to download required dependencies_
* _Run `dotnet run` command to launch the application in a console_
* Upon successful MySQL installation, proceed importing data:
  1. In Workbench: Select `Administration` Tab --> Under `Management` Tab 
  2. Select `Data Import/Restore` option
  3. In the pane to the right, select `Import from Self-Contained File` and navigate to this project's root directory
  4. Select `roman_kolivashko.sql` from project's root directory
  5. Next to `Default Target Schema` option select `New`, give the name of your liking
  6. Click `Start Import` button
  7. Create `appsettings.json` file in `/Factory.Solution/Factory` directory, make sure to append following to that file:
  ```
  {
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=<schema_name>;uid=<user>;pwd=<password>;"
   }
  }
  ```
  Note: replace *"schema_name"* with the name of file from step 5, *"user"* and *"password"* will be your local MySQL env variables.


## Known Bugs

* Refer to [the GitHub issues page](https://github.com/romankolivashko/SweetandSavory/issues) to see existing bugs or report new ones. 

## License

MIT
## Contact Information

rkolivashko@gmail.com
