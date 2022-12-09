/**
<h1> Create Multipage TIFF and GIF </h1>

<p>Users are able to combine AnyBitmap files into a multipage TIFF or GIF files in IronDrawing. Users can also use different dimensions of frame to create the multipage GIF and TIFF files.</p>

<p>To use this feature, all AnyBitmap frames need to be loaded using the file path and stored inside an initialized List of AnyBitmap type. The TIFF file can now be created from the frames stored by using <code>.CreateMultiFrameTiff(List<AnyBitmap>)</code> or use <code>.CreateMultiFrameGif(List<AnyBitmap>)</code> to create GIF file.</p>
**/

using IronSoftware.Drawing;

// Create a multipage Tiff with frames of different dimensions
List<AnyBitmap> bitmaps = new List<AnyBitmap>()
{
    AnyBitmap.FromFile("cropframe1.jpg"),    
    AnyBitmap.FromFile("frame2.jpg"),
    AnyBitmap.FromFile("cropframe3.jpg"),    
};
AnyBitmap multiFrameTiff = AnyBitmap.CreateMultiFrameTiff(bitmaps);
multiFrameTiff.SaveAs("multiTiffwcrops.tiff");  


// Create a multipage Gif with frames of different dimensions
List<AnyBitmap> bitmaps = new List<AnyBitmap>()
{
    AnyBitmap.FromFile("frame1.jpg"),
    AnyBitmap.FromFile("frame2.jpg"),
    AnyBitmap.FromFile("frame3.jpg"),
    AnyBitmap.FromFile("cropframe4.jpg")
};
AnyBitmap multiFrameGif = AnyBitmap.CreateMultiFrameGif(bitmaps);
multiFrameGif.SaveAs("multiGif.gif");  
