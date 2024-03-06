using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BallGamesWindowsFormsApp
{
	public partial class MainForm : Form
	{
		List<MoveBall> moveBalls = new List<MoveBall>();
		RandomSizeAndPointBall randomSizeAndPointBall;
		public MainForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			timer.Enabled = !timer.Enabled;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			randomSizeAndPointBall = new RandomSizeAndPointBall(this);
			randomSizeAndPointBall.Show();
		}

		private void MainForm_MouseDown(object sender, MouseEventArgs e)
		{
			var pointBall = new PointBall(this, e.X, e.Y);
			pointBall.Show();
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			randomSizeAndPointBall.Move();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			for (int i = 0; i <10; i++)
			{
				var moveBall = new MoveBall(this);
				moveBalls.Add(moveBall);
				moveBall.Start();
			}
		}
	}
}
