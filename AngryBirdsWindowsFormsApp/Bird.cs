using BallCommon;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AngryBirdsWindowsFormsApp
{
	public class Bird : MoveBall
	{
		private float g = 0.2f;
		private float elastic = 0.4f;
		public Bird(Form form) : base(form)
		{
			centerX = LeftSide();
			centerY = DownSide();
			brush = Brushes.Blue;
			radius = 15;
		}

		protected override void Go()
		{
			base.Go();


			if (centerY > DownSide())
			{
				vy = -vy;
				centerY = DownSide();
				vy = vy * elastic;
				vx = vx * elastic;
			}

			if (vy < 0.1 && vx < 0.1)
			{
				Stop();
			}
			vy += g;
		}

		public void SetVelocity(int x, int y)
		{
			vx = (x - centerX) / 20;
			vy = (y - centerY) / 20;
		}

		public bool IsOutSide()
		{
			return centerX > RightSide();
		}
	}
}
