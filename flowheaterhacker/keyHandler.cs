using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace flowheaterhacker
{
	class keyHandler
	{
		compareImages ci = new compareImages();

		Bitmap bmp_corner			= Properties.Resources.corner;
		Bitmap bmp_t_off			= Properties.Resources.t_off;
		Bitmap bmp_t_on				= Properties.Resources.t_on;

		public Bitmap foundCorner	= null;
		public Bitmap foundT		= null;

		public Point cornerPos		{ get; set; } = new Point(564 , 200);
		public Point tDistance		{ get; set; } = new Point(176 , 548);
		public Point tPosition		{ get; set; }

		public bool cornerOK		= false;
		public bool tFound			= false;
		public bool tButtonOk		= false;

		public keyHandler()
		{
			tPosition = new Point(cornerPos.X + tDistance.X, cornerPos.Y + tDistance.Y);
			//cornerOK = ci.compare(new Rectangle(cornerPos, bmp_corner.Size), bmp_corner, out foundCorner);
			testCorner();
		}

		public void testCorner()
		{
			cornerOK = ci.compare(new Rectangle(cornerPos, bmp_corner.Size), bmp_corner, out foundCorner);
		}

		public void sendKey(string key)
		{
			foreach(char c in key)
			{
				SendKeys.SendWait(c + "");
			}

			tFound		= ci.compare(new Rectangle(tPosition, bmp_t_off.Size), bmp_t_off, out foundT);
			tButtonOk	= ci.compare(new Rectangle(tPosition, bmp_t_on.Size), bmp_t_on, out foundT);

			//SendKeys.SendWait("^(A)");
			SendKeys.SendWait("^(+({LEFT 11}))");
			SendKeys.SendWait("{BS}");

			Thread.Sleep(50);
		}
	}
}
