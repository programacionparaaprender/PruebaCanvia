

dotnet new webapi -o PruebaCanvia -f netcoreapp3.1
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet new sln
dotnet add sln .\PruebaCanvia\PruebaCanvia.csproj
dotnet add reference .\PruebaCanvia\PruebaCanvia.csproj



Install-Package Microsoft.EntityFrameworkCore -Version 3.1.7
Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 3.1.7
Install-Package Microsoft.EntityFrameworkCore.Tools -Version 3.1.7

Microsoft.EntityFrameworkCore.Design

PM> add-migration AddBookModel

update-database

por agregar parametro de required a name
add-migration addNoticiasPorAutor

update-database