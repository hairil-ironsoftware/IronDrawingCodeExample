using IronSoftware.Drawing;
using System;

// Get and print number of frame in any loaded image
var multiFrameImage = AnyBitmap.FromFile("FILE_PATH.gif");
var frameNumber = multiFrameImage.FrameCount;
Console.WriteLine(frameNumber); 
