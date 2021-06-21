# _Animal Shelter API_

#### By _Ahmed Ghouzlane_

## Technologies Used

- _C#_ #️⃣
- _.NET Core 5.0_
- _Entity Framework_
- _Git_
- _VSCode_
- _MySQL_
- _Workbench_
- _Postman_

## Description 📜

A Web API that provides CRUD functionality and swagger documentations. Animal Shelter API is connected to a MySql Database.

## Setup/Installation Requirements 🏗

1. Clone the repository: `$ git clone https://github.com/aGhouzlane/AnimalShelter.Solution`
2. Navigate to the `AnimalShelter.Solution/` directory on your computer
3. Open with your preferred text editor to view the code base
4. Naviate to the `AnimalShelter/` directory on your computer
5. Run command `dotnet restore` 
6. Run command `dotnet build` 
7. Add `appsettings.json` file to the root directory
8. Update `ConnectionStrings` to reflect the name of database and password
   ```
   {
      "Logging": {
        "LogLevel": {
          "Default": "Information",
          "Microsoft": "Warning",
          "Microsoft.Hosting.Lifetime": "Information"
        }
      },
      "AllowedHosts": "*",
      "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=database_name;uid=root;pwd=yourpassword;"
      }
    }
    ```
7. To run the project, rum command `dotnet run`
8. To start a development server and view the project in the browser, type in browser URL: localhost:5000
9. To navigate to Swagger documentation, type in browser URL: localhost:5000/Swagger

## EndPoints

1. `GET: api/animals` returns all animals in the database 
2. `GET: api/Animals/{id}` returns an animal with the given id
3. `POST: api/Animals` adds a new animal in the database
4. `PUT: api/Animals/{id}` updates an animal with the given id
5. `DELETE: api/Animals/{id}` deletes an animal with the given id

## License ⚖

_MIT © Ahmed Ghouzlane 2021_

## Contact Information 🤳

_Ahmed ahmedghouzlane@gmail.com_
