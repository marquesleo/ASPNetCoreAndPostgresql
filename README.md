﻿# ASPNetCoreAndPostgresql
dotnet new WebAPI -n ArticleApp.API

Use -n to provide name to your API project. In my case it is ArticleApp.API..

run dotnet new -h

NuGet Package Manager

Press Ctrl + Shift + P and select Nuget Package Manager.

Enter Microsoft.EntityFrameworkCore and hit enter.

dotnet ef migrations add InitialCreate

dotnet ef database update

dotnet run

