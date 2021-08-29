using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1
{
	public partial class Form1 : Form
	{

		public Form1()
		{
			InitializeComponent();
		}

		Shape s = new Shape();  // to get shape 
		int red, blue, green;   // for rbg pen color 
		Bitmap bg, fg;
		Graphics bgg, fgg;
		bool down = false;

		private void button1_Click(object sender, EventArgs e)
		{
			s = new Line(); // line button
		}

		private void button2_Click(object sender, EventArgs e)
		{
			s = new Rectangle(); // rectangle button 
		}

		private void button3_Click(object sender, EventArgs e)
		{
			s = new Ellipse(); // ellipse button 
		}

		private void trackBar1_ValueChanged(object sender, EventArgs e)
		{
			red = trackBar1.Value; // red tracker
		}

		private void trackBar2_ValueChanged(object sender, EventArgs e)
		{
			green = trackBar2.Value; // green tracker 
		}

		private void trackBar3_ValueChanged(object sender, EventArgs e)
		{
			blue = trackBar3.Value; // blue tracker 
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			// get starting values of shape 
			s.start_x = e.X;
			s.start_y = e.Y;

			// mouse is down
			down = true;

			// if background null, create background and foreground 
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

			down = false;               // mouse is no longer down
			bgg.DrawImage(fg, 0, 0);    // keep image on panel before new image
		}

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (down)
			{
				fgg.DrawImage(bg, 0, 0);

				// get color from sliders 
				Color c = new Color();
				c = Color.FromArgb(red, green, blue);

				// get end location for shape 
				s.end_x = e.X;
				s.end_y = e.Y;

				// draw the colored shape 
				s.drawColoredShape(fgg, c);

				// draw to panel 
				Graphics g = panel1.CreateGraphics();
				g.DrawImage(fg, 0, 0);

			}
		}
	}
}