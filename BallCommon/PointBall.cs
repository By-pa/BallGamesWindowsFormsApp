using System;
using System.Windows.Forms;

namespace BallCommon
{
	public class PointBall : Ball
	{
		public PointBall(Form form, int x, int y): base(form)
		{
			radius = 1000;
			this.centerX = x - this.centerX / 2;
			this.centerY = y - this.centerY / 2;
			
		}
	}
}
