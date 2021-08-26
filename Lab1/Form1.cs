﻿using System;
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
		Shape s = new Shape();
		int red;
		int green;
		int blue;

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			s = new Line();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			s = new Rectangle();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			s = new Ellipse();
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
			s.oldx = e.X;
			s.oldy = e.Y;
			
		}

		private void panel1_MouseUp(object sender, MouseEventArgs e)
		{
			//Pen pen = new Pen(Color.Red);
			//Graphics g = panel1.CreateGraphics();
			//g.DrawLine(pen, oldX, oldY, e.X, e.Y);
			Color c = new Color();
			c = Color.FromArgb(red,green,blue);
			s.newx = e.X;
			s.newy = e.Y;
			s.DrawShape(panel1,c);
		}

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{

		}

        
    }
}