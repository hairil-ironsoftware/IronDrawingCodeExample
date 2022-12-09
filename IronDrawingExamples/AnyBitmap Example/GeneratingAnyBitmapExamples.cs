/**
<h1> Generate AnyBitmap</h1>

<p>In order for users to use IronDrawing tool to open, read, and manipulate image files, AnyBitmap type files must first be generated. There are a number of methods to load image files and generate AnyBitmap files. </p>

<h2> File path</h2>

<p>Image files can be loaded from local machine by using <code>AnyBitmap.FromFile(@"FILE_PATH")</code> method and store it into an AnyBitmap variable to generate an AnyBitmap file. </p>

<h2> Memory stream</h2>

<p>AnyBitmap file can also be generated from memory stream. The bytes of an image will be read and stored in byte arrays using <code>File.ReadAllBytes(@"FILE_PATH")</code> method. AnyBitmap file will then be generated from the bytes and stored in AnyBitmap variable using <code>AnyBitmap.FromBytes(byte[])</code> method.</p>

<h2> SVG file</h2>

<p>AnyBitmap can also be generated from SVG file using the file path similar to generating AnyBitmap from file path. However, to load an SVG file to the program, additional dependencies such as SkiaSharp and SkiaSharp.Svg must be added.</p>

<h2> Uniform Resource Identifier (URI)</h2>

<p>IronDrawing also can generate AnyBitmap directly from URI. Users need to initiate and store the URI path into a URI type variable <code>Uri uri = new Uri("URI_PATH");</code> and generate AnyBitmap file by storing the Uri variable to AnyBitmap type variable using <code>AnyBitmap.FromUri(uri)</code> method.</p>

**/

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
bitmap = AnyBitmap.FromFile(@"FILE_PATH.svg");
bitmap.SaveAs("result.jpg"); 
