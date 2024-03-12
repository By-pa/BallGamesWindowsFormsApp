using System;
using System.Windows.Forms;


namespace BallCommon
{
	public class MoveBall : RandomPointBall
	{
		private Timer timer;
		public MoveBall(Form form) : base(form) 
		{
			timer = new Timer();
			timer.Interval = 20;
			timer.Tick += Timer_Tick;

			
		}
		public bool IsMovable()
		{
			return timer.Enabled;
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			Move();
		}

		public void Start()
		{
			timer.Start();
		}
		public void Stop()
		{
			timer.Stop();
		}
	}
}
