using IronSoftware.Drawing;
using System;


AnyBitmap sample = AnyBitmap.FromFile("FILE_PATH");
var colorDepth = sample.BitsPerPixel; 
Console.WriteLine(colorDepth); //get color depth in terms of bits per pixel