using ImageToTextApp.Models;
using IronOcr;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ImageToTextApp
{
	public partial class frmMain : Form
	{
		private List<Language> _languages;
		private Thread threadProgress;
		public frmMain()
		{
			InitializeComponent();
			_languages = new List<Language>
			{
				new Language(1, "English"),
				new Language(2, "Vietnamese"),
				new Language(3, "Japanese"),
				new Language(4, "Chinese Simplified"),
				new Language(4, "Chinese Traditional")
			};
			SetDDLLanguages();
			
		}

		#region Action Control

		private void btnGetFromClipboard_Click(object sender, EventArgs e) => picBox.Image = Clipboard.GetImage();

		private void btnExport_Click(object sender, EventArgs e)
		{
			try
			{
				StartExport();
				var thread = new Thread(() =>
				{
					var ocr = new IronTesseract();
					ocr.SetLanguage((int)readComboBoxSelected(cbxLanguages));
					using (Image img = (Image)picBox.Image.Clone())
					{
						OcrInput ocrInput = new OcrInput(img);
						var text = ocr.Read(ocrInput).Text;
						txtRes.Invoke(new DisplayResultTextDelegate(DisplayResultText), text);
					}
				});
				thread.IsBackground = true;
				thread.Start();
			}
			catch (Exception ex)
			{
				progressBar1.Visible = false;
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

		private void btnPin_Click(object sender, EventArgs e)
		{
			this.TopMost = !this.TopMost;
			ToggleButtonPin();
		}

		#endregion Action Control

		#region Fuction

		private void StartExport()
		{
			btnSelectImg.Enabled = false;
			btnGetFromClipboard.Enabled = false;
			btnExport.Enabled = false;
			btnCopyToClipboard.Enabled = false;
			progressBar1.Visible = true;
			txtRes.Text = string.Empty;
			//progress bar
			threadProgress = new Thread(RunProgressBar);
			threadProgress.IsBackground = true;
			threadProgress.Start();

		}

		private void EndExport()
		{
			btnSelectImg.Enabled = true;
			btnGetFromClipboard.Enabled = true;
			btnExport.Enabled = true;
			btnCopyToClipboard.Enabled = true;
			progressBar1.Visible = false;
			progressBar1.Value = 0;
			threadProgress.Abort();
		}

		private void btnCopyToClipboard_Click(object sender, EventArgs e) => Clipboard.SetText(this.txtRes.Text);

		private void SetDDLLanguages()
		{
			cbxLanguages.DataSource = _languages;
			cbxLanguages.DisplayMember = "LanguageName";
			cbxLanguages.ValueMember = "ID";
		}

		private void RunProgressBar()
		{
			
			for (int i = 0; i < 100; i++)
			{
				SetValueProgressBar(progressBar1,i);
				Thread.Sleep(100);
			}	
				

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

		#endregion Fuction

		#region Thread

		public static string readControlText(Control varControl)
		{
			if (varControl.InvokeRequired)
			{
				return (string)varControl.Invoke(
				  new Func<String>(() => readControlText(varControl))
				);
			}
			else
			{
				return varControl.Text;
			}
		}

		public static object readComboBoxSelected(ComboBox listbox)
		{
			if (listbox.InvokeRequired)
			{
				return (object)listbox.Invoke(
				  new Func<object>(() => readComboBoxSelected(listbox))
				);
			}
			else return listbox.SelectedValue;
		}
		public static object SetValueProgressBar(ProgressBar control, int value)
		{
			if (control.InvokeRequired)
			{
				return control.Invoke(new Func<object>(() => SetValueProgressBar(control, value)));
			}
			else
			{
				control.Value = value;
				return null;
			}	
		}
		private delegate void DisplayResultTextDelegate(string text);

		private void DisplayResultText(string text)
		{
			txtRes.Text = text;
			EndExport();
		}

		#endregion Thread
	}
}