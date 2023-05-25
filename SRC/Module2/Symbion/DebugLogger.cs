using System.Diagnostics;

namespace Symbion {
	public class DebugLogger : BaseLogger {
		#region methods
		public override void Write(string message, LogType logType = LogType.Information) {
			Debug.WriteLine($"[{Source}] {logType}(\"{message}\")");
		}
		#endregion
	}
}
