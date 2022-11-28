using IronSoftware.Drawing;
using System;

AnyBitmap bitmap = AnyBitmap.FromFile(@"FILE_PATH");
MemoryStream stream = bitmap.GetStream(); //get stream of an Anybitmap
MemoryStream stream1 = bitmap.ToStream(); //convert AnyBitmap to stream 