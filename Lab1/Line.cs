using System.Drawing;


namespace Lab1
{
	public class Line : Shape
	{
		public override void drawColoredShape(Graphics fgg, Color c)
        {
			Pen pen = new Pen(c);

			// draw line
			fgg.DrawLine(pen, start_x, start_y, end_x, end_y);
		}

	}
}
