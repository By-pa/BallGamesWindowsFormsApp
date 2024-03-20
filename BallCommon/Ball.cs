using System;
using System.Drawing;

using System.Windows.Forms;

namespace BallCommon
{
	public class Ball
	{
		protected Form form;
		private Timer timer;

		protected int vx = 5;
		protected int vy = -5;

		protected int centerX = 10;
		protected int centerY = 10;
		protected Brush brush = Brushes.Blue;
		protected int radius = 25;
		protected static Random random = new Random();

		public Ball(Form form)
		{
			this.form = form;
			timer = new Timer();
			timer.Interval = 20;
			timer.Tick += Timer_Tick;
		}

		public Ball(Form form, Brush brush)
		{
			this.form = form;
			this.brush = brush;
			timer = new Timer();
			timer.Interval = 20;
			timer.Tick += Timer_Tick;
		}

		public Brush GetBrush()
		{
			return brush;
		}
		public bool IsMovable()
		{
			return timer.Enabled;
		}


		public void Start()
		{
			timer.Start();
		}
		public void Stop()
		{
			timer.Stop();
		}
		private void Timer_Tick(object sender, EventArgs e)
		{
			Move();
		}
		public void Show()
		{

			Draw(brush);
		}
		public void Move()
		{
			Clear();
			Go();
			Show();
		}

		public  bool Exists(int pointX, int pointY)
		{
			var dx = pointX - centerX;
			var dy = pointY - centerY;
			return dx * dx + dy* dy <= radius * radius;
		}

		public int LeftSide()
		{
			return radius;
		}
		public int RigthSide()
		{
			return form.ClientSize.Width - radius;
		}
		public int TopSide()
		{
			return radius;
		}
		public int DownSide()
		{
			return form.ClientSize.Height - radius;
		}



		public bool OnForm()
		{
			return centerX >= LeftSide() && centerY >= TopSide() && centerX <= RigthSide() && centerY <= DownSide();			
		}

		public bool Contains(int pointX, int pointY)
		{
			var rad = radius / 2;
			var centX = centerX + radius;
			var centY = centerY + radius;
			return (centX - pointX) * (centX - pointX) + (centY - pointY) * (centY - pointY) <= rad * rad;
		}

		protected virtual void Go()
		{
			centerX += vx;
			centerY += vy;
		}
		public void Clear()
		{
			var brush = new SolidBrush(form.BackColor);
			Draw(brush);
		}

		private void Draw(Brush brush)
		{
			var graphiscs = form.CreateGraphics();
			var rectangle = new Rectangle(centerX - radius, centerY - radius, 2 * radius, 2 * radius);
			graphiscs.FillEllipse(brush, rectangle);
		}

	}
}
