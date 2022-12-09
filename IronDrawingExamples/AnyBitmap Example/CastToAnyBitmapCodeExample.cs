/**
<h1> Cast to AnyBitmap</h1>

<p>In order to use and manipulate any image file in IronDrawing, all files must be converted to AnyBitmap file, and for files from other platforms, IronDrawing are able to cast the files to AnyBitmap files. Following are examples of image files from other platforms that can be cast to AnyBitmap file</p>

<h2> System.Drawing.Bitmap</h2>

<p>Bitmap from System Drawing can be casted to AnyBitmap files  by loading a System Drawing file from file path using <code>System.Drawing.Bitmap(@"FILE_PATH")</code> then cast the file by assigning it to a variable initialized with AnyBitmap type.</p>

<h2> System.Drawing.Image</h2>

<p>Casting images from System Image can be done by loading the file from a file path using <code>System.Drawing.Image.FromFile(@"FILE_PATH")</code> and store it in a variable with AnyBitmap type.</p>

<h2> SkiaSharp.SKBitmap</h2>

<p>Casting bitmap from SkiaSharp can be done by initializing a <code>SkiaSharp.SKBitmap</code> variable and store the file loaded from a file path using <code>SkiaSharp.SKBitmap.Decode(@"FILE_PATH")</code>. The file can then be cast to AnyBitmap type by storing it in a variable with AnyBitmap type.</p>

<h2> SkiaSharp.SKImage</h2>

<p>To load SkiaSharp image load the file using <code>SkiaSharp.SKImage.FromBitmap(SkiaSharp.SKBitmap.Decode(@"FILE_PATH")</code> and store inside a SkiaSharp.SKImage variable. It can then be cast to AnyBitmap file by assigning it to a variable of AnyBitmap type.</p>

<h2> SixLabors</h2>

<p>Images from SixLabors can be loaded from file path using the code <code>SixLabors.ImageSharp.Image.Load<SixLabors.ImageSharp.PixelFormats.Rgba32>(@"FILE_PATH")</code> and store it in <code>SixLabors.ImageSharp.Image<SixLabors.ImageSharp.PixelFormats.Rgba32></code> variable. It can then be casted into AnyBitmap file by assigning it to an AnyBitmap variable.</p>

<h2> Maui Image</h2>

<p>Casting of Maui image to AnyBitmap file can only be done in **environments other than NET4.7.2**. Maui image file can be loaded by read the bytes of the image obtained from a file path using <code>File.ReadAllBytes(@"FILE_PATH")</code> and store the bytes in an array <code>byte[]</code>. The bytes must be translated into image by using <code>Microsoft.Maui.Graphics.Platform.PlatformImage.FromStream(new MemoryStream(byte[]))</code> and can then be casted to AnyBitmap file by assigning it to a variable of AnyBitmap type.</p>

**/


using IronSoftware.Drawing;
using SixLabors.ImageSharp;
using SkiaSharp;

// We create an AnyBitmap object. We will then cast other popular types to Anybitmap.
AnyBitmap anyBitmap;

// Cast System.Drawing bitmap to AnyBitmap
System.Drawing.Bitmap bitmapFromBitmap = new System.Drawing.Bitmap(@"FILE_PATH");
anyBitmap = bitmapFromBitmap;

// Cast System image to AnyBitmap
System.Drawing.Image bitmapFromFile = System.Drawing.Image.FromFile(@"FILE_PATH");
anyBitmap = bitmapFromFile;

// Cast SKBitmap to AnyBitmap
SkiaSharp.SKBitmap skiaBitmap = SkiaSharp.SKBitmap.Decode(@"FILE_PATH");
anyBitmap = skiaBitmap;

// Cast SKimage to AnyBitmap
SkiaSharp.SKImage skiaImage = SkiaSharp.SKImage.FromBitmap(SkiaSharp.SKBitmap.Decode(@"FILE_PATH"));
anyBitmap = skiaImage;

// Cast SixLabors Image to AnyBitmap
SixLabors.ImageSharp.Image<SixLabors.ImageSharp.PixelFormats.Rgba32> imgSharp = SixLabors.ImageSharp.Image.Load<SixLabors.ImageSharp.PixelFormats.Rgba32>(@"FILE_PATH");
anyBitmap = imgSharp;

// Cast Maui image to AnyBitmap (not for NET 4.7.2)
byte[] imageAsBytes = File.ReadAllBytes(@"FILE_PATH");
var mauiPlatformImage = Microsoft.Maui.Graphics.Platform.PlatformImage.FromStream(new MemoryStream(imageAsBytes));
anyBitmap = mauiPlatformImage;
