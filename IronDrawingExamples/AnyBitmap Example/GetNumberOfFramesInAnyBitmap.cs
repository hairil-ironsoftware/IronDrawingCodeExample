using IronSoftware.Drawing;

// Get and print number of frame in any multipage GIF or TIFF file
var multiFrameImage = AnyBitmap.FromFile("FILE_PATH");
var frameNumber = multiFrameImage.FrameCount;
Console.WriteLine(frameNumber); 
