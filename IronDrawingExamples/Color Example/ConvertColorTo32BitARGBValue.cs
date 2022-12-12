/**
<h1> Convert Color To 32-Bit ARGB value</h1>

<p>IronDrawing also has a feature of converting colors to 32-bit ARGB values for developers that seek to use the value in programming or simply want to know the value of a certain color.</p>

<p>To use this feature, create a variable of type <code>System.Drawing.Color</code> and assign it to a color available in <code>System.Drawing.Color</code>. From there, use the method <code>.ToArgb()</code> on the variable to convert the color chosen to 32-bit ARGB value.</p>
**/

using IronSoftware.Drawing;

// Convert color to a 32-bit ARGB value
System.Drawing.Color bmColor = System.Drawing.Color.Black;
bmColor.ToArgb(); 
