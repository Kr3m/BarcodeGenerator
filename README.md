# BarcodeGenerator

## Build

### Prerequisite Step

```
dotnet restore
```

### Windows
Change the path in Program.cs to something sensible like C:\tmp\barcode.png for the temporary image.
Open the solution file in Visual Studio and build.

### Linux
Change the path to the location of the temporary image.

```
dotnet build
```
 or
 
```
dotnet build --configuration Release
```

## BarcodeGenerator Usage
./bcgen (or .\bcgen.exe on Windows)
Enter a UPC code and have a barcode generated for you in image format.
