#region TopData
/**
~/examples/get-frame-number-from-anybitmap/


<h1> Get number of frames in AnyBitmap</h1>

<p>This feature enable users to get the number of frames inside a multipage GIF or TIFF files easily. </p>

<p>The multipage file to be read can be converted to AnyBitmap type using the file path and get the frame count saved to a variable using <code>AnyBitmap.FromFile(@"FILE_PATH").FrameCount</code> method. </p>

**/

using IronSoftware.Drawing;
#endregion
public class get_frame_number_from_anybitmap
{
    public void code()
    {
        // Get and print the number of frames in any multipage GIF or TIFF file
        var multiFrameImage = AnyBitmap.FromFile("FILE_PATH").FrameCount;
        Console.WriteLine(multiFrameImage);
    }
}


