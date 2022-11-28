using IronSoftware.Drawing;
using System;


List<AnyBitmap> bitmaps = new List<AnyBitmap>()
{
    AnyBitmap.FromFile("cropframe1.jpg"),    
    AnyBitmap.FromFile("frame2.jpg"),
    AnyBitmap.FromFile("cropframe3.jpg"),    
};
AnyBitmap multiFrameTiff = AnyBitmap.CreateMultiFrameTiff(bitmaps);
multiFrameTiff.SaveAs("multiTiffwcrops.tiff");   //create multipage tiff, can also use frame of different dimensions

List<AnyBitmap> bitmaps = new List<AnyBitmap>()
{
    AnyBitmap.FromFile("frame1.jpg"),
    AnyBitmap.FromFile("frame2.jpg"),
    AnyBitmap.FromFile("frame3.jpg"),
    AnyBitmap.FromFile("cropframe4.jpg")
};
AnyBitmap multiFrameGif = AnyBitmap.CreateMultiFrameGif(bitmaps);
multiFrameGif.SaveAs("multiGif.gif");  //create multipage gif