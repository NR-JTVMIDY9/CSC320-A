using System;
using System.Reflection;

public static class DebugHelper {
	public static void ShowLoadedAssemblies() {
		AppDomain domain = AppDomain.CurrentDomain;
		Assembly[] assemblies = domain.GetAssemblies();
		foreach (Assembly assembly in assemblies)
			Console.WriteLine(assembly.FullName);
	}
}