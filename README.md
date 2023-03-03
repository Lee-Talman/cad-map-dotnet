# cad-map-dotnet
A tool to capture Block entity data from DWG files using the AutoCAD .NET API.

# Installation
Using the NETLOAD command, import the `cad-map-dotnet.dll` from cad-map-dotnet/bin. You'll need a SQL database formatted appropriately to store the information (see below).

## Setting up the SQL Database
Download [SQL Server Express](https://www.microsoft.com/en-us/Download/details.aspx?id=101064) and follow the instructions to set it up using your computer's name as the local host. You can find your computer name on Windows by searching for "System Information" and then looking at "System Name". Then, create a database with default settings and the name `CADDB` to create a database, as well as the remaining `CreateTable_*.sql` to generate the remaining tables inside the database.

## Build and use CAD-MAP in AutoCAD
1. Install the software requirements found at this page: 
[My First AutoCAD Plug-In Overview](https://knowledge.autodesk.com/support/autocad/learn-explore/caas/simplecontent/content/my-first-autocad-plug-overview.html). Specifically, you'll need Visual Studio 2019 **not 2022**. Make sure to scroll all the way to the bottom of the page to find the AutoCAD and ObjectARX .NET wizards.

2. After installing the ObjectARX SDK, and the ObjectARX/.NET wizards, import the following References (Project -> Add Reference...) into Visual Studio: `accoremgd.dll`, `acdbmgd.dll`, and `acmgd.dll` and set their "Copy Local" status to `False`. On a default C drive-based Windows installation, you'll find these in `C:\Autodesk\ObjectARX_for_AutoCAD_2023_Win_64bit_dlm\inc`. 

3. Change the `connstr` value in `Settings1.settings` to point at the path of your database. If you're using a non-trusted connection, or any other type of connection, reference the [SQL server connection string types at this link](https://www.connectionstrings.com/sql-server/).

4. Finally, build the project by running it using the Start command. You'll find the compiled .dll in `cad-map-dotnet\bin\debug` as `cad-map-dotnet.dll`. Load this in AutoCAD using the `NETLOAD` command, then run CAD-MAP by running the `CADMAP` command.
