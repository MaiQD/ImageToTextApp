
namespace ImageToTextApp
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.picBox = new System.Windows.Forms.PictureBox();
			this.btnSelectImg = new System.Windows.Forms.Button();
			this.btnGetFromClipboard = new System.Windows.Forms.Button();
			this.btnExport = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.picBox);
			this.panel1.Location = new System.Drawing.Point(12, 100);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(408, 503);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.textBox1);
			this.panel2.Location = new System.Drawing.Point(431, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(408, 591);
			this.panel2.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btnExport);
			this.panel3.Controls.Add(this.btnGetFromClipboard);
			this.panel3.Controls.Add(this.btnSelectImg);
			this.panel3.Location = new System.Drawing.Point(12, 12);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(408, 82);
			this.panel3.TabIndex = 2;
			// 
			// picBox
			// 
			this.picBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picBox.Location = new System.Drawing.Point(0, 0);
			this.picBox.Name = "picBox";
			this.picBox.Size = new System.Drawing.Size(408, 503);
			this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picBox.TabIndex = 0;
			this.picBox.TabStop = false;
			// 
			// btnSelectImg
			// 
			this.btnSelectImg.Location = new System.Drawing.Point(9, 14);
			this.btnSelectImg.Name = "btnSelectImg";
			this.btnSelectImg.Size = new System.Drawing.Size(123, 53);
			this.btnSelectImg.TabIndex = 0;
			this.btnSelectImg.Text = "Select Image";
			this.btnSelectImg.UseVisualStyleBackColor = true;
			// 
			// btnGetFromClipboard
			// 
			this.btnGetFromClipboard.Location = new System.Drawing.Point(138, 14);
			this.btnGetFromClipboard.Name = "btnGetFromClipboard";
			this.btnGetFromClipboard.Size = new System.Drawing.Size(123, 53);
			this.btnGetFromClipboard.TabIndex = 1;
			this.btnGetFromClipboard.Text = "Get from Clipboard";
			this.btnGetFromClipboard.UseVisualStyleBackColor = true;
			this.btnGetFromClipboard.Click += new System.EventHandler(this.btnGetFromClipboard_Click);
			// 
			// btnExport
			// 
			this.btnExport.Location = new System.Drawing.Point(267, 14);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(123, 53);
			this.btnExport.TabIndex = 2;
			this.btnExport.Text = "Export to Text";
			this.btnExport.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Location = new System.Drawing.Point(0, 0);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(408, 591);
			this.textBox1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(856, 615);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox picBox;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.Button btnGetFromClipboard;
		private System.Windows.Forms.Button btnSelectImg;
		private System.Windows.Forms.TextBox textBox1;
	}
}

