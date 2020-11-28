using IronOcr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageToTextApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnGetFromClipboard_Click(object sender, EventArgs e)
		{
			var img = Clipboard.GetImage();
			picBox.Image = img;
			IronOcr.Installation.LicenseKey = "IRONOCR-MYLICENSE-KEY-1EF01";
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			try
			{
				
				var ocr = new IronTesseract();

				using (Image img = picBox.Image)
				{
					OcrInput ocrInput = new OcrInput(img);
					var text = ocr.Read(ocrInput).Text;
					txtRes.Text = text;
				}
				
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}

		private void btnSelectImg_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					picBox.Image = new Bitmap(openFileDialog1.FileName);
				}
				catch (Exception ex)
				{

					MessageBox.Show("Phải chọn file hình ảnh", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				

			}

		}
	}
}
