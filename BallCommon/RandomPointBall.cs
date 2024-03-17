using System;
using System.Windows.Forms;

namespace BallCommon
{
	public class RandomPointBall : Ball
	{
		protected static Random random = new Random();
		public RandomPointBall(Form form): base(form) 
		{
			centerX = random.Next(LeftSide(), RigthSide());
			centerY = random.Next(TopSide(), DownSide());
			
		}
	}
}
