using IronSoftware.Drawing;
using System;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;


System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(@"FILE_PATH");
AnyBitmap anyBitmap = bitmap;  //Cast System.Drawing bitmap to AnyBitmap

System.Drawing.Image bitmap = System.Drawing.Image.FromFile(@"FILE_PATH");
AnyBitmap anyBitmap = bitmap; //Cast System image to AnyBitmap

SkiaSharp.SKBitmap skBitmap = SkiaSharp.SKBitmap.Decode(@"FILE_PATH");
AnyBitmap anyBitmap = skBitmap; //Cast SKBitmap to AnyBitmap

SkiaSharp.SKImage skImage = SkiaSharp.SKImage.FromBitmap(SkiaSharp.SKBitmap.Decode(@"FILE_PATH"));
AnyBitmap anyBitmap = skImage;  //Cast SKimage to AnyBitmap

SixLabors.ImageSharp.Image<SixLabors.ImageSharp.PixelFormats.Rgba32> imgSharp = SixLabors.ImageSharp.Image.Load<SixLabors.ImageSharp.PixelFormats.Rgba32>(@"FILE_PATH");
AnyBitmap anyBitmap = imgSharp;  //Cast SixLabors Image to AnyBitmap


byte[] bytes = File.ReadAllBytes(imagePat@"FILE_PATH");
Microsoft.Maui.Graphics.Platform.PlatformImage image = (Microsoft.Maui.Graphics.Platform.PlatformImage)Microsoft.Maui.Graphics.Platform.PlatformImage.FromStream(new MemoryStream(bytes));
AnyBitmap anyBitmap = image; //Cast Maui image to AnyBitmap (not for NET 4.7.2)
