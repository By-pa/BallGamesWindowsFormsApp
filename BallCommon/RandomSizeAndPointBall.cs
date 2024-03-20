using System.Drawing;
using System.Windows.Forms;

namespace BallCommon
{
	public class RandomSizeAndPointBall : RandomPointBall
	{
		public RandomSizeAndPointBall(Form form, Brush brush) : base(form, brush)
		{
			radius = random.Next(10, 40);
		}
	}
}
