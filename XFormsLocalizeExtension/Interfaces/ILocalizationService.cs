using System.Globalization;

namespace XFormsLocalizeExtension.Interfaces
{
	/// <summary>
	/// Interface for obtaining info about Culture
	/// </summary>
	public interface ILocalizationService
	{
		CultureInfo GetCurrentCultureInfo();
		void SetLocale(CultureInfo ci);
	}
}
