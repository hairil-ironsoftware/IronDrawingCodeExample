using IronSoftware.Drawing;
using System;


//Export AnyBitmap files to other format with ability to control loss
AnyBitmap bitmap = new AnyBitmap(@"FILE_PATH");
bitmap.ExportFile("losslogo.png", AnyBitmap.ImageFormat.Png, 100); 
