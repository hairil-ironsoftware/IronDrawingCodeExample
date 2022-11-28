using IronSoftware.Drawing;
using System;

AnyBitmap bitmap = AnyBitmap.FromFile(@"FILE_PATH");
byte[] bit = bitmap.GetBytes(); //get bytes from AnyBitmap file
byte[] export = bitmap.ExportBytes(AnyBitmap.ImageFormat.Tiff, 10);  //export bytes to other Image format
byte[] bat = File.ReadAllBytes("file_path"); //read bytes from file path























