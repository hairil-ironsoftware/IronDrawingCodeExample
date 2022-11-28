﻿using IronSoftware.Drawing;

// Create a new Font object
Font font = new Font("Times New Roman", FontStyle.Italic | FontStyle.Bold, 30);

// Casting between System.Drawing.Font and IronSoftware.Drawing.Font
System.Drawing.Font drawingFont = new System.Drawing.Font("Courier New", 30);
IronSoftware.Drawing.Font ironFont = drawingFont;

ironFont.FamilyName;
ironFont.Style;
ironFont.Size;
ironFont.Italic;
ironFont.Bold;