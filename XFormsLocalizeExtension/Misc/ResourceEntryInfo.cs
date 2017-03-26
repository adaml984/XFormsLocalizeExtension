using System.Globalization;
using System.Reflection;
using Xamarin.Forms;
using XFormsLocalizeExtension.Helpers;
using XFormsLocalizeExtension.Interfaces;

namespace XFormsLocalizeExtension.Misc
{
	/// <summary>
	/// Simple class for holding data about resource entry
	/// </summary>
	public class ResourceEntryInfo
	{
		public ResourceEntryInfo(string resourcePath)
		{
			ResourceKey = resourcePath.GetResourceKeyFromString();
			Dictionary = resourcePath.GetDictionaryFullName();
			Assembly = AppDomainHelpers.GetAssembly(resourcePath.GetAssemblyNameFromString());
			CurrentCultureInfo = DependencyService.Get<ILocalizationService>().GetCurrentCultureInfo();
		}
		public CultureInfo CurrentCultureInfo { get; }
		public string Dictionary { get; }
		public Assembly Assembly { get; }
		public string ResourceKey { get; }
	}
}
