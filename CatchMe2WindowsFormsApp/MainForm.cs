using BallCommon;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace CatchMe2WindowsFormsApp
{
	public partial class MainForm : Form
	{
		private List<Ball> balls;

		private int countBalls = 0;
		public MainForm()
		{
			InitializeComponent();
		}

		private void startButton_Click(object sender, EventArgs e)
		{
			startButton.Enabled = false;
			clearButton.Enabled = true;
			balls = new List<Ball>();


			for (int i = 0; i < 10; i++)
			{
				var moveBall = new RandomMoveBall(this);
				balls.Add(moveBall);
				moveBall.Start();
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			clearButton.Enabled = false;

		}

		private void MainForm_MouseDown(object sender, MouseEventArgs e)
		{
			if (balls != null)
			{
				foreach (var moveBall in balls)
				{
					if (moveBall.IsMovable() && moveBall.Contains(e.X, e.Y))
					{
						moveBall.Stop();
						countBalls++;
						countBallsLabel.Text = countBalls.ToString();
					}
				}
			}
		}

		private void clearButton_Click(object sender, EventArgs e)
		{
			foreach (var moveBall in balls)
			{
				moveBall.Clear();
			}
			countBalls = 0;
			countBallsLabel.Text = countBalls.ToString();
			startButton.Enabled = true;
			clearButton.Enabled = false;
		}
	}
}
