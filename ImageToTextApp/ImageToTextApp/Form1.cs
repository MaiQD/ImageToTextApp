using IronOcr;
using Patagames.Ocr;
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
			//Installation.LicenseKey = "IRONOCR-MYLICENSE-KEY-1EF01";
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			try
			{
				using (var objOdr =  OcrApi.Create())
				{
					objOdr.Init(language: Patagames.Ocr.Enums.Languages.English);
					using (var bitMap = new Bitmap(picBox.Image))
					{
						string plaintext = objOdr.GetTextFromImage(bitMap);
						this.txtRes.Text = plaintext;
					}
					

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
