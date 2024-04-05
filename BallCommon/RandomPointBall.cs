﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace BallCommon
{
	public class RandomPointBall : Ball
	{
		public RandomPointBall(Form form) : base(form)
		{
			centerX = random.Next(LeftSide(), RightSide());
			centerY = random.Next(TopSide(), DownSide());
		}
	}
}
