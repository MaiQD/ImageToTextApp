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

		private void cropFromScreenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//this.Visible = false;
			var bmp = SnippingTool.Snip();
			if (bmp != null)
			{
				picBox.Image = bmp;
			}
			//this.Visible = true;
		}

		private void selectImageToolStripMenuItem_Click(object sender, EventArgs e)
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

		private void getFromClipboardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			picBox.Image = Clipboard.GetImage();
		}

		private void exportToTextToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				StartExport();
				var thread = new Thread(() =>
				{
					var ocr = new IronTesseract();
					ocr.SetLanguage((int)readComboBoxSelected(cbxLanguages));
					using (Image img = (Image)picBox.Image?.Clone())
					{
						if (img != null)
						{
							OcrInput ocrInput = new OcrInput(img);
							var text = ocr.Read(ocrInput).Text;
							txtRes.Invoke(new DisplayResultTextDelegate(DisplayResultText), text);
						}
						else
							txtRes.Invoke(new DisplayResultTextDelegate(DisplayResultText), string.Empty);
					}
				});
				thread.IsBackground = true;
				thread.Start();
			}
			catch (Exception ex)
			{
				EndExport();
				MessageBox.Show(ex.Message, "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void copyToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.txtRes.Text))
				return;
			Clipboard.SetText(this.txtRes.Text);
		}

		private void pinWindowMenuItem_Click(object sender, EventArgs e)
		{
			this.TopMost = !this.TopMost;
			ToggleButtonPin();
		}

		#endregion Action Control

		#region Fuction

		private void StartExport()
		{
			selectImageToolStripMenuItem.Enabled = false;
			getFromClipboardToolStripMenuItem.Enabled = false;
			exportToTextToolStripMenuItem.Enabled = false;
			copyToClipboardToolStripMenuItem.Enabled = false;
			progressBar1.Visible = true;
			txtRes.Text = string.Empty;
			//progress bar
			threadProgress = new Thread(RunProgressBar);
			threadProgress.IsBackground = true;
			threadProgress.Start();
		}

		private void EndExport()
		{
			selectImageToolStripMenuItem.Enabled = true;
			getFromClipboardToolStripMenuItem.Enabled = true;
			exportToTextToolStripMenuItem.Enabled = true;
			copyToClipboardToolStripMenuItem.Enabled = true;
			progressBar1.Visible = false;
			progressBar1.Value = 0;
			threadProgress.Abort();
		}

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
				SetValueProgressBar(progressBar1, i);
				Thread.Sleep(100);
			}
		}

		private void ToggleButtonPin()
		{
			if (this.TopMost)
			{
				pinWindowMenuItem.ForeColor = Color.Black;
				pinWindowMenuItem.BackColor = Color.LightGreen;
			}
			else
			{
				pinWindowMenuItem.ForeColor = Color.Snow;
				pinWindowMenuItem.BackColor = Color.Red;
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