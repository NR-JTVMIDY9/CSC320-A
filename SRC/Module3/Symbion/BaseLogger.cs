using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Symbion {
	public abstract class BaseLogger : BaseService, ILogger {
		#region fields
		#region object fields
		private string _source;
		#endregion
		#region static fields
		private static ILogger _instance;
		#endregion
		#endregion
		#region properties
		#region object properties
		public virtual string Source {
			get {
				return _source;
			}
			set {
				Debug.Assert(value != null,
					"Source property cannot be null.");
				_source = value;
			}
		}
		#endregion
		#region static properties
		//public static ILogger Instance {
		//	get {
		//		return _instance ?? (
		//			_instance = LoggerFactory.CreateInstance());
		//	}
		//}
		public static ILogger Instance {
			get {
				if (_instance == null) {
					_instance = ServiceRepository.Get<ILogger>();
					if (_instance == null) {
						_instance = LoggerFactory.CreateInstance();
						_instance.Add();
					}
				}
				return _instance;
			}
		}
		#endregion
		#endregion
		#region constructors
		public BaseLogger() {
			Assembly assembly = Assembly.GetEntryAssembly();
			Source = Path.GetFileNameWithoutExtension(assembly.Location);
		}
		#endregion
		#region methods

		public abstract void Write(string message, LogType logType = LogType.Information);

		public void Message(string message) { Write(message, LogType.Information); }
		public void Warning(string message) { Write(message, LogType.Warning); }
		public void Failure(string message) { Write(message, LogType.Error); }
		#endregion
	}
}
