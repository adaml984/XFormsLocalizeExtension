using System.Globalization;
using XFormsLocalizeExtension.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(XFormsLocalizeExtension.UWP.Services.LocalizationService))]
namespace XFormsLocalizeExtension.UWP.Services
{
	public class LocalizationService : ILocalizationService
	{
		public CultureInfo GetCurrentCultureInfo()
		{
			return CultureInfo.CurrentCulture;
		}

		public void SetLocale(CultureInfo ci)
		{
			CultureInfo.CurrentCulture = ci;
		}
	}
}
