#region TopData
/**
~/examples/bitmap-to-string/


<h1> Convert AnyBitmap to string</h1>

<p>IronDrawing also has a feature to convert AnyBitmap files to a unique string of characters that represent the current AnyBitmap files based on the characteristics of the AnyBitmap files. Any small change to a particular AnyBitmap file will change the string of the file and similar AnyBitmap file will have similar string. Therefore, it is useful as one way to check the similarity by comparing strings of two AnyBitmap files.</p>

<p>To use this feature, simply load AnyBitmap file from a file path and assign it to a <strong>string</strong> variable to store the string of the AnyBitmap file loaded using the method <code>.ToString()</code> </p>
**/

using IronSoftware.Drawing;
#endregion
public class bitmap_to_string
{
    public void code()
    {
        AnyBitmap bitmap = AnyBitmap.FromFile(@"FILE_PATH");

        // Convert AnyBitmap to a string that represents the object
        string bitmapString = bitmap.ToString();
    }
}

