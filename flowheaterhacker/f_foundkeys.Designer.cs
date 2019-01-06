namespace flowheaterhacker
{
	partial class f_foundkeys
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
			this.btn_Close = new System.Windows.Forms.Button();
			this.lv_Keys = new System.Windows.Forms.ListView();
			this.ch_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_Keys = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// btn_Close
			// 
			this.btn_Close.AutoSize = true;
			this.btn_Close.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btn_Close.Location = new System.Drawing.Point(0, 427);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(560, 23);
			this.btn_Close.TabIndex = 0;
			this.btn_Close.Text = "Close";
			this.btn_Close.UseVisualStyleBackColor = true;
			this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
			// 
			// lv_Keys
			// 
			this.lv_Keys.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_ID,
            this.ch_Keys});
			this.lv_Keys.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lv_Keys.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lv_Keys.FullRowSelect = true;
			this.lv_Keys.GridLines = true;
			this.lv_Keys.Location = new System.Drawing.Point(0, 0);
			this.lv_Keys.Name = "lv_Keys";
			this.lv_Keys.Size = new System.Drawing.Size(560, 427);
			this.lv_Keys.TabIndex = 1;
			this.lv_Keys.UseCompatibleStateImageBehavior = false;
			this.lv_Keys.View = System.Windows.Forms.View.Details;
			this.lv_Keys.DoubleClick += new System.EventHandler(this.lv_Keys_DoubleClick);
			// 
			// ch_ID
			// 
			this.ch_ID.Text = "#";
			this.ch_ID.Width = 30;
			// 
			// ch_Keys
			// 
			this.ch_Keys.Text = "Keys";
			this.ch_Keys.Width = 493;
			// 
			// f_foundkeys
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(560, 450);
			this.Controls.Add(this.lv_Keys);
			this.Controls.Add(this.btn_Close);
			this.Name = "f_foundkeys";
			this.Text = "f_foundkeys";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Close;
		private System.Windows.Forms.ListView lv_Keys;
		private System.Windows.Forms.ColumnHeader ch_ID;
		private System.Windows.Forms.ColumnHeader ch_Keys;
	}
}