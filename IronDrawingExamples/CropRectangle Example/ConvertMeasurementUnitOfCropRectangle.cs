using IronSoftware.Drawing;

// Instantiate a CropRectangle (Default measurement unit is pixels)
CropRectangle pxCropRect = new CropRectangle(15, 25, 150, 175); // (X, Y, Width, Height) 

// Convert and print a CropRectangle measurement in millimeters
CropRectangle mmCropRect = pxCropRect.ConvertTo(MeasurementUnits.Millimeters, 20);
Console.WriteLine(mmCropRect.X); 