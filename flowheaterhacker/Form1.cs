using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace flowheaterhacker
{
	public partial class Form1 : Form
	{
		string redCircle = "🔴";
		string load = "⚪◔◑◕⚫";
		int loadPointer = 0;

		bool run = false;
		string file = "";
		string key = "00000-00000-00000-00000-00000-00000";
		//string key = "P4008-01232-51903-62917-47122-17W00";
		keyHandler kh = new keyHandler();
		bool aot = false;
		int tests = 0;
		int findings = 0;
		List<string> foundKeys = new List<string>();

		public Form1()
		{
			InitializeComponent();

			Load += Form1_Load;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			if(Properties.Settings.Default.file != "") { file = Properties.Settings.Default.file; tb_SaveFile.Text = file; }
			if(Properties.Settings.Default.lastKey != "") { key = Properties.Settings.Default.lastKey;  }
			else { Properties.Settings.Default.lastKey = key; Properties.Settings.Default.Save(); }
			mtb_Text.Text = key;
		}

		public void start()
		{
			gen g = new gen(key);
			if (!File.Exists(file)) { File.Create(file).Close(); }
			int i = 0;

			kh = new keyHandler()
			{
				cornerPos = new Point((int)num_CornerLeft.Value, (int)num_CornerTop.Value),
				tDistance = new Point((int)num_TDistance_X.Value, (int)num_TDistance_Y.Value),
			};

			lbl_TPos.Text = $"{kh.tPosition.X} x {kh.tPosition.Y}";

			//kh.cornerOK = true;

			if (!kh.cornerOK) { Console.WriteLine("ERROR! Corner Not Found!"); run = false; kh.foundCorner.Save("corner.bmp"); return; }
			Corner_Found.Image = kh.foundCorner;
			Refresh();

			while (run)
			{
				tests++;
				key = g.incrementKey(key);

				kh.sendKey(key);

				if (!run) { break; }

				if(i % 20 == 0)
				{
					mtb_Text.Text = key;
					Invoke(new Action(() => setStrings(tests + "", findings + "")));
					Properties.Settings.Default.lastKey = key;
					Properties.Settings.Default.Save();
					kh.testCorner();
				}

				if(kh.cornerOK)
				{
					if (kh.tFound || kh.tButtonOk) { t_Found.Image = kh.foundT; }
					if (kh.tButtonOk) { File.AppendAllText(file, key); findings++; foundKeys.Add(key); }
				}
				else { Console.WriteLine("ERROR! Corner Not Found!"); run = false; kh.foundCorner.Save("corner.bmp"); return; }

				i++;

				
			}

			SystemSounds.Asterisk.Play();
			SystemSounds.Asterisk.Play();
			SystemSounds.Asterisk.Play();
			SystemSounds.Asterisk.Play();
		}
		
		public void setStrings(string tested, string found)
		{
			lbl_TestedKeys.Text = tested;
			lbl_FoundKeys.Text = found;
		}

		private void btn_StartStop_Click(object sender, EventArgs e)
		{			
			if (run)
			{
				run = false;
				btn_StartStop.Text = "Start";
				if(findings > 0) { btn_Found.Show(); }
			}
			else
			{
				btn_Found.Hide();
				timer1.Start();
				file = tb_SaveFile.Text;
				if (!File.Exists(file))
				{
					tb_SaveFile.BackColor = Color.Red;
					tb_SaveFile.Refresh();
					Thread.Sleep(100);
					tb_SaveFile.BackColor = Color.White;
					tb_SaveFile.Refresh();
					Thread.Sleep(100);

					tb_SaveFile.BackColor = Color.Red;
					tb_SaveFile.Refresh();
					Thread.Sleep(100);
					tb_SaveFile.BackColor = Color.White;
					tb_SaveFile.Refresh();
					Thread.Sleep(100);

					tb_SaveFile.BackColor = Color.Red;
					tb_SaveFile.Refresh();
					Thread.Sleep(100);
					tb_SaveFile.BackColor = Color.White;
					tb_SaveFile.Refresh();
					Thread.Sleep(100);


					return;
				}
				Thread.Sleep((int)num_DelaySeconds.Value * 1000);
				SystemSounds.Asterisk.Play();
				SystemSounds.Asterisk.Play();

				run = true;
				btn_StartStop.Text = "Stop";
				Invoke(new Action(() => start()));
			}
		}

		private void tb_SaveFile_DoubleClick(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			if (File.Exists(tb_SaveFile.Text)) { sfd.FileName = tb_SaveFile.Text; }
			if(sfd.ShowDialog() == DialogResult.OK)
			{
				try
				{
					File.Create($"{sfd.FileName}").Close();
					tb_SaveFile.Text = sfd.FileName;
					Properties.Settings.Default.file = tb_SaveFile.Text;
					Properties.Settings.Default.Save();
				}
				catch(Exception ex){ MessageBox.Show(ex.Message); }
			}
		}

		private void cb_AOT_CheckedChanged(object sender, EventArgs e)
		{
			aot = cb_AOT.Checked;
			TopMost = aot;
		}

		private void label12_Click(object sender, EventArgs e)
		{
			cb_AOT.Checked = !cb_AOT.Checked;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (run)
			{
				if(loadPointer % 5 == 0 || loadPointer % 5 == 4) { lbl_Status.Font = new Font(lbl_Status.Font.FontFamily, 16, FontStyle.Regular); lbl_Status.Padding = new Padding(0,0,0,0); }
				else { lbl_Status.Font = new Font(lbl_Status.Font.FontFamily, 14, FontStyle.Regular); lbl_Status.Padding = new Padding(3, 2, 1, 2); }
				lbl_Status.Text = load[loadPointer % 5] + "";
				loadPointer++;
			}
			else
			{
				lbl_Status.Text = redCircle;
				timer1.Stop();
			}
		}

		private void btn_Found_Click(object sender, EventArgs e)
		{
			f_foundkeys f = new f_foundkeys(foundKeys);
			f.ShowDialog();
		}

		private void tb_SaveFile_MouseClick(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Right) { System.Diagnostics.Process.Start(tb_SaveFile.Text); }
		}
	}
}
