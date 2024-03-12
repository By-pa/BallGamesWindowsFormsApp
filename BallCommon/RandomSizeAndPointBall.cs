using System.Windows.Forms;

namespace BallCommon
{
	public class RandomSizeAndPointBall : RandomPointBall
	{
		public RandomSizeAndPointBall(Form form) : base(form)
		{
			size = random.Next(20, 80);
		}
	}
}
