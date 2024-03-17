using System;
using System.Windows.Forms;

namespace BillyardWindowsFormsApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			for (int i = 0; i < 10; i++)
			{ 
			var ball = new BillyardBall(this);
			ball.OnHited += Ball_OnHited;
			ball.Start();
			}
		}

		private void Ball_OnHited(object sender, HitEventArgs e)
		{
			switch (e.Side)
			{
				case Side.Left:
					leftLabelScore.Text = (Convert.ToInt32(leftLabelScore.Text) + 1).ToString();
					break;
				case Side.Right:
					rightLabelScore.Text = (Convert.ToInt32(rightLabelScore.Text) + 1).ToString();
					break;
				case Side.Top:
					topLabelScore.Text = (Convert.ToInt32(topLabelScore.Text) + 1).ToString();
					break;
				case Side.Bottom:
					bottomLabelScore.Text = (Convert.ToInt32(bottomLabelScore.Text) + 1).ToString();
					break;
			}
		}
	}
}
