using BallCommon;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BillyardWindowsFormsApp
{
	public class BillyardBall : Ball
	{
		public event EventHandler<HitEventArgs> OnHited;

		public BillyardBall(Form form, Brush brush) : base(form, brush)
		{
			radius = 10;
			centerX = random.Next(LeftSide(), RigthSide());
			centerY = random.Next(TopSide(), DownSide());
			this.brush = brush;
			vx = random.Next(-10, 11);
			vy = random.Next(0, 0);

		}

		public bool LeftOfCenter()
		{
			return centerX + radius < form.ClientSize.Width / 2;
		}
		public bool RightOfCenter()
		{
			return centerX - radius > form.ClientSize.Width / 2;
		}
		protected override void Go()
		{
			base.Go();

			if (centerX <= LeftSide())
			{
				vx = -vx;
				OnHited.Invoke(this, new HitEventArgs(Side.Left));
			}
			if (centerX >= RigthSide())
			{
				vx = -vx;
				OnHited.Invoke(this, new HitEventArgs(Side.Right));
			}
			if (centerY <= TopSide())
			{
				vy = -vy;
				OnHited.Invoke(this, new HitEventArgs(Side.Top));
			}
			if (centerY >= DownSide())
			{
				vy = -vy;
				OnHited.Invoke(this, new HitEventArgs(Side.Bottom));
			}
		}
	}
}
