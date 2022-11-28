using IronSoftware.Drawing;
using System;

AnyBitmap bitmap = new AnyBitmap(@"FILE_PATH");
bitmap.ExportFile("losslogo.png", AnyBitmap.ImageFormat.Png, 100); //Export AnyBitmap file to other format with ability to control loss