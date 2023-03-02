# Build

## Windows
Change the two paths in Program.cs to something sensible like C:\tmp for the temporary image.
Open the solution file in Visual Studio and build.

## Linux
Change the two paths to the location of the temporary image.

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
