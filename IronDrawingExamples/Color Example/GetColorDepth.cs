using IronSoftware.Drawing;

//Load AnyBitmap sample via filepath
AnyBitmap sample = AnyBitmap.FromFile("FILE_PATH");

//Gets and print color dpeth in terms of bits per pixel
var colorDepth = sample.BitsPerPixel; 
Console.WriteLine(colorDepth); 
