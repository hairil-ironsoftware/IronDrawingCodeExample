# AnyBitmap

## Generating AnyBitmap ( [Code Example](https://ironsoftware.com/open-source/csharp/drawing/examples/anybitmap-example/) )
	- Generate AnyBitmap from multiple source such as: 
		- File path
		- Bytes
		- Memory stream
		- URI
		- SVG 
## Bitmap to Stream ( [Code Example](https://ironsoftware.com/open-source/csharp/drawing/examples/anybitmap-example/) )
	- Converting image files from file directory to a memory stream
	- Get stream of an AnyBitmap file

## Bitmap to String ( [Code Example](https://ironsoftware.com/open-source/csharp/drawing/examples/anybitmap-example/) )
	- Converting image file into string

## Casting to AnyBitmap ( [Code Example](https://ironsoftware.com/open-source/csharp/drawing/examples/anybitmap-example/) )
	- Files from other platforms can be casted to AnyBitmap. Platforms supported are as follows:
		-  System.Drawing.Bitmap 
		-  System.Drawing.Image
		-  SkiaSharp.SKBitmap
		-  SkiaSharp.SKImage
		-  SixLabors.ImageSharp
		-  Maui Image

## Export AnyBitmap ( [Code Example](https://ironsoftware.com/open-source/csharp/drawing/examples/anybitmap-example/) )
	- Export AnyBitmap to other file formats with ability to control loss. Image format supported: 
		* Bmp
		* Gif
		* Png
		* Jpeg
		* Tiff
		* Webp
		* Wbmp
		* Wmf
		* Icon

## Read bytes from AnyBitmap ( [Code Example](https://ironsoftware.com/open-source/csharp/drawing/examples/anybitmap-example/) )
	- Read bytes fed to IronDrawing and export to image file.

## AnyBitmap Cloning ( [Code Example](https://ironsoftware.com/open-source/csharp/drawing/examples/anybitmap-example/) )
	- Generate and save exact copy of AnyBitmap without modifying original AnyBitmap
	- Generate and save a copy of certain parts of an AnyBitmap without modifying original AnyBitmap

## Create Multipage TIFF and GIFF image ( [Code Example](https://ironsoftware.com/open-source/csharp/drawing/examples/anybitmap-example/) )
	- Generate and save a multipage TIFF and GIF file from frames with different dimensions


## Get frame from AnyBitmap ( [Code Example](https://ironsoftware.com/open-source/csharp/drawing/examples/anybitmap-example/) )
	- Capture and save all or specific frame of AnyBitmap such as multipage GIF or TIF file.

## Get number of frames in AnyBitmap. ( [Code Example](https://ironsoftware.com/open-source/csharp/drawing/examples/anybitmap-example/) )
	- Capture number of frames from AnyBitmap file such as multipage GIF or TIF file.


# Color
A universally compatible Color class.

## Create color ( [Code Example](https://ironsoftware.com/open-source/csharp/drawing/examples/color-example/) )
	- Create color from:
		- Hexadecimal value
		- ARGB value
		- Colors available
	-  Color casting
		- Cast color from **System.Drawing.Color** to **IronSoftware.Drawing.Color** and other platforms.
- ## Convert Color ( [Code Example](https://ironsoftware.com/open-source/csharp/drawing/examples/color-example/) )
	- Convert color to 32-bit ARGB value
- ## Get color depth ( [Code Example](https://ironsoftware.com/open-source/csharp/drawing/examples/color-example/) )
	- Analyze quality of an image by looking at the color depth of the image fed into IronDrawing.

# CropRectangle
A universally compatible Rectangle class.## Create and cast CropRectangle ( [Code Example](https://ironsoftware.com/open-source/csharp/drawing/examples/croprectangle-example/) )
	- Create an IronSoftware.Drawing CropRectangle
	- Cast a **System.Drawing.Rectangle** to **IronSoftware.Drawing.CropRectangle**.

## Convert CropRectangle measurement ( [Code Example](https://ironsoftware.com/open-source/csharp/drawing/examples/croprectangle-example/) )
	- Convert CropRectangle measurement from pixels(px) to millimeter(mm) or vice versa.

# Font
A universally compatible Font class.

## Create and cast fonts ( [Code Example](https://ironsoftware.com/open-source/csharp/drawing/examples/font-example/) )

	- Create IronDrawing fonts with options to choose and control font family, font style, and font size.
	- Casting a **System.Drawing.Font** to **IronSoftware.Drawing.Font** and other platforms.