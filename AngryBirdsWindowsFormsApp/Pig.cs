using BallCommon;
using System.Drawing;
using System.Windows.Forms;

namespace AngryBirdsWindowsFormsApp
{
	public class Pig : MoveBall
	{
		public Pig(Form form) : base(form)
		{
			brush = Brushes.Pink;
			radius = 30;
		}
	}
}
