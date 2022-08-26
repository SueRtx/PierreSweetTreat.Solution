# Pierre's Sweet and Savory Treats (C# Project 5)

#### By Sue Roberts

####   

## Technologies Used

* C#
* .NET 5.0
* SQL Workbench
* Entity Framework
* ASP.NET
* REPL
* CSS
* Bootstrap
* HTML

## Description



## Setup/Installation Requirements

* Clone repository: $ git clone https://github.com/SueRtx/  
* Open Vs Code: $ code .   
* Open TERMINAL in Vs Code
* Go to SavorySweets directory: $ cd SavorySweets
* Create file at root directory: $ touch "appsettings.json"
* Add following code to "appsettings.json" (Add your own password)
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=sun_roberts;uid=root;pwd=[YOUR-PASSWORD];"
  }
}

``` 
* Download MySQL WorkBench  
* Go to terminal  → $ dotnet restore → $ dotnet build → dotnet ef database update
* Run Program: $ dotnet run  
* Open web browser: http://localhost:5000/  

## Known Bugs

* none

## License

MIT

Copyright (c) 2022 Sue Roberts