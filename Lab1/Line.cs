using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
	public class Line : Shape
	{
		public override void DrawShape(Panel p, Color c)
        {
			Pen pen = new Pen(c);
			Graphics g = p.CreateGraphics();
			g.DrawLine(pen,oldx,oldy,newx,newy);
		}

	}
}
