using IronSoftware.Drawing;

//Instantiate CropRectangle with default value unit of pixels
CropRectangle pxCropRect = new CropRectangle(15, 25, 150, 175); //(X, Y, Width, Height) 

//Convert and print CropRectangle measurement in milimeter
CropRectangle mmCropRect = pxCropRect.ConvertTo(MeasurementUnits.Millimeters, 20);
Console.WriteLine(mmCropRect.X); 
