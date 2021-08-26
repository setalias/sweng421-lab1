using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public class Rectangle : Shape
    {
        public override void DrawShape(Panel p, Color c)
        {
            Pen pen = new Pen(c);
            Graphics g = p.CreateGraphics();

            w = Math.Abs(newx - oldx); // width
            h = Math.Abs(newy - oldy); // height
            int diffx = newx - oldx; // direction of cursor drag for x-axis
            int diffy = newy - oldy; // direction of cursor drag for y-axis

            // draw rectangle
            if (diffx > 0 && diffy < 0) g.DrawRectangle(pen, oldx, newy, w, h);
            else if (diffx < 0 && diffy > 0) g.DrawRectangle(pen, newx, oldy, w, h);
            else if (diffx < 0 && diffy < 0) g.DrawRectangle(pen, newx, newy, w, h);
            else if (diffx > 0 && diffy > 0) g.DrawRectangle(pen, oldx, oldy, w, h);
        }
    }
}
