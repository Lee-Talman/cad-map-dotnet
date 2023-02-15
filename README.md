# cad-map-dotnet
A tool to capture Block entity data from DWG files using the AutoCAD .NET API.

# Installation
Using the NETLOAD command, import the `cad-map-dotnet.dll` from cad-map-dotnet/bin. You'll need a SQL database formatted appropriately to store the information - either generate one yourself from reading the SQL write-out commands in the DBLoadUtil.cs class (I would be very impressed if you could do this) or load it from `SQLManager_CADDB.sql`.

# Contribute
More is coming here shortly, but for now you'll want to 
familizarize yourself with the [ObjectARX Managed .NET Developer's Guide](https://help.autodesk.com/view/OARX/2023/ENU/?guid=GUID-C3F3C736-40CF-44A0-9210-55F6A939B6F2) and install the software requirements found at this page: 
[My First AutoCAD Plug-In Overview](https://knowledge.autodesk.com/support/autocad/learn-explore/caas/simplecontent/content/my-first-autocad-plug-overview.html).
