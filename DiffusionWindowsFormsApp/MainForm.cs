using BallCommon;
using BillyardWindowsFormsApp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DiffusionWindowsFormsApp
{
	public partial class MainForm : Form
	{
		private Timer timer = new Timer();
		private List<BillyardBall> balls = new List<BillyardBall>();
		int ballCount = 20;
		public MainForm()
		{
			InitializeComponent();
			timer.Interval = 15;
			timer.Tick += Timer_Tick;
			timer.Start();
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			ShowVerticalCenterLine();
			int leftOfCenterBlueCount = 0;
			int rightOfCenterBlueCount = 0;

			int leftOfCenterRedCount = 0;
			int rightOfCenterRedCount = 0;
			foreach (var ball in balls)
			{
				if (ball.LeftOfCenter())
				{
					if (ball.GetBrush() == Brushes.Blue)
					{
						leftOfCenterBlueCount++;
					}
					else
					{
						leftOfCenterRedCount++;
					}

				}
				else
				if (ball.RightOfCenter())
				{
					if (ball.GetBrush() == Brushes.Blue)
					{
						rightOfCenterBlueCount++;
					}
					else
					{
						rightOfCenterRedCount++;
					}
				}
			}

			if (leftOfCenterBlueCount == leftOfCenterRedCount && rightOfCenterRedCount == rightOfCenterBlueCount &&
			leftOfCenterBlueCount + leftOfCenterRedCount == rightOfCenterBlueCount + rightOfCenterRedCount)
			{
				foreach (var ball in balls)
				{
					ball.Stop();
				}
			}
			

		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			
			for (int i = 0; i < ballCount / 2; i++)
			{
				var ball = new BillyardBall(this, Brushes.Blue);
				ball.OnHited += Ball_OnHited_1;
				ball.Start();
				balls.Add(ball);

				ball = new BillyardBall(this, Brushes.Red);
				ball.OnHited += Ball_OnHited_2;
				ball.Start();
				balls.Add(ball);
			}
		}

		private void ShowVerticalCenterLine()
		{
			var graphics = CreateGraphics();
			graphics.DrawLine(Pens.Gray, ClientSize.Width / 2, 0, ClientSize.Width / 2, ClientSize.Height);
		}

		private void Ball_OnHited_1(object sender, HitEventArgs e)
		{
			switch (e.Side)
			{
				case Side.Left:
					leftBlueLabel.Text = (Convert.ToInt32(leftBlueLabel.Text) + 1).ToString();
					break;
				case Side.Right:
					rightBlueLabel.Text = (Convert.ToInt32(rightBlueLabel.Text) + 1).ToString();
					break;
				case Side.Top:
					topBlueLabel.Text = (Convert.ToInt32(topBlueLabel.Text) + 1).ToString();
					break;
				case Side.Bottom:
					bottomBlueLabel.Text = (Convert.ToInt32(bottomBlueLabel.Text) + 1).ToString();
					break;
			}
		}
		private void Ball_OnHited_2(object sender, HitEventArgs e)
		{
			switch (e.Side)
			{
				case Side.Left:
					leftRedLabel.Text = (Convert.ToInt32(leftRedLabel.Text) + 1).ToString();
					break;
				case Side.Right:
					rightRedLabel.Text = (Convert.ToInt32(rightRedLabel.Text) + 1).ToString();
					break;
				case Side.Top:
					topRedLabel.Text = (Convert.ToInt32(topRedLabel.Text) + 1).ToString();
					break;
				case Side.Bottom:
					bottomRedLabel.Text = (Convert.ToInt32(bottomRedLabel.Text) + 1).ToString();
					break;
			}
		}
	}
}
