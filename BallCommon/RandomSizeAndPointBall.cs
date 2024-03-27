using System.Drawing;
using System.Windows.Forms;

namespace BallCommon
{
	public class RandomSizeAndPointBall : RandomPointBall
	{
		public RandomSizeAndPointBall(Form form) : base(form)
		{
			radius = random.Next(10, 40);
		}
	}
}
