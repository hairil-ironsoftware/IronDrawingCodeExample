using IronSoftware.Drawing;

AnyBitmap bitmap;

// Generate AnyBitmap using filepath
bitmap = AnyBitmap.FromFile(@"FILE_PATH");
bitmap.SaveAs("output.bmp");


// Generate AnyBitmap from bytes
byte[] bytes = File.ReadAllBytes(@"FILE_PATH");
bitmap = AnyBitmap.FromBytes(bytes);
bitmap.SaveAs("result.bmp"); 

// Generate AnyBitmap from memory stream
byte[] bytes = File.ReadAllBytes(@"FILE_PATH");
MemoryStream ms = new MemoryStream(bytes);
bitmap = AnyBitmap.FromStream(ms);
bitmap.SaveAs("output.bmp");  

// Generate AnyBitmap from Uri
Uri uri = new Uri("URI_PATH");
bitmap = AnyBitmap.FromUri(uri);
bitmap.SaveAs("uriImage.bmp"); 

// Generate AnyBitmap file from SVG file
bitmap = AnyBitmap.FromFile(@"FILE_PATH");
bitmap.SaveAs("result.jpg"); 
