using BallCommon;
using System.Drawing;
using System.Windows.Forms;

namespace FruitNinjaWindowsFormsApp
{
	public class FruitBall : RandomMoveBall
	{
		private float g = 0.2f;
		public FruitBall(Form form) : base(form)
		{
			brush = new SolidBrush(Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)));
			radius = 15;
			centerY = form.ClientSize.Height + radius;
			vy = (float)random.NextDouble() * -6 - 7;
		}

		protected override void Go()
		{
			base.Go();
			vy += g;
		}
	}
}
