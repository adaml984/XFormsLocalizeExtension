using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace XFormsLocalizeExtension.Helpers
{
	public static class AppDomainHelpers
	{
		public static Assembly[] GetAsseblies()
		{
			var currentdomain = typeof(string).GetTypeInfo().Assembly.GetType("System.AppDomain").GetRuntimeProperty("CurrentDomain").GetMethod.Invoke(null, new object[] { });
			var getassemblies = currentdomain.GetType().GetRuntimeMethod("GetAssemblies", new Type[] { });
			var assemblies = getassemblies.Invoke(currentdomain, new object[] { }) as Assembly[];
			return assemblies;
		}

		public static Assembly GetAssembly(string assemblyName)
		{
			var assemblies = GetAsseblies();
			return assemblies.Where(x => x.GetName().Name.ToLower().Equals(assemblyName.ToLower())).First();
		}
	}
}
