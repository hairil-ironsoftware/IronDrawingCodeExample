using IronSoftware.Drawing;
using System;

var multiFrameImage = AnyBitmap.FromFile("FILE_PATH.gif");
var frameNumber = multiFrameImage.FrameCount;
Console.WriteLine(frameNumber); //Get number of frame in any loaded image