/**
<h1> Clone AnyBitmap</h1>

<p>One feature that IronDrawing provide is Clone AnyBitmap. This feature enable users to make an exact copy of AnyBitmap file and save it without affecting the copied file. Users can also specify the area that they want to copy from a file by implementing CropRectangle feature inside and save the copy of the specified part of the file without modifying the original file.</p>

<p>To clone an AnyBitmap file, simply load an AnyBitmap file and use the <code>.Clone()</code> method on the file and save it. To implement CropRectangle feature, instantiate the CropRectangle method inside the clone method <code>.Clone(new CropRectangle(X, Y, Width, Height))</code>. All properties of CropRectangle are maeasured using pixels (px).</p>
**/

using IronSoftware.Drawing;

// Clone an AnyBitmap
AnyBitmap clonedframe = AnyBitmap.FromFile(@"FILE_PATH").Clone();
clonedframe.SaveAs("frameClone.jpg"); 

// Clone frames of any image with a specified crop area
AnyBitmap clonedWithCrop = AnyBitmap.FromFile(@"FILE_PATH").Clone(new CropRectangle(0, 0, 150, 150));
clonedWithCrop.SaveAs("cropCloned.jpg"); 
