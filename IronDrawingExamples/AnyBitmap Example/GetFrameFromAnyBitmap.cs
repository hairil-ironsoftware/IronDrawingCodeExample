#region TopData
/**
~/examples/get-frame-from-anybitmap/

<h1> Get frame from AnyBitmap</h1>

<p>This feature enable users to get or capture frames from a multipage GIF file or TIFF file and save it locally into any image format. Saved frames can be further manipulated in IronDrawing or other Iron Software tools as users wish.</p>

<p>To use this feature, users must first convert the GIF or TIFF file into AnyBitmap type by loading it from a file path using <code>AnyBitmap.FromFile(@"FILE_PATH)</code> method. If users wanted to save individual frame and know the index number of the frame, <code>.GetAllFrames.ElementAt(n).SaveAs("FILE_NAME")</code> method can be used. To get the first and last frame, simply use <code>.First()</code> and <code>.Last()</code> methods accordingly. If users wish to save all frames and save it according to the frame number, users can use <code>for</code> loops on the frames saved in List and use <code>frames[i].SaveAs("frame " + i + ".jpg")</code>.</p>
**/

using IronSoftware.Drawing;
#endregion
public class get_frame_from_anybitmap
{
    public void code()
    {
        //Load a GIF or TIFF as AnyBitmap (loads ALL frames)
        AnyBitmap gifOrTiff = AnyBitmap.FromFile(@"FILE_PATH");

        gifOrTiff.GetAllFrames.First().SaveAs("first.png"); // First frame
        gifOrTiff.GetAllFrames.Last().SaveAs("last.png"); // Last frame
        gifOrTiff.GetAllFrames.ElementAt(1).SaveAs("second.png"); // n'th frame 

        // Save every frame of a GIF or TIFF to images on disk
        List<AnyBitmap> frames = (List<AnyBitmap>)gifOrTiff.GetAllFrames;
        for (int i = 0; i < frames.Count; i++)
        {
            frames[i].SaveAs("frame_" + i + ".jpg");
        }
    }
}


