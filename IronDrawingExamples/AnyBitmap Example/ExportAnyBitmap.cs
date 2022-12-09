/**
<h1> Export AnyBitmap</h1>

<p>AnyBitmap file generated from IronDrawing tool can be exported to other image formats with the ability to specify the degree of loss in the exported image. This enable users to balance the quality of the image needed with the size of the image file exported.</p>

<p>To export AnyBitmap file to other image formats, simply load AnyBitmap file and use <code>.ExportFile()</code> method. This method has 3 overloads, which are the **exported file name**, **Image format**, and **Image loss**. The exported image can be in format:</p>
<ul>
<li> Bmp</li>
<li> Gif</li>
<li> Png</li>
<li> Jpeg</li>
<li> Tiff</li>
<li> Webp</li>
<li> Wbmp</li>
<li> Wmf</li>
<li> Icon</li>
</ul>
**/

using IronSoftware.Drawing;

//Export AnyBitmap files to other formats with ability to control loss
AnyBitmap bitmap = new AnyBitmap(@"FILE_PATH");
bitmap.ExportFile("losslogo.png", AnyBitmap.ImageFormat.Png, 100); 
