using IronSoftware.Drawing;

// Get and print number of frame in any multipage GIF or TIFF file
var multiFrameImage = AnyBitmap.FromFile("FILE_PATH").FrameCount;
Console.WriteLine(multiFrameImage); 
