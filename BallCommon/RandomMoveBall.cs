using System.Drawing;
using System.Windows.Forms;

namespace BallCommon
{
	public class RandomMoveBall: MoveBall
	{
		public RandomMoveBall(Form form, Brush brush) : base(form, brush) 
		{
			vx = random.Next(-5, 6);
			vy = random.Next(-5, 6);
			this.brush = brush;
		}
	}
}
