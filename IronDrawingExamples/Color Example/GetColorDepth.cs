/**
<h1> Get Color Depth</h1>

<p>Color depth is measured in bits per pixel or bpp, used to give information on the color components, in terms of either bits used to indicate the color of a single pixel or number of bits used for each color component of a single pixel. It can also used to determine the quality of an image at some point as different image bpp results in different outcome quality of image (higher bpp, more image definition).</p>

<p>An image file to be read can be loaded from a file path <code>AnyBitmap.FromFile(@"FILE_PATH")</code>. <code>.BitsPerPixel</code> can then be used on the generated AnyBitmap to get the color depth.</p>

**/

using IronSoftware.Drawing;

// Load an AnyBitmap from a file
AnyBitmap sample = AnyBitmap.FromFile(@"FILE_PATH");

// Gets and prints the color depth in terms of bits per pixel
var colorDepth = sample.BitsPerPixel; 
Console.WriteLine(colorDepth); 
