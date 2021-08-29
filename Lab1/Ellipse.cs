using System.Drawing;

namespace Lab1
{
	public class Ellipse : Shape
	{
		public override void drawColoredShape(Graphics fgg, Color c)
		{
			Pen pen = new Pen(c);

			// draw ellipse 
			fgg.DrawEllipse(pen, new System.Drawing.Rectangle(start_x, start_y, end_x - start_x, end_y - start_y));
		}
	}
}
