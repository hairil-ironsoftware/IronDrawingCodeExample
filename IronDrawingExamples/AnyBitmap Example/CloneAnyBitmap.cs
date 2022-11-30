using IronSoftware.Drawing;

// Clone AnyBitmap
AnyBitmap clonedframe = AnyBitmap.FromFile(@"FILE_PATH").Clone();
clonedframe.SaveAs("frameClone.jpg"); 

//Clone frames of any image with a specified crop area
AnyBitmap clonedWithCrop = AnyBitmap.FromFile(@"FILE_PATH").Clone(new CropRectangle(0, 0, 150, 150));
clonedWithCrop.SaveAs("cropCloned.jpg"); 
