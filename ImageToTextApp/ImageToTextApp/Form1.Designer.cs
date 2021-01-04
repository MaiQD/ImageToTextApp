
namespace ImageToTextApp
{
	partial class frmMain
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.picBox = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.cbxLanguages = new System.Windows.Forms.ComboBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.getFromClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cropFromScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exportToTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pinWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel2 = new System.Windows.Forms.Panel();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.txtRes = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
			this.panel3.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.picBox);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(427, 467);
			this.panel1.TabIndex = 0;
			// 
			// picBox
			// 
			this.picBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picBox.Location = new System.Drawing.Point(0, 69);
			this.picBox.Name = "picBox";
			this.picBox.Size = new System.Drawing.Size(427, 398);
			this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picBox.TabIndex = 0;
			this.picBox.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.cbxLanguages);
			this.panel3.Controls.Add(this.menuStrip1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(427, 69);
			this.panel3.TabIndex = 2;
			// 
			// cbxLanguages
			// 
			this.cbxLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxLanguages.FormattingEnabled = true;
			this.cbxLanguages.Location = new System.Drawing.Point(3, 31);
			this.cbxLanguages.Name = "cbxLanguages";
			this.cbxLanguages.Size = new System.Drawing.Size(424, 24);
			this.cbxLanguages.TabIndex = 5;
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exportToTextToolStripMenuItem,
            this.copyToClipboardToolStripMenuItem,
            this.pinWindowMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.menuStrip1.Size = new System.Drawing.Size(427, 28);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectImageToolStripMenuItem,
            this.getFromClipboardToolStripMenuItem,
            this.cropFromScreenToolStripMenuItem,
            this.toolStripSeparator1});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
			this.fileToolStripMenuItem.Text = "&File";
			this.fileToolStripMenuItem.Click += new System.EventHandler(this.copyToClipboardToolStripMenuItem_Click);
			// 
			// selectImageToolStripMenuItem
			// 
			this.selectImageToolStripMenuItem.Name = "selectImageToolStripMenuItem";
			this.selectImageToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.selectImageToolStripMenuItem.Text = "Select Image";
			this.selectImageToolStripMenuItem.Click += new System.EventHandler(this.selectImageToolStripMenuItem_Click);
			// 
			// getFromClipboardToolStripMenuItem
			// 
			this.getFromClipboardToolStripMenuItem.Name = "getFromClipboardToolStripMenuItem";
			this.getFromClipboardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.getFromClipboardToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
			this.getFromClipboardToolStripMenuItem.Text = "Get from clipboard";
			this.getFromClipboardToolStripMenuItem.Click += new System.EventHandler(this.getFromClipboardToolStripMenuItem_Click);
			// 
			// cropFromScreenToolStripMenuItem
			// 
			this.cropFromScreenToolStripMenuItem.Name = "cropFromScreenToolStripMenuItem";
			this.cropFromScreenToolStripMenuItem.ShortcutKeyDisplayString = "";
			this.cropFromScreenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.cropFromScreenToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
			this.cropFromScreenToolStripMenuItem.Text = "Crop from screen";
			this.cropFromScreenToolStripMenuItem.Click += new System.EventHandler(this.cropFromScreenToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
			// 
			// exportToTextToolStripMenuItem
			// 
			this.exportToTextToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
			this.exportToTextToolStripMenuItem.Name = "exportToTextToolStripMenuItem";
			this.exportToTextToolStripMenuItem.ShortcutKeyDisplayString = "";
			this.exportToTextToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
			this.exportToTextToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
			this.exportToTextToolStripMenuItem.Text = "&Export to text";
			this.exportToTextToolStripMenuItem.Click += new System.EventHandler(this.exportToTextToolStripMenuItem_Click);
			// 
			// pinWindowMenuItem
			// 
			this.pinWindowMenuItem.BackColor = System.Drawing.Color.Red;
			this.pinWindowMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.pinWindowMenuItem.ForeColor = System.Drawing.Color.Snow;
			this.pinWindowMenuItem.Name = "pinWindowMenuItem";
			this.pinWindowMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.pinWindowMenuItem.Size = new System.Drawing.Size(104, 24);
			this.pinWindowMenuItem.Text = "Pin window";
			this.pinWindowMenuItem.Click += new System.EventHandler(this.pinWindowMenuItem_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.progressBar1);
			this.panel2.Controls.Add(this.txtRes);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 467);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(427, 240);
			this.panel2.TabIndex = 1;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(0, 0);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(427, 23);
			this.progressBar1.TabIndex = 1;
			this.progressBar1.Value = 75;
			this.progressBar1.Visible = false;
			// 
			// txtRes
			// 
			this.txtRes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtRes.Location = new System.Drawing.Point(0, 0);
			this.txtRes.Multiline = true;
			this.txtRes.Name = "txtRes";
			this.txtRes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtRes.Size = new System.Drawing.Size(427, 240);
			this.txtRes.TabIndex = 0;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// copyToClipboardToolStripMenuItem
			// 
			this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
			this.copyToClipboardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
			this.copyToClipboardToolStripMenuItem.Text = "Copy text";
			this.copyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyToClipboardToolStripMenuItem_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(427, 707);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Image to text app";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox picBox;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox txtRes;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ComboBox cbxLanguages;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem selectImageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem getFromClipboardToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cropFromScreenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportToTextToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pinWindowMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
	}
}

