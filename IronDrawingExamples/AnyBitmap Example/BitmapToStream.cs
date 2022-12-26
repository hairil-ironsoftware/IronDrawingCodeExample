#region TopData
/**
~/Code Examples/bitmap-to-stream/


<h1> Converting Bitmap To Stream </h1>

<p>AnyBitmap generated from a program or opened from a file directory in users computer can be converted to a memory stream to be used further in the program without the need to create a temporary buffers and files in an application. In this code example, we provide a simple way on how to get stream and also converting AnyBitmap file loaded from local directory to  memory stream. <p>

<h2> Get Stream </h2>

<p>This function is used to get the stream from a particular AnyBitmap file. Simply assign a MemoryStream variable to store the memory stream from an AnyBitmap file obtained using <code>.GetStream()</code> method.</p>

<h2> To Stream </h2>

<p>This function is used to convert AnyBitmap file to a memory stream. Simply assign a MemoryStream variable to store the value of AnyBitmap file converted to memory stream using <code>.ToStream()</code> method.</p>

**/

using IronSoftware.Drawing;
#endregion
public class bitmap_to_stream
{
    public void code()
    {
        AnyBitmap bitmap = AnyBitmap.FromFile(@"FILE_PATH");

        // Get stream of AnyBitmap
        MemoryStream stream = bitmap.GetStream();

        // Convert AnyBitmap to stream
        MemoryStream stream1 = bitmap.ToStream();
    }
}

