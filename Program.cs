using BarcodeLib;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace BarcodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter UPC#");
            string NumericString = Console.ReadLine();
            //220 x 130
            //create instance of API
            Barcode barcodLib = new Barcode();

            int imageWidth = 220;
            int imageHeight = 130;
            Color foreColor = Color.Black;
            Color backColor = Color.White;

            //string NumericString = "883929390625";

            //type UPCA
            Image barcodeImage = barcodLib.Encode(TYPE.UPCA, NumericString, foreColor, backColor, imageWidth, imageHeight);

            //store image in path with chosen format
            barcodeImage.Save(@"path/to/temp/image/Barcode.png", ImageFormat.Png);

            //open image
            OpenFile();
        }
        //function to open image
        public static void OpenFile()
        {
            ProcessStartInfo process = new ProcessStartInfo(@"path/to/temp/image/Barcode.png");
            process.UseShellExecute = true;

            //Process cmd = Process.Start(process);
            //cmd.WaitForExit();
            Process.Start(process);
        }
    }
}
