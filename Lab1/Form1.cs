using System;
using System.Collections.Generic;
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

		List<Shape> draw = new List<Shape>(); //store shapes drawn on panel
		Shape s = new Shape();  // to get shape 
		int red, blue, green;   // for rbg pen color 
		Bitmap bg, fg;
		Graphics bgg, fgg, g;
		bool down = false;
		bool redraw = false;

		private void button1_Click(object sender, EventArgs e)
		{
			s = new Line(); // line button
			s.type = 0;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			s = new Rectangle(); // rectangle button 
			s.type = 1;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			s = new Ellipse(); // ellipse button 
			s.type = 2;
		}

		private void trackBar1_ValueChanged(object sender, EventArgs e)
		{
			red = trackBar1.Value; // red tracker
		}

		private void trackBar2_ValueChanged(object sender, EventArgs e)
		{
			green = trackBar2.Value; // green tracker 
		}

        private void panel1_Resize(object sender, EventArgs e)
        {
			Bitmap bg1 = bg;
			Bitmap fg1 = fg;
			bg = new Bitmap(panel1.Width, panel1.Height);
			fg = new Bitmap(panel1.Width, panel1.Height);
			bgg = Graphics.FromImage(bg);
			bgg.FillRectangle(Brushes.White, 0, 0, panel1.Width, panel1.Height);
			fgg = Graphics.FromImage(fg);
			fgg.DrawImage(bg1, 0, 0);
			bgg.DrawImage(fg1, 0, 0);
			redraw = true;

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
			draw.Add(s);                // save to list


		}

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (down)
			{
				fgg.DrawImage(bg, 0, 0);

				// get color from sliders 
				Color c = new Color();
				c = Color.FromArgb(red, green, blue);
				s.color = c;

				// get end location for shape 
				s.end_x = e.X;
				s.end_y = e.Y;

				// draw the colored shape 
				s.drawColoredShape(fgg, c);

				// draw to panel 
				g = panel1.CreateGraphics();
				g.DrawImage(fg, 0, 0);
			}
		}
	}
}