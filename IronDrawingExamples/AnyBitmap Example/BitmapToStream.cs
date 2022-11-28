using IronSoftware.Drawing;
using System;

AnyBitmap bitmap = AnyBitmap.FromFile(@"FILE_PATH");

// Get stream of AnyBitmap
MemoryStream stream = bitmap.GetStream();

// Convert AnyBitmap to stream
MemoryStream stream1 = bitmap.ToStream(); 
