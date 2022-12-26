#region TopData
/**
~/examples/create-color/


<h1> Create Color</h1>

<p>IronDrawing enables users to create their own color using various ways including Hexadecimal, RGB values, and also from Enum where the customer can choose an already available color.</p>

<h2> Color creation</h2>

<p>To create a color using Hexadecimal value, simply create a variable with the type Color and assign the hexadecimal value in terms of string to the variable using <code>new Color("#191919")</code> method. To create color using RGB values, key in the RGB values <code>new Color(255, 255, 0)</code> and store it inside a Color type variable.</p>

<h2> Casting System.Drawing.Color to IronSoftware.Drawing.Color</h2>

<p>Simply assign a System.Drawing.Color type variable with a color <code>System.Drawing.Color.Red</code>. Next, assign the variable to a new IronSoftware.Drawing.Color variable. ARGB values can be extracted and read from the color casted.</p>

<h2> Luminance</h2>

<p>To get the luminance of the color casted, or any IronSoftware.Drawing.Color, simply use <code>.GetLuminance()</code> method on the color. Luminance is a value from 0 (black) to 100 (white) where 50 is the perceptual "middle grey".</p>

**/

using IronSoftware.Drawing;
#endregion
public class create_color
{
    public void code()
    {
        // Create a new Color object
        Color fromHex = new Color("#191919");
        Color fromRgb = new Color(255, 255, 0);
        Color fromEnum = Color.Crimson;

        // Cast between System.Drawing.Color and IronSoftware.Drawing.Color
        System.Drawing.Color drawingColor = System.Drawing.Color.Red;
        IronSoftware.Drawing.Color ironColor = drawingColor;

        // Get the Alpha, Red, Green, or Blue channel value of a Color
        ironColor.A;
        ironColor.R;
        ironColor.G;
        ironColor.B;

        // Luminance
        ironColor.GetLuminance();
    }
}


