namespace flowheaterhacker
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.mtb_Text = new System.Windows.Forms.MaskedTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tb_SaveFile = new System.Windows.Forms.TextBox();
			this.btn_StartStop = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.cb_AOT = new System.Windows.Forms.CheckBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.gb_Settings = new System.Windows.Forms.GroupBox();
			this.lbl_TPos = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.num_TDistance_Y = new System.Windows.Forms.NumericUpDown();
			this.num_TDistance_X = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.num_CornerTop = new System.Windows.Forms.NumericUpDown();
			this.num_CornerLeft = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.num_DelaySeconds = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.lbl_TestedKeys = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.lbl_FoundKeys = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
			this.lbl_Status = new System.Windows.Forms.ToolStripStatusLabel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.btn_Found = new System.Windows.Forms.Button();
			this.Corner_Found = new System.Windows.Forms.PictureBox();
			this.Corner = new System.Windows.Forms.PictureBox();
			this.t_Found = new System.Windows.Forms.PictureBox();
			this.t_Off = new System.Windows.Forms.PictureBox();
			this.statusStrip1.SuspendLayout();
			this.gb_Settings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_TDistance_Y)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_TDistance_X)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_CornerTop)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_CornerLeft)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_DelaySeconds)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Corner_Found)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Corner)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.t_Found)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.t_Off)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "start at: ";
			// 
			// mtb_Text
			// 
			this.mtb_Text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mtb_Text.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.mtb_Text.Location = new System.Drawing.Point(77, 29);
			this.mtb_Text.Mask = "AAAAA-AAAAA-AAAAA-AAAAA-AAAAA-AAAAA";
			this.mtb_Text.Name = "mtb_Text";
			this.mtb_Text.Size = new System.Drawing.Size(362, 30);
			this.mtb_Text.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 69);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Save File: ";
			// 
			// tb_SaveFile
			// 
			this.tb_SaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_SaveFile.Cursor = System.Windows.Forms.Cursors.Hand;
			this.tb_SaveFile.Location = new System.Drawing.Point(77, 65);
			this.tb_SaveFile.Name = "tb_SaveFile";
			this.tb_SaveFile.Size = new System.Drawing.Size(362, 20);
			this.tb_SaveFile.TabIndex = 7;
			this.tb_SaveFile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_SaveFile_MouseClick);
			this.tb_SaveFile.DoubleClick += new System.EventHandler(this.tb_SaveFile_DoubleClick);
			// 
			// btn_StartStop
			// 
			this.btn_StartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_StartStop.Location = new System.Drawing.Point(290, 208);
			this.btn_StartStop.Name = "btn_StartStop";
			this.btn_StartStop.Size = new System.Drawing.Size(149, 46);
			this.btn_StartStop.TabIndex = 8;
			this.btn_StartStop.Text = "Start";
			this.btn_StartStop.UseVisualStyleBackColor = true;
			this.btn_StartStop.Click += new System.EventHandler(this.btn_StartStop_Click);
			// 
			// label12
			// 
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label12.AutoSize = true;
			this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label12.Location = new System.Drawing.Point(356, 3);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(73, 13);
			this.label12.TabIndex = 28;
			this.label12.Text = "Always on top";
			this.label12.Click += new System.EventHandler(this.label12_Click);
			// 
			// cb_AOT
			// 
			this.cb_AOT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cb_AOT.AutoSize = true;
			this.cb_AOT.Checked = true;
			this.cb_AOT.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cb_AOT.Location = new System.Drawing.Point(432, 3);
			this.cb_AOT.Name = "cb_AOT";
			this.cb_AOT.Size = new System.Drawing.Size(15, 14);
			this.cb_AOT.TabIndex = 29;
			this.cb_AOT.UseVisualStyleBackColor = true;
			this.cb_AOT.CheckedChanged += new System.EventHandler(this.cb_AOT_CheckedChanged);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbl_TestedKeys,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.lbl_FoundKeys,
            this.toolStripStatusLabel4,
            this.lbl_Status});
			this.statusStrip1.Location = new System.Drawing.Point(0, 266);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(451, 24);
			this.statusStrip1.TabIndex = 30;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// gb_Settings
			// 
			this.gb_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.gb_Settings.BackColor = System.Drawing.Color.Transparent;
			this.gb_Settings.Controls.Add(this.lbl_TPos);
			this.gb_Settings.Controls.Add(this.label9);
			this.gb_Settings.Controls.Add(this.num_TDistance_Y);
			this.gb_Settings.Controls.Add(this.num_TDistance_X);
			this.gb_Settings.Controls.Add(this.label8);
			this.gb_Settings.Controls.Add(this.num_CornerTop);
			this.gb_Settings.Controls.Add(this.num_CornerLeft);
			this.gb_Settings.Controls.Add(this.label7);
			this.gb_Settings.Controls.Add(this.label6);
			this.gb_Settings.Controls.Add(this.num_DelaySeconds);
			this.gb_Settings.Controls.Add(this.label5);
			this.gb_Settings.Location = new System.Drawing.Point(12, 90);
			this.gb_Settings.Name = "gb_Settings";
			this.gb_Settings.Size = new System.Drawing.Size(268, 112);
			this.gb_Settings.TabIndex = 31;
			this.gb_Settings.TabStop = false;
			this.gb_Settings.Text = "Settings";
			// 
			// lbl_TPos
			// 
			this.lbl_TPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbl_TPos.AutoSize = true;
			this.lbl_TPos.Location = new System.Drawing.Point(116, 93);
			this.lbl_TPos.Name = "lbl_TPos";
			this.lbl_TPos.Size = new System.Drawing.Size(30, 13);
			this.lbl_TPos.TabIndex = 30;
			this.lbl_TPos.Text = "0 x 0";
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(20, 93);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(72, 13);
			this.label9.TabIndex = 29;
			this.label9.Text = "Position of T: ";
			// 
			// num_TDistance_Y
			// 
			this.num_TDistance_Y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.num_TDistance_Y.Location = new System.Drawing.Point(190, 68);
			this.num_TDistance_Y.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.num_TDistance_Y.Name = "num_TDistance_Y";
			this.num_TDistance_Y.Size = new System.Drawing.Size(65, 20);
			this.num_TDistance_Y.TabIndex = 28;
			this.num_TDistance_Y.Value = new decimal(new int[] {
            548,
            0,
            0,
            0});
			// 
			// num_TDistance_X
			// 
			this.num_TDistance_X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.num_TDistance_X.Location = new System.Drawing.Point(119, 68);
			this.num_TDistance_X.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.num_TDistance_X.Name = "num_TDistance_X";
			this.num_TDistance_X.Size = new System.Drawing.Size(65, 20);
			this.num_TDistance_X.TabIndex = 27;
			this.num_TDistance_X.Value = new decimal(new int[] {
            176,
            0,
            0,
            0});
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(20, 70);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(84, 13);
			this.label8.TabIndex = 26;
			this.label8.Text = "Difference to T: ";
			// 
			// num_CornerTop
			// 
			this.num_CornerTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.num_CornerTop.Location = new System.Drawing.Point(190, 43);
			this.num_CornerTop.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.num_CornerTop.Name = "num_CornerTop";
			this.num_CornerTop.Size = new System.Drawing.Size(65, 20);
			this.num_CornerTop.TabIndex = 25;
			this.num_CornerTop.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
			// 
			// num_CornerLeft
			// 
			this.num_CornerLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.num_CornerLeft.Location = new System.Drawing.Point(119, 43);
			this.num_CornerLeft.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.num_CornerLeft.Name = "num_CornerLeft";
			this.num_CornerLeft.Size = new System.Drawing.Size(65, 20);
			this.num_CornerLeft.TabIndex = 24;
			this.num_CornerLeft.Value = new decimal(new int[] {
            564,
            0,
            0,
            0});
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(20, 45);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(93, 13);
			this.label7.TabIndex = 23;
			this.label7.Text = "Corner of Screen: ";
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(190, 20);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(47, 13);
			this.label6.TabIndex = 22;
			this.label6.Text = "seconds";
			// 
			// num_DelaySeconds
			// 
			this.num_DelaySeconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.num_DelaySeconds.Location = new System.Drawing.Point(119, 18);
			this.num_DelaySeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.num_DelaySeconds.Name = "num_DelaySeconds";
			this.num_DelaySeconds.Size = new System.Drawing.Size(65, 20);
			this.num_DelaySeconds.TabIndex = 21;
			this.num_DelaySeconds.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(20, 20);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 13);
			this.label5.TabIndex = 20;
			this.label5.Text = "Delay: ";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.Corner_Found);
			this.groupBox1.Controls.Add(this.Corner);
			this.groupBox1.Controls.Add(this.t_Found);
			this.groupBox1.Controls.Add(this.t_Off);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(290, 90);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(149, 112);
			this.groupBox1.TabIndex = 32;
			this.groupBox1.TabStop = false;
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(103, 9);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(37, 13);
			this.label11.TabIndex = 31;
			this.label11.Text = "corner";
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(78, 9);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(10, 13);
			this.label10.TabIndex = 30;
			this.label10.Text = "t";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 13);
			this.label3.TabIndex = 29;
			this.label3.Text = "Actually Is: ";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 13);
			this.label2.TabIndex = 28;
			this.label2.Text = "Should Be: ";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(126, 19);
			this.toolStripStatusLabel1.Text = "Keys Tested: ";
			// 
			// lbl_TestedKeys
			// 
			this.lbl_TestedKeys.Name = "lbl_TestedKeys";
			this.lbl_TestedKeys.Size = new System.Drawing.Size(18, 19);
			this.lbl_TestedKeys.Text = "0";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(18, 19);
			this.toolStripStatusLabel2.Text = "|";
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(117, 19);
			this.toolStripStatusLabel3.Text = "Keys Found: ";
			// 
			// lbl_FoundKeys
			// 
			this.lbl_FoundKeys.Name = "lbl_FoundKeys";
			this.lbl_FoundKeys.Size = new System.Drawing.Size(18, 19);
			this.lbl_FoundKeys.Text = "0";
			// 
			// toolStripStatusLabel4
			// 
			this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
			this.toolStripStatusLabel4.Size = new System.Drawing.Size(120, 19);
			this.toolStripStatusLabel4.Spring = true;
			// 
			// lbl_Status
			// 
			this.lbl_Status.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lbl_Status.ForeColor = System.Drawing.Color.Red;
			this.lbl_Status.Name = "lbl_Status";
			this.lbl_Status.Size = new System.Drawing.Size(19, 19);
			this.lbl_Status.Text = "⬤";
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// btn_Found
			// 
			this.btn_Found.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Found.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn_Found.Location = new System.Drawing.Point(12, 221);
			this.btn_Found.Name = "btn_Found";
			this.btn_Found.Size = new System.Drawing.Size(126, 33);
			this.btn_Found.TabIndex = 33;
			this.btn_Found.Text = "Show found keys";
			this.btn_Found.UseVisualStyleBackColor = true;
			this.btn_Found.Visible = false;
			this.btn_Found.Click += new System.EventHandler(this.btn_Found_Click);
			// 
			// Corner_Found
			// 
			this.Corner_Found.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Corner_Found.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Corner_Found.Location = new System.Drawing.Point(109, 73);
			this.Corner_Found.Name = "Corner_Found";
			this.Corner_Found.Size = new System.Drawing.Size(24, 24);
			this.Corner_Found.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.Corner_Found.TabIndex = 35;
			this.Corner_Found.TabStop = false;
			// 
			// Corner
			// 
			this.Corner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Corner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Corner.Image = global::flowheaterhacker.Properties.Resources.corner;
			this.Corner.Location = new System.Drawing.Point(109, 31);
			this.Corner.Name = "Corner";
			this.Corner.Size = new System.Drawing.Size(24, 24);
			this.Corner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.Corner.TabIndex = 34;
			this.Corner.TabStop = false;
			// 
			// t_Found
			// 
			this.t_Found.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.t_Found.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.t_Found.Location = new System.Drawing.Point(70, 67);
			this.t_Found.Name = "t_Found";
			this.t_Found.Size = new System.Drawing.Size(20, 36);
			this.t_Found.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.t_Found.TabIndex = 33;
			this.t_Found.TabStop = false;
			// 
			// t_Off
			// 
			this.t_Off.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.t_Off.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.t_Off.Image = global::flowheaterhacker.Properties.Resources.t_off;
			this.t_Off.Location = new System.Drawing.Point(70, 25);
			this.t_Off.Name = "t_Off";
			this.t_Off.Size = new System.Drawing.Size(20, 36);
			this.t_Off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.t_Off.TabIndex = 32;
			this.t_Off.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(451, 290);
			this.Controls.Add(this.btn_Found);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gb_Settings);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.cb_AOT);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.btn_StartStop);
			this.Controls.Add(this.tb_SaveFile);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.mtb_Text);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "FlowHeater Cracker";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.gb_Settings.ResumeLayout(false);
			this.gb_Settings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_TDistance_Y)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_TDistance_X)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_CornerTop)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_CornerLeft)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_DelaySeconds)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Corner_Found)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Corner)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.t_Found)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.t_Off)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MaskedTextBox mtb_Text;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tb_SaveFile;
		private System.Windows.Forms.Button btn_StartStop;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.CheckBox cb_AOT;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.GroupBox gb_Settings;
		private System.Windows.Forms.Label lbl_TPos;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.NumericUpDown num_TDistance_Y;
		private System.Windows.Forms.NumericUpDown num_TDistance_X;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown num_CornerTop;
		private System.Windows.Forms.NumericUpDown num_CornerLeft;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown num_DelaySeconds;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox Corner_Found;
		private System.Windows.Forms.PictureBox Corner;
		private System.Windows.Forms.PictureBox t_Found;
		private System.Windows.Forms.PictureBox t_Off;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel lbl_TestedKeys;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
		private System.Windows.Forms.ToolStripStatusLabel lbl_FoundKeys;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
		private System.Windows.Forms.ToolStripStatusLabel lbl_Status;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btn_Found;
	}
}

