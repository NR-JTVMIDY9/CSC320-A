using Symbion;
using System;
using System.Diagnostics;

class Program {
	static void Main() {
		Console.WriteLine("Before:");
		DebugHelper.ShowLoadedAssemblies();
		ILogger logger = LoggerFactory.CreateInstance();
		Console.WriteLine("After:");
		DebugHelper.ShowLoadedAssemblies();
		Console.WriteLine(logger.Source);
		logger.Write("This is the 1st message.", LogType.Information);
		logger.Write("This is the 2nd message.", LogType.Warning);
		logger.Write("This is the 3rd message.", LogType.Error);
		logger.Write("this is the 4th message.");
		logger.Message("Operation completed successfully.");
		logger.Warning("Operation may not have succeeded.");
		logger.Failure("Operation has failed.");
		if (Debugger.IsAttached) {
			Console.Write("Press any key to continue...");
			Console.ReadKey(true);
		}
	}
}
