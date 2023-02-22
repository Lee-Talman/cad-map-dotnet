# cad-map-dotnet
A tool to capture Block entity data from DWG files using the AutoCAD .NET API.

# Installation
Using the NETLOAD command, import the `cad-map-dotnet.dll` from cad-map-dotnet/bin. You'll need a SQL database formatted appropriately to store the information (see below).

## Setting up the SQL Database
Download [SQL Server Express](https://www.microsoft.com/en-us/Download/details.aspx?id=101064) and follow the instructions to set it up using your computer's name as the local host. You can find your computer name on Windows by searching for "System Information" and then looking at "System Name". Then, run the query `CreateDB_CADDB.sql` to create a database, as well as the remaining `CreateTable_*.sql` to generate the remaining tables inside the database.

# Contribute
More is coming here shortly, but for now you'll want to 
familizarize yourself with the [ObjectARX Managed .NET Developer's Guide](https://help.autodesk.com/view/OARX/2023/ENU/?guid=GUID-C3F3C736-40CF-44A0-9210-55F6A939B6F2) and install the software requirements found at this page: 
[My First AutoCAD Plug-In Overview](https://knowledge.autodesk.com/support/autocad/learn-explore/caas/simplecontent/content/my-first-autocad-plug-overview.html).
