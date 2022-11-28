﻿using IronSoftware.Drawing;
using System;

AnyBitmap clonedframe = AnyBitmap.FromFile(@"FILE_PATH").Clone();
clonedframe.SaveAs("frameClone.jpg"); //clone AnyBitmap

AnyBitmap clonedWithCrop = AnyBitmap.FromFile(@"FILE_PATH").Clone(new CropRectangle(0, 0, 150, 150));
clonedWithCrop.SaveAs("cropCloned.jpg"); //clone frames of any image with a specified crop area