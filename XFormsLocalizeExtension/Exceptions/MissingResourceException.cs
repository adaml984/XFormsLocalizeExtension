using System;

namespace XFormsLocalizeExtension.Exceptions
{
	public class MissingResourceException : Exception
	{
		public MissingResourceException()
		{
		}

		public MissingResourceException(string message) : base(message)
		{
		}

		public MissingResourceException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}
