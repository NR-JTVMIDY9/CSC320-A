using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

public static class DebugHelper {

	[Conditional("DEBUG")]
	public static void Delay(int duration) {
		Thread.Sleep(duration);
	}
	public static void ShowLoadedAssemblies() {
		AppDomain domain = AppDomain.CurrentDomain;
		Assembly[] assemblies = domain.GetAssemblies();
		foreach (Assembly assembly in assemblies)
			Console.WriteLine(assembly.FullName);
	}

	public static void DisplayProperties(this object obj) {
		PropertyInfo[] props = obj.GetType().GetProperties();
		foreach (PropertyInfo prop in props) Console.WriteLine("{0}={1}",
				prop.Name, prop.GetValue(obj, null));
	}
}