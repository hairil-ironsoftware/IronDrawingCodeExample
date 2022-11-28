using IronSoftware.Drawing;
using System;


CropRectangle pxCropRect = new CropRectangle(15, 25, 150, 175); //default unit is pixels
CropRectangle mmCropRect = pxCropRect.ConvertTo(MeasurementUnits.Millimeters, 20);
Console.WriteLine(mmCropRect.X); //Convert measurement unit of a CropRectangle