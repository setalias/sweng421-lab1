using System.Drawing;


namespace Lab1
{
	public class Shape
	{
		public int start_x { get; set; }
		public int start_y { get; set; }
		public int end_x { get; set; }
		public int end_y { get; set; }
		public int w { get; set; }
		public int h { get; set; }
		public Color color { get; set; }
		public int type { get; set; }

		// draw colored shape
		public virtual void drawColoredShape(Graphics fgg, Color c) { }
	}
}