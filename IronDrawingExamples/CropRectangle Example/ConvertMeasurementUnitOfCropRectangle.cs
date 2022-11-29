using IronSoftware.Drawing;

//Instantiate CropRectangle with default value unit of pixels
CropRectangle pxCropRect = new CropRectangle(X: 15, Y: 25, Width: 150, Height: 175); 

//Convert and print CropRectangle measurement in milimeter
CropRectangle mmCropRect = pxCropRect.ConvertTo(MeasurementUnits.Millimeters, 20);
Console.WriteLine(mmCropRect.X); //Convert measurement unit of a CropRectangle
