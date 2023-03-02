﻿using BarcodeLib;
using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace BarcodeGenerator
{
    class Program
    {
        //set a temporary image path
        public static string tmpPath = @"/path/to/barcode.png";

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
            barcodeImage.Save(Path.GetFileName(tmpPath), ImageFormat.Png);

            //open image
            OpenFile();
        }
        //function to open image
        public static void OpenFile()
        {
            ProcessStartInfo process = new ProcessStartInfo(Path.GetFileName(tmpPath));
            process.UseShellExecute = true;

            //Process cmd = Process.Start(process);
            //cmd.WaitForExit();
            Process.Start(process);
        }
    }
}
