using IronSoftware.Drawing;
using System;


AnyBitmap bitmap = AnyBitmap.FromFile(@"FILE_PATH");
bitmap.SaveAs("output.bmp"); //Generate AnyBitmap using filepath

byte[] bytes = File.ReadAllBytes(@"FILE_PATH");
AnyBitmap bitmap = AnyBitmap.FromBytes(bytes);
bitmap.SaveAs("result.bmp"); //Generate AnyBitmap from bytes

byte[] bytes = File.ReadAllBytes(@"FILE_PATH");
MemoryStream ms = new MemoryStream(bytes);
AnyBitmap bitmap = AnyBitmap.FromStream(ms);
bitmap.SaveAs("output.bmp");  //Generate AnyBitmap from memory stream

Uri uri = new Uri("URI_PATH");
AnyBitmap bitmap = AnyBitmap.FromUri(uri);
bitmap.SaveAs("uriImage.bmp"); //Generate AnyBitmap from Uri

AnyBitmap bitmap = AnyBitmap.FromFile(@"FILE_PATH");
bitmap.SaveAs("result.jpg"); //Generate AnyBitmap file from SVG file







































