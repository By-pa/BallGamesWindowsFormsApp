using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitNinjaWindowsFormsApp
{
	public partial class MainForm : Form
	{
		private static Random random = new Random();
		private Timer timer = new Timer();
		private List<FruitBall> fruits = new List<FruitBall>();
		 
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			timer.Interval = 1000;
			timer.Tick += Timer_Tick;
			timer.Start();
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			for(int i = 0; i < random.Next(4,10);i++)
			{
				var bombNumber = random.Next(5);

				var ball = bombNumber == 4? new BombBall(this) : new FruitBall(this);

				fruits.Add(ball);

				ball.Start();
			}

			timer.Interval = random.Next(2000, 5000);
		}

		private void MainForm_MouseMove(object sender, MouseEventArgs e)
		{
			foreach(var fruit in fruits)
			{
				if (fruit.IsMovable() && fruit.Contains(e.X, e.Y))
				{
					fruit.Stop();

					if(fruit is BombBall)
					{
						EndGame();
						return;

					}
					fruit.Clear();

					scoreLabel.Text = (Convert.ToInt32(scoreLabel.Text) + 1).ToString();
				}
			}

		}

		private void EndGame()
		{
			timer.Stop();
			foreach(var fruit in fruits)
			{
				fruit.Stop();
			}
			MessageBox.Show("Игра окончена");
		}
	}
}
