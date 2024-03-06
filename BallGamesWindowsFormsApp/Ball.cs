using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace BallGamesWindowsFormsApp
{
	public class Ball
	{
		private MainForm form;

		private int vx = 10;
		private int vy = 15;

		protected int x = 50;
		protected int y = 50;
		
		protected int size = 50;


		public Ball(MainForm form)
		{
			this.form = form;
		}

		public void Show()
		{
			var graphiscs = form.CreateGraphics();
			var brush = Brushes.Aqua;
			var rectangle = new Rectangle(x, y, size, size);
			graphiscs.FillEllipse(brush, rectangle);
		}
		public void Move()
		{
			Clear();
			Go();
			Show();
		}

		private void Go()
		{

			var random = new Random();
			var point = random.Next(-1, 2);
			var point2 = random.Next(-1, 2);
			x += point;
			y += point2;
		}
		private void Clear()
		{
			var graphiscs = form.CreateGraphics();
			var brush = Brushes.White;
			var rectangle = new Rectangle(x, y, size, size);
			graphiscs.FillEllipse(brush, rectangle);
		}
		
	}
}
