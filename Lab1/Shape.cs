using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
	public class Shape
	{
		public int oldx { get; set; }
		public int oldy { get; set; }
		public int newx { get; set; }
		public int newy { get; set; } 
		public int w { get; set; } 
		public int h { get; set; }
		public Color color { get; set; }

		public virtual void DrawShape(Panel p, Color c) { }
		//public void bufferShape(Graphics fgg) { } 
	}
}
