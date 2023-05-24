using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Symbion {
	public class DebugLogger : BaseLogger {
		public override void Write(string message, LogType logType = LogType.Information) {
			Debug.WriteLine($"[{Source}] {logType}(\"{message}\")");
		}

	}
}