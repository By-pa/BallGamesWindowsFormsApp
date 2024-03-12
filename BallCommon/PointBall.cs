using System;
using System.Windows.Forms;

namespace BallCommon
{
	public class PointBall : Ball
	{
		static Random random = new Random();
		public PointBall(Form form, int x, int y): base(form)
		{
			size = 1000;
			this.x = x - this.x / 2;
			this.y = y - this.y / 2;
			
		}
	}
}
