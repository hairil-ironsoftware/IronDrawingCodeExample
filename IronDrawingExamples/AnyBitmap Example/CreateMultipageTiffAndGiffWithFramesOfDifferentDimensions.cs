using IronSoftware.Drawing;
using System;

// Create multipage Tiff with different frame dimensions
List<AnyBitmap> bitmaps = new List<AnyBitmap>()
{
    AnyBitmap.FromFile("cropframe1.jpg"),    
    AnyBitmap.FromFile("frame2.jpg"),
    AnyBitmap.FromFile("cropframe3.jpg"),    
};
AnyBitmap multiFrameTiff = AnyBitmap.CreateMultiFrameTiff(bitmaps);
multiFrameTiff.SaveAs("multiTiffwcrops.tiff");  


//Create multipage Gif with different frame dimensions
List<AnyBitmap> bitmaps = new List<AnyBitmap>()
{
    AnyBitmap.FromFile("frame1.jpg"),
    AnyBitmap.FromFile("frame2.jpg"),
    AnyBitmap.FromFile("frame3.jpg"),
    AnyBitmap.FromFile("cropframe4.jpg")
};
AnyBitmap multiFrameGif = AnyBitmap.CreateMultiFrameGif(bitmaps);
multiFrameGif.SaveAs("multiGif.gif");  
