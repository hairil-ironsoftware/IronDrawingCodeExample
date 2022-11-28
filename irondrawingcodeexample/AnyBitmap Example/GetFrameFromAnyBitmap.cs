using IronSoftware.Drawing;
using System;

AnyBitmap multiPage = AnyBitmap.FromFile(@"FILE_PATH.tiff"); //Load tiff Image as AnyBitmap
multiPage.GetAllFrames.First().SaveAs("first.png"); //save first frame of a tiff file
multiPage.GetAllFrames.Last().SaveAs("last.png"); //save last frame of a tiff
multiPage.GetAllFrames.ElementAt(1).SaveAs("second.png"); //save frame at an index of a tiff

//save every frame of image of gif to image format
AnyBitmap multiFrameImage = AnyBitmap.FromFile(@"FILE_PATH.gif");
List<AnyBitmap> frames = (List<AnyBitmap>)multiFrameImage.GetAllFrames;
for(int i = 0; i < frames.Count; i++)
{
    frames[i].SaveAs("frame" + i + ".jpg"); 
