using IronSoftware.Drawing;

//Load GIF or TIFF as AnyBitmap
AnyBitmap gifOrTiff = AnyBitmap.FromFile(@"FILE_PATH");

gifOrTiff.GetAllFrames.First().SaveAs("first.png"); //First frame
gifOrTiff.GetAllFrames.Last().SaveAs("last.png"); //Last frame
gifOrTiff.GetAllFrames.ElementAt(1).SaveAs("second.png"); //n'th frame 

// save every frame of image of GIF or TIFF to image on disk
List<AnyBitmap> frames = (List<AnyBitmap>)gifOrTiff.GetAllFrames;
for (int i = 0; i < frames.Count; i++)
{
    frames[i].SaveAs("frame" + i + ".jpg");
}
