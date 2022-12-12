/**
<h1> Create and Cast Fonts</h1>

<p>Users are able to create fonts to be used further in the program using IronDrawing. Apart from that, users are also able to use an existing <code>System.Drawing.Font</code> in the program simply by casting it to <code>IronSoftware.Drawing.Font</code>.</p>

<h2> Create Fonts</h2>

<p>To create fonts, user can simply instantiate a System.Drawing.Fonts and set the font family, font style, and the size of the font as is <code>Font("Times New Roman", FontStyle.Italic | FontStyle.Bold, 30)</code>. This will produce a bolded and italic styled, Times New Roman font with a 30 px font size.</p>

<h2> Cast Fonts</h2>

<p>To cast fonts from System.Drawing.Font, simply assign an instantiated font to a variable with <code>IronSoftware.Drawing.Font</code> type.</p>
**/

using IronSoftware.Drawing;

// Create a new Font object
Font font = new Font("Times New Roman", FontStyle.Italic | FontStyle.Bold, 30);

// Cast between System.Drawing.Font and IronSoftware.Drawing.Font
System.Drawing.Font drawingFont = new System.Drawing.Font("Courier New", 30);
IronSoftware.Drawing.Font ironFont = drawingFont;

// Access Font Properties
ironFont.FamilyName;
ironFont.Style;
ironFont.Size;
ironFont.Italic;
ironFont.Bold;
