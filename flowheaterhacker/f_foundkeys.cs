using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace flowheaterhacker
{
	public partial class f_foundkeys : Form
	{
		private List<string> _keys { get; set; }

		public f_foundkeys(List<string> keys)
		{
			InitializeComponent();

			_keys = keys;

			Load += F_foundkeys_Load;
		}

		private void F_foundkeys_Load(object sender, EventArgs e)
		{
			int i = 1;
			foreach(String s in _keys)
			{
				ListViewItem lvi = new ListViewItem(i + "");
				lvi.SubItems.Add(s);
				lvi.BackColor = i % 2 == 0 ? Color.LightGray : Color.LightYellow;
				lv_Keys.Items.Add(lvi);
			}
		}

		private void lv_Keys_DoubleClick(object sender, EventArgs e)
		{
			if (lv_Keys.FocusedItem != null)
			{
				Clipboard.SetText(lv_Keys.FocusedItem.SubItems[1].Text);
			}
		}

		private void btn_Close_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
