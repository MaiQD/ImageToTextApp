using ImageToTextApp.Models;
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
		private List<Language> _languages; 
		public Form1()
		{
			InitializeComponent();
			_languages =  new List<Language>
			{
				new	Language(1, "English"),
				new Language(2, "Vietnamese"),
				new Language(3, "Japanese"),
				new Language(4, "Chinese Simplified"),
				new Language(4, "Chinese Traditional")
			};
			SetDDLLanguages();
		}

		private void btnGetFromClipboard_Click(object sender, EventArgs e)
		{
			var img = Clipboard.GetImage();
			picBox.Image = img;
			//IronOcr.Installation.LicenseKey = "IRONOCR-MYLICENSE-KEY-1EF01";
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			try
			{
				txtRes.BeginInvoke(new Action(() =>
				{
					var ocr = new IronTesseract();
					ocr.SetLanguage((int)this.cbxLanguages.SelectedValue);
					using (Image img = (Image)picBox.Image.Clone())
					{
						OcrInput ocrInput = new OcrInput(img);
						var text = ocr.Read(ocrInput).Text;
						txtRes.Text = text;
					}
				}));
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

		private void picBox_Click(object sender, EventArgs e)
		{

		}

		private void btnPin_Click(object sender, EventArgs e)
		{
			this.TopMost = !this.TopMost;
			ToggleButtonPin();

		}
		private void ToggleButtonPin()
		{
			if (this.TopMost)
			{
				btnPin.ForeColor = Color.Black;
				btnPin.BackColor = Color.LightGreen;
			}
			else
			{
				btnPin.ForeColor = Color.Snow;
				btnPin.BackColor = Color.Red;
			}
		}
		#region Fuction

		private void btnCopyToClipboard_Click(object sender, EventArgs e) => Clipboard.SetText(this.txtRes.Text);
		private void SetDDLLanguages()
		{
			cbxLanguages.DataSource = _languages;
			cbxLanguages.DisplayMember = "LanguageName";
			cbxLanguages.ValueMember = "ID";
		}
		
		#endregion
	}
}
