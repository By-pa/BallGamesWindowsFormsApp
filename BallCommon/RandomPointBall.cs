using System;
using System.Drawing;
using System.Windows.Forms;

namespace BallCommon
{
	public class RandomPointBall : Ball
	{
		protected static Random random = new Random();
		public RandomPointBall(Form form, Brush brush): base(form, brush) 
		{
			centerX = random.Next(LeftSide(), RigthSide());
			centerY = random.Next(TopSide(), DownSide());
		}
	}
}
