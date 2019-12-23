namespace Atlas
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FileSave = new System.Windows.Forms.Button();
            this.FileLoad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GridUpdate = new System.Windows.Forms.Button();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.RectangleSelection = new System.Windows.Forms.GroupBox();
            this.XSizeS = new System.Windows.Forms.TextBox();
            this.YSizeS = new System.Windows.Forms.TextBox();
            this.XSizeF = new System.Windows.Forms.TextBox();
            this.YSizeF = new System.Windows.Forms.TextBox();
            this.XSizeSTxt = new System.Windows.Forms.Label();
            this.YSizeSTxt = new System.Windows.Forms.Label();
            this.XSizeFTxt = new System.Windows.Forms.Label();
            this.YSizeTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.RectangleSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.RectangleSelection);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(855, 517);
            this.splitContainer1.SplitterDistance = 539;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(539, 517);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.splitContainer2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 307);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 210);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "GridEditor";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 16);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.pictureBox2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.textBox3);
            this.splitContainer2.Size = new System.Drawing.Size(306, 191);
            this.splitContainer2.SplitterDistance = 142;
            this.splitContainer2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 191);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(0, 0);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(160, 191);
            this.textBox3.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FileSave);
            this.groupBox2.Controls.Add(this.FileLoad);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 91);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Handling";
            // 
            // FileSave
            // 
            this.FileSave.Location = new System.Drawing.Point(6, 48);
            this.FileSave.Name = "FileSave";
            this.FileSave.Size = new System.Drawing.Size(75, 23);
            this.FileSave.TabIndex = 1;
            this.FileSave.Text = "Save";
            this.FileSave.UseVisualStyleBackColor = true;
            // 
            // FileLoad
            // 
            this.FileLoad.Location = new System.Drawing.Point(6, 19);
            this.FileLoad.Name = "FileLoad";
            this.FileLoad.Size = new System.Drawing.Size(75, 23);
            this.FileLoad.TabIndex = 0;
            this.FileLoad.Text = "Load";
            this.FileLoad.UseVisualStyleBackColor = true;
            this.FileLoad.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.GridUpdate);
            this.groupBox1.Controls.Add(this.XTextBox);
            this.groupBox1.Controls.Add(this.YTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 84);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X size";
            // 
            // GridUpdate
            // 
            this.GridUpdate.Location = new System.Drawing.Point(6, 19);
            this.GridUpdate.Name = "GridUpdate";
            this.GridUpdate.Size = new System.Drawing.Size(75, 23);
            this.GridUpdate.TabIndex = 2;
            this.GridUpdate.Text = "Update";
            this.GridUpdate.UseVisualStyleBackColor = true;
            this.GridUpdate.Click += new System.EventHandler(this.Button1_Click);
            // 
            // XTextBox
            // 
            this.XTextBox.Location = new System.Drawing.Point(176, 19);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.Size = new System.Drawing.Size(100, 20);
            this.XTextBox.TabIndex = 0;
            this.XTextBox.Text = "16";
            // 
            // YTextBox
            // 
            this.YTextBox.Location = new System.Drawing.Point(176, 45);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.Size = new System.Drawing.Size(100, 20);
            this.YTextBox.TabIndex = 1;
            this.YTextBox.Text = "16";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // RectangleSelection
            // 
            this.RectangleSelection.Controls.Add(this.YSizeTxt);
            this.RectangleSelection.Controls.Add(this.XSizeFTxt);
            this.RectangleSelection.Controls.Add(this.YSizeSTxt);
            this.RectangleSelection.Controls.Add(this.XSizeSTxt);
            this.RectangleSelection.Controls.Add(this.YSizeF);
            this.RectangleSelection.Controls.Add(this.XSizeF);
            this.RectangleSelection.Controls.Add(this.YSizeS);
            this.RectangleSelection.Controls.Add(this.XSizeS);
            this.RectangleSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.RectangleSelection.Location = new System.Drawing.Point(0, 175);
            this.RectangleSelection.Name = "RectangleSelection";
            this.RectangleSelection.Size = new System.Drawing.Size(312, 120);
            this.RectangleSelection.TabIndex = 5;
            this.RectangleSelection.TabStop = false;
            this.RectangleSelection.Text = "RectangleSelection";
            // 
            // XSizeS
            // 
            this.XSizeS.Location = new System.Drawing.Point(53, 20);
            this.XSizeS.Name = "XSizeS";
            this.XSizeS.Size = new System.Drawing.Size(100, 20);
            this.XSizeS.TabIndex = 0;
            // 
            // YSizeS
            // 
            this.YSizeS.Location = new System.Drawing.Point(209, 20);
            this.YSizeS.Name = "YSizeS";
            this.YSizeS.Size = new System.Drawing.Size(100, 20);
            this.YSizeS.TabIndex = 1;
            // 
            // XSizeF
            // 
            this.XSizeF.Location = new System.Drawing.Point(53, 76);
            this.XSizeF.Name = "XSizeF";
            this.XSizeF.Size = new System.Drawing.Size(100, 20);
            this.XSizeF.TabIndex = 2;
            this.XSizeF.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // YSizeF
            // 
            this.YSizeF.Location = new System.Drawing.Point(209, 76);
            this.YSizeF.Name = "YSizeF";
            this.YSizeF.Size = new System.Drawing.Size(100, 20);
            this.YSizeF.TabIndex = 3;
            // 
            // XSizeSTxt
            // 
            this.XSizeSTxt.AutoSize = true;
            this.XSizeSTxt.Location = new System.Drawing.Point(6, 23);
            this.XSizeSTxt.Name = "XSizeSTxt";
            this.XSizeSTxt.Size = new System.Drawing.Size(41, 13);
            this.XSizeSTxt.TabIndex = 4;
            this.XSizeSTxt.Text = "XSizeS";
            // 
            // YSizeSTxt
            // 
            this.YSizeSTxt.AutoSize = true;
            this.YSizeSTxt.Location = new System.Drawing.Point(162, 23);
            this.YSizeSTxt.Name = "YSizeSTxt";
            this.YSizeSTxt.Size = new System.Drawing.Size(41, 13);
            this.YSizeSTxt.TabIndex = 5;
            this.YSizeSTxt.Text = "YSizeS";
            // 
            // XSizeFTxt
            // 
            this.XSizeFTxt.AutoSize = true;
            this.XSizeFTxt.Location = new System.Drawing.Point(11, 82);
            this.XSizeFTxt.Name = "XSizeFTxt";
            this.XSizeFTxt.Size = new System.Drawing.Size(40, 13);
            this.XSizeFTxt.TabIndex = 6;
            this.XSizeFTxt.Text = "XSizeF";
            // 
            // YSizeTxt
            // 
            this.YSizeTxt.AutoSize = true;
            this.YSizeTxt.Location = new System.Drawing.Point(167, 81);
            this.YSizeTxt.Name = "YSizeTxt";
            this.YSizeTxt.Size = new System.Drawing.Size(40, 13);
            this.YSizeTxt.TabIndex = 7;
            this.YSizeTxt.Text = "YSizeF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 517);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.RectangleSelection.ResumeLayout(false);
            this.RectangleSelection.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button FileSave;
		private System.Windows.Forms.Button FileLoad;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button GridUpdate;
		private System.Windows.Forms.TextBox XTextBox;
		private System.Windows.Forms.TextBox YTextBox;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox RectangleSelection;
        private System.Windows.Forms.Label YSizeSTxt;
        private System.Windows.Forms.Label XSizeSTxt;
        private System.Windows.Forms.TextBox YSizeF;
        private System.Windows.Forms.TextBox XSizeF;
        private System.Windows.Forms.TextBox YSizeS;
        private System.Windows.Forms.TextBox XSizeS;
        private System.Windows.Forms.Label YSizeTxt;
        private System.Windows.Forms.Label XSizeFTxt;
    }
}

