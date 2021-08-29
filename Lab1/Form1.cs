using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
	public partial class Form1 : Form
	{

		public Form1()
		{
			InitializeComponent();
		}

		Shape s = new Shape();
		int red;
		int green;
		int blue;

		int start_x;
		int start_y;

		Bitmap bg, fg;
		Graphics bgg, fgg;
		Point pt1, pt2;
		bool down = false;
		String shape_type;
		
		private void button1_Click(object sender, EventArgs e)
		{
			s = new Line();
			shape_type = "line_shape";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			s = new Rectangle();
			shape_type = "rectangle_shape";
		}

		private void button3_Click(object sender, EventArgs e)
		{
			s = new Ellipse();
			shape_type = "ellipse_shape";
		}

		private void trackBar1_ValueChanged(object sender, EventArgs e)
		{
			red = trackBar1.Value;
		}

		private void trackBar2_ValueChanged(object sender, EventArgs e)
		{
			green = trackBar2.Value;
		}

		private void trackBar3_ValueChanged(object sender, EventArgs e)
		{
			blue = trackBar3.Value;
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			//s.oldx = e.X;
			//s.oldy = e.Y;

			start_x = e.X;
			start_y = e.Y;

			down = true;
			pt1 = e.Location;

			if (bg == null)
            {
				bg = new Bitmap(panel1.Width, panel1.Height);
				fg = new Bitmap(panel1.Width, panel1.Height);
				bgg = Graphics.FromImage(bg);
				bgg.FillRectangle(Brushes.White, 0, 0, panel1.Width, panel1.Height);
				fgg = Graphics.FromImage(fg);
            }

			
			
		}

		private void panel1_MouseUp(object sender, MouseEventArgs e)
		{
			down = false;
			bgg.DrawImage(fg, 0, 0);
			
			//Pen pen = new Pen(Color.Red);
			//Graphics g = panel1.CreateGraphics();
			//g.DrawLine(pen, oldX, oldY, e.X, e.Y);
			//Color c = new Color();
			//c = Color.FromArgb(red,green,blue);
			//s.newx = e.X;
			//s.newy = e.Y;
			//s.drawColoredShape(panel1,c);
	
		}

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (down)
            {

				Color c = new Color();
				c = Color.FromArgb(red, green, blue);
				fgg.DrawImage(bg, 0, 0);
				Pen pen = new Pen(c);
				pt2 = e.Location;
				if (shape_type == "line_shape") {
					fgg.DrawLine(pen, pt1, pt2);
				}
				else if (shape_type == "rectangle_shape")
				{
					fgg.DrawRectangle(pen, new System.Drawing.Rectangle(start_x, start_y, e.X - start_x, e.Y - start_y));
				}
				else if (shape_type == "ellipse_shape")
				{
					fgg.DrawEllipse(pen, new System.Drawing.Rectangle(start_x, start_y, e.X - start_x, e.Y - start_y));
				}
				Graphics g = panel1.CreateGraphics();
				g.DrawImage(fg, 0, 0);

            }
		}
    }
}
