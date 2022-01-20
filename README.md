# consoleAppNet6

For testing purpose i created simple .Net 6 console app that uses Entity Framework.
Tested in VSC.

## Setup
Localy create folder for project.
<br>
Inside VSC open terminal inside created folder.
<br>
run `dotnet new console` // this creates new project
<br>
add entity framework for mssql running command `dotnet add package Microsoft.EntityFrameworkCore.SqlServer`
<br>
run `dotnet add package Microsoft.EntityFrameworkCore.Design` so that migration commands will work
<br>

pull image for MSSQL for docker: `docker pull mcr.microsoft.com/mssql/server:2017-latest`
<br>
run dockerimage of MSSQL: `docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=AdM!n123" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2017-latest`
