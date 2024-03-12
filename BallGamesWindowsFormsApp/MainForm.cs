using BallCommon;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace BallGamesWindowsFormsApp
{
	public partial class MainForm : Form
	{
		List<MoveBall> moveBalls = new List<MoveBall>();
		RandomSizeAndPointBall randomSizeAndPointBall;
		int countClick = 0;
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_MouseDown(object sender, MouseEventArgs e)
		{
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			randomSizeAndPointBall.Move();
		}

		private void button3_Click(object sender, EventArgs e)
		{

			stopButton.Enabled = true;
			startButton.Enabled = false;
			for (int i = 0; i < 2; i++)
			{
				var moveBall = new MoveBall(this);
				moveBalls.Add(moveBall);
				moveBall.Start();
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			var countBalls = 0;
			for (int i = 0; i < moveBalls.Count; i++)
			{
				moveBalls[i].Stop();
				if (moveBalls[i].OnForm())
				{
					countBalls++;
				}
			}
			clearButton.Enabled = true;
			stopButton.Enabled = false;
			MessageBox.Show("Шариков было поймато: " + countBalls.ToString());

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			foreach(var moveBall in moveBalls)
			{
				moveBall.Clear();
			}
			clearButton.Enabled = false;
			stopButton.Enabled = false;
			startButton.Enabled = true;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			stopButton.Enabled = false;
			clearButton.Enabled = false;
		}
	}
}
