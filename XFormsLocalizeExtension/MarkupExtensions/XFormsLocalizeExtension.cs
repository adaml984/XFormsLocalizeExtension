using System;
using System.Globalization;
using System.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFormsLocalizeExtension.Exceptions;
using XFormsLocalizeExtension.Helpers;
using XFormsLocalizeExtension.Interfaces;
using XFormsLocalizeExtension.Misc;

namespace XFormsLocalizeExtension.MarkupExtensions
{
	[ContentProperty("Key")]
	public class XFormsLocalizeExtension : IMarkupExtension
	{
		public string Key { get; set; }

		#region Implementation of IMarkupExtension

		public object ProvideValue(IServiceProvider serviceProvider)
		{
			if (Key.IsNullOrEmpty())
				throw new MissingResourceException("You should provide Resource key.");

			var resourceInfo = new ResourceEntryInfo(Key);
			var resource = new ResourceManager(resourceInfo.Dictionary, resourceInfo.Assembly);
			var result = resource.GetString(resourceInfo.ResourceKey, resourceInfo.CurrentCultureInfo);
			if (result == null)
				throw new MissingResourceException($"{resourceInfo.ResourceKey} is not found in {resourceInfo.Dictionary} dictionary for {resourceInfo.CurrentCultureInfo.Name} culture.");
			return result;
		}
		#endregion
	}
}