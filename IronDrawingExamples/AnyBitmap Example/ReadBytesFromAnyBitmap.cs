/**
<h1> Read bytes from AnyBitmap</h1>

<p>Users have the option of manipulating AnyBitmap file in terms of bytes. IronDrawing have methods to **Get**, **Export**, and **Read** bytes of AnyBitmap file. </p>

<p>The image file to be read can be loaded using file path <code>AnyBitmap.FromFile(@"FILE_PATH")</code> and stored in an AnyBitmap variable. The variable can then be manipulated to get bytes using <code>.GetBytes()</code> method, export bytes with option to change the image format and degree of image loss using <code>.ExportBytes(AnyBitmap.ImageFormat.Format, 10)</code> method and read all bytes of the file using <code>File.ReadAllBytes(@"FILE_PATH")</code> method.</p>
**/

using IronSoftware.Drawing;

// Get, export, and read bytes
AnyBitmap bitmap = AnyBitmap.FromFile(@"FILE_PATH");
byte[] bit = bitmap.GetBytes(); // Get
byte[] export = bitmap.ExportBytes(AnyBitmap.ImageFormat.Tiff, 10);  // Export
byte[] bat = File.ReadAllBytes("file_path"); // Read
