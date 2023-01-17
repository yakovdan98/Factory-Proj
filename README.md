# Factory

#### Daniel Yakovlev

An application to track the engineers and machines in a factory

## Technologies Used

* C#
* .Net 6
* ASP.Net EF Core 6
* SQL
* LINQ

### Objectives 

The goal for this project was to create a fully functional CRUD MVC web application that utilizes a many-to-many MySQL database. EF Core was used for communication with the database.

## Setup/Installation Requirements

#### To run this project, you will need:
* .NET 6.0
[https://dotnet.microsoft.com/en-us/download](https://dotnet.microsoft.com/en-us/download)

* .NET Core CLI
```
dotnet tool install --global dotnet-ef --version 6.0.0
```

1. Clone this repo to your workspace.

2. Navigate to the `Factory` directory.

3. Create a file named `appsettings.json` with the following code. Be sure to update the Default Connection to your MySQL credentials.
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=factory;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];",
  }
}
```

4. Install dependencies within the `Factory` directory
```
$ dotnet restore
````
5. update the database
```
$ dotnet ef database update
````
6. Build and run the program 
 ```
 $ dotnet run
 ```

## Known Bugs

* No known bugs.


## License

**MIT License**

Copyright (c) 2023 Daniel Yakovlev

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
