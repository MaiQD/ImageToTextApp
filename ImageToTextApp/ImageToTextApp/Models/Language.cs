using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageToTextApp.Models
{
	public class Language
	{
		public enum enumLanguages
		{
			English = 1,
			Vietnamese= 2,
			Japanese = 3,
			ChineseSimplified = 4,
			ChineseTraditional = 5,
		}
		public Language(int iD, string languageName)
		{
			ID = iD;
			LanguageName = languageName;
		}

		public int ID { get; set; }
		public string LanguageName { get; set; }
	}
}
