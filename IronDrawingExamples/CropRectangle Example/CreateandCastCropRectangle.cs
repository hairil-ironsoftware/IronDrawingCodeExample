using IronSoftware.Drawing;

// Create a new CropRectangle object
CropRectangle cropRectangle = new CropRectangle(5, 5, 50, 50); //(X, Y, Width, Height)

// Casting between System.Drawing.Rectangle and IronSoftware.Drawing.CropRectangle
System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(10, 10, 150, 150);
IronSoftware.Drawing.CropRectangle ironRectangle = rectangle;

ironRectangle.X;
ironRectangle.Y;
ironRectangle.Width;
ironRectangle.Height;
