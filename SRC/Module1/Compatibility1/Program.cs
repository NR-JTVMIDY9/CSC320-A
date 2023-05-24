using Symbion;
using Symbion.Loggers;
using System;
using System.Collections;

namespace Compatibility1 {
	public static class LoggerExtension {
		static void Log1(DebugLogger logger) {
			logger.Message("Hello!");
			logger.Message("Goodbye!");
		}

		static void Log2(BaseLogger logger) {
			logger.Message("Hello!");
			logger.Message("Goodbye!");
		}

		static void Log3(ILogger logger) {
			logger.Message("Hello!");
			logger.Message("Goodbye!");
		}

		public static void Log4(this ILogger logger) {
			logger.Message("Hello!");
			logger.Message("Goodbye!");
		}

		public static void Log5(dynamic logger) {
			logger.Message("Hello!");
			logger.Message("Goodbye!");
		}

		//static object Copy(ICloneable obj) {
		//	return obj.Clone();
		//}

		//static object Copy(object obj) {
		//	if (obj is ICloneable) {
		//		ICloneable item = (ICloneable)obj;
		//		return item.Clone();
		//	}
		//	return null;
		//}

		//static object Copy(object obj) {
		//	ICloneable item = obj as ICloneable;
		//	if (item != null) return item.Clone();
		//	return null;
		//}

		//static object Copy(object obj) {
		//	ICloneable item = obj as ICloneable;
		//	return item != null ? item.Clone() : null;
		//}

		static object Copy(object obj) {
			//if (obj.GetType().IsValueType)
			//	throw new Exception("Must be an object.");
			ICloneable item = obj as ICloneable;
			return item?.Clone();
		}

		static void Main(string[] args) {
			var logger = new FileLogger();
			logger.Log4();
			new DebugLogger().Log4(); // Log4(new DebugLogger());
			new FileLogger().Log4(); // Log4(new FileLogger());

			Log5(new DebugLogger());

			var ob1 = Copy("Hello!");
			var ob2 = Copy(new ArrayList());
			var ob3 = Copy(new int[4]);
			var ob4 = Copy(DateTime.Now);	// boxing
			var ob5 = Copy(123);			// boxing
		}
	}
}
