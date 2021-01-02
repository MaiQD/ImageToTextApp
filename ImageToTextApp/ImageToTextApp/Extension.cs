using IronOcr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ImageToTextApp.Models.Language;

namespace ImageToTextApp
{
	public static class Extension
	{
		public static void SetLanguage(this IronTesseract ocr, int selectedValue)
		{
			switch ((enumLanguages)selectedValue)
			{
				case enumLanguages.English:
					ocr.Language = OcrLanguage.English;
					break;
				case enumLanguages.Vietnamese:
					ocr.Language = OcrLanguage.Vietnamese;
					break;
				case enumLanguages.Japanese:
					ocr.Language = OcrLanguage.Japanese;
					break;
				case enumLanguages.ChineseSimplified:
					ocr.Language = OcrLanguage.ChineseSimplified;
					break;
				case enumLanguages.ChineseTraditional:
					ocr.Language = OcrLanguage.ChineseTraditional;
					break;
				default:
					ocr.Language = OcrLanguage.English;
					break;
			}
			
		}
	}
}
