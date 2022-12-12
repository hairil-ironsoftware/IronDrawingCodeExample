/**
<h1> Convert Measurement Unit of Crop Rectangle</h1>

<p>IronDrawing provides option for users who wants to change the measurement unit used in CropRectangle from pixels (px) to milimeters (mm) or vice versa. Default measurement unit used in CropRectangle is pixels (px). </p>

<p>After a new CropRectangle with measurements specified has been instantiated, call the conversion method to the CropRectangle. For example <code>.ConvertTo(MeasurementUnits.Millimeters, 20)</code>. This will convert the measurement sof the CropRectangle to millimeters based on the DPI set by users.</p>

**/

using IronSoftware.Drawing;

// Instantiate a CropRectangle (Default measurement unit is pixels)
CropRectangle pxCropRect = new CropRectangle(15, 25, 150, 175); // (X, Y, Width, Height) 

// Convert and print a CropRectangle measurement in millimeters
CropRectangle mmCropRect = pxCropRect.ConvertTo(MeasurementUnits.Millimeters, 20);
Console.WriteLine(mmCropRect.X); 
