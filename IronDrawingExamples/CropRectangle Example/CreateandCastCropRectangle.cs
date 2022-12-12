/**
<h1> Create and Cast CropRectangle</h1>

<p>CropRectangle is one of a very useful features provided by IronDrawing which can be used for users to crop any image file. For customer who are using rectangles from System.Drawing.Rectangle can also cast it to IronSoftware.Drawing.CropRectangle using Cast method.</p>

<h2> Create CropRectangle</h2>

<p>To create CropRectangle, user can instantiate a new CropRectangle and provide the X and Y coordinate, as well as the width and height measurement of the CropRectangle in pixels as is <code>CropRectangle(10, 10, 50, 50)</code> </p>

<h2> Cast CropRectangle</h2>

<p>To cast an IronSoftware.Drawing.CropRectangle from System.Drawing.Rectangle, simply assign an instantiated System.Drawing.Rectangle to a variable of type <code>IronSoftware.Drawing.CropRectangle</code>. </p>

**/

using IronSoftware.Drawing;

// Create a new CropRectangle object
CropRectangle cropRectangle = new CropRectangle(5, 5, 50, 50); // (X, Y, Width, Height) in pixels

// Cast between System.Drawing.Rectangle and IronSoftware.Drawing.CropRectangle
System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(10, 10, 150, 150);
IronSoftware.Drawing.CropRectangle ironRectangle = rectangle;

// Access CropRectangle properties:
ironRectangle.X;
ironRectangle.Y;
ironRectangle.Width;
ironRectangle.Height;
