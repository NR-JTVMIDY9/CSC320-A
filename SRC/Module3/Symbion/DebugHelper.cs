using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;

namespace Symbion {
	public static class DebugHelper {
		[Conditional("DEBUG")]
		public static void Delay(int milliseconds) {
			Thread.Sleep(milliseconds);
		}

		public static void ShowLoadedAssemblies() {
			AppDomain domain = AppDomain.CurrentDomain;
			Assembly[] assemblies = domain.GetAssemblies();
			foreach (Assembly assembly in assemblies)
				Console.WriteLine(assembly.FullName);
		}

		public static void DisplayProperties(this object obj) {
			PropertyInfo[] properties = obj.GetType().GetProperties();
			foreach (PropertyInfo property in properties)
				if (property.GetIndexParameters().Length == 0)
					Console.WriteLine("{0}={1}",
						property.Name, property.GetValue(obj, null));
		}
	}
}
