using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFormsLocalizeExtension.Helpers
{
	public static class StringHelpers
	{
		public static string GetAssemblyNameFromString(this string @string)
		{
			int lastIdx = @string.LastIndexOf('.');
			@string = @string.Substring(0, lastIdx);
			lastIdx = @string.LastIndexOf('.');
			return @string.Substring(0, lastIdx);
		}

		public static string GetResourceKeyFromString(this string @string)
		{
			return @string.Split(':').Last();
		}

		/// <summary>
		/// "SampleApp.Resx.MainPageLocale";
		/// </summary>
		/// <param name="string"></param>
		/// <returns></returns>
		public static string GetDictionaryFullName(this string @string)
		{
			return @string.Split(':').First();
		}
		public static bool IsNullOrEmpty(this string @string)
		{
			return String.IsNullOrEmpty(@string);
		}
	}
}
