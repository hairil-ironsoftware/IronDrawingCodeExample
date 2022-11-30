using IronSoftware.Drawing;

// Get, export, and read bytes
AnyBitmap bitmap = AnyBitmap.FromFile(@"FILE_PATH");
byte[] bit = bitmap.GetBytes(); //get 
byte[] export = bitmap.ExportBytes(AnyBitmap.ImageFormat.Tiff, 10);  //export
byte[] bat = File.ReadAllBytes("file_path"); //read
