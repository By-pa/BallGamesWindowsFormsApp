using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BallCommon;

namespace SalutWindowsFormsApp
{
	public partial class MainForm : Form
	{
		private Random random= new Random();
		public MainForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void MainForm_MouseDown(object sender, MouseEventArgs e)
		{
			Random random = new Random();
			var l = random.Next(0, 10);
			
			var salutBalls = new List<SalutBall>();

			for(int i = 0; i < l; i++)
			{
				var salutBall = new SalutBall(this, e.X, e.Y);
				salutBall.Start();
			}
			
		}

		private void startButton_Click(object sender, EventArgs e)
		{
			var ball = new StartSalutBall(this);
			ball.TopReached += Ball_TopReached;
			ball.Start();	

		}

		private void Ball_TopReached(object sender, BallCommon.TopReachedEventArgs e)
		{
			for (int i = 0; i < random.Next(4, 10); i++)
			{
				var ball = new SalutBall(this, e.X, e.Y);
				ball.Start();
			}
		}
	}
}
