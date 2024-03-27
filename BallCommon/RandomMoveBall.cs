using System.Drawing;
using System.Windows.Forms;

namespace BallCommon
{
	public class RandomMoveBall: MoveBall
	{
		public RandomMoveBall(Form form) : base(form) 
		{
			vx = random.Next(-5, 6);
			vy = random.Next(-5, 6);
		}
	}
}
