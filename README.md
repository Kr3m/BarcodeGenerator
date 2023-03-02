# BarcodeGenerator

## Build

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
./BarcodeGenerator (or .\BarcodeGenerator.exe on Windows)
Enter a UPC code and have a barcode generated for you in image format.
