using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace flowheaterhacker
{
	class compareImages
	{
		public bool compare(Rectangle r, Bitmap bmp, out Bitmap foundImage)
		{
			foundImage = getCut(r);

			double fullsize = r.Width * r.Height;
			double errOK = fullsize / 100 * 10;
			int error = 0;

			for(int x = 0; x < r.Width; x++)
			{
				for (int y = 0; y < r.Height; y++)
				{
					if(bmp.GetPixel(x,y) != foundImage.GetPixel(x, y)) { error++; }
				}
			}

			return error < errOK;
		}

		public Bitmap getCut(Rectangle r)
		{
			//r.X -= 33;
			//r.Y -= 39;

			Bitmap bmp = new Bitmap(Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height);
			Bitmap bret = new Bitmap(r.Width, r.Height);
			using (Graphics g = Graphics.FromImage(bret))
			{
				g.CopyFromScreen(r.X, r.Y, 0, 0, r.Size, CopyPixelOperation.SourceCopy);

			}

			using (Graphics g = Graphics.FromImage(bmp))
			{
				g.CopyFromScreen(0, 0, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);
				g.DrawRectangle(Pens.Red, r);
			}
			bmp.Save("fullScreen.bmp");
			return bret;
			//return bmp.Clone(r, System.Drawing.Imaging.PixelFormat.Format64bppArgb);
		}
	}
}
