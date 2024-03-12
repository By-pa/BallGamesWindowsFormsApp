using System;
using System.Drawing;

using System.Windows.Forms;

namespace BallCommon
{
	public class Ball
	{
		private Form form;

		protected int vx = 5;
		protected int vy = -5;

		protected int x = 150;
		protected int y = 150;
		
		protected int size = 50;
		protected static Random Random = new Random();

		public Ball(Form form)
		{
			this.form = form;
		}

		public void Show()
		{
			var graphiscs = form.CreateGraphics();
			var brush = Brushes.Red;
			var rectangle = new Rectangle(x, y, size, size);
			graphiscs.FillEllipse(brush, rectangle);
		}
		public void Move()
		{
			Clear();
			Go();
			Show();
		}

		public bool OnForm()
		{
			return x >= 0 && y >= 0 && x + size <= form.ClientSize.Width && y + size <= form.ClientSize.Height;			
		}

		public bool Contains(int pointX, int pointY)
		{
			var radius = size / 2;
			var centerX = x + radius;
			var centerY = y + radius;
			return (centerX - pointX) * (centerX - pointX) + (centerY - pointY) * (centerY - pointY) <= radius * radius;
		}

		private void Go()
		{
			x += vx;
			y += vy;
		}
		public void Clear()
		{
			var graphiscs = form.CreateGraphics();
			var brush = new SolidBrush(form.BackColor);
			var rectangle = new Rectangle(x, y, size, size);
			graphiscs.FillEllipse(brush, rectangle);
		}
		
	}
}
