using System;
using System.Drawing;

namespace Lab1
{
    public class Rectangle : Shape
    {
        public override void drawColoredShape(Graphics fgg, Color c)
        {
            Pen pen = new Pen(c);

            w = Math.Abs(end_x - start_x); // width
            h = Math.Abs(end_y - start_y); // height
            int diffx = end_x - start_x; // direction of cursor drag for x-axis
            int diffy = end_y - start_y; // direction of cursor drag for y-axis

            // draw rectangle
            if (diffx > 0 && diffy < 0) fgg.DrawRectangle(pen, start_x, end_y, w, h);
            else if (diffx < 0 && diffy > 0) fgg.DrawRectangle(pen, end_x, start_y, w, h);
            else if (diffx < 0 && diffy < 0) fgg.DrawRectangle(pen, end_x, end_y, w, h);
            else if (diffx > 0 && diffy > 0) fgg.DrawRectangle(pen, start_x, start_y, w, h);
        }
    }
}
