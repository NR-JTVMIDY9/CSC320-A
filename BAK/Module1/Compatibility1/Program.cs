using Symbion;
using Symbion.Loggers;
using System;
using System.Collections;

namespace Compatibility1 {
	public static class Program {
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

		static void Log4(this ILogger logger) {
			logger.Message("Hello!");
			logger.Message("Goodbye!");
		}

		//static object Copy(ICloneable obj) {
		//	return obj.Clone();     // calling Clone method through ICloneable interface
		//}

		//static object Copy(object obj) {
		//	if (obj is ICloneable) {
		//		ICloneable item = (ICloneable)obj;
		//		return item.Clone();
		//	}
		//	return null;        // null is default value if cannot clone
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
			ICloneable item = obj as ICloneable;
			return item?.Clone();
		}

		static void Main() {
			Log1(new DebugLogger());
			Log2(new DebugLogger());
			Log2(new FileLogger());
			new DebugLogger().Log4();
			new FileLogger().Log4();

			var ob1 = Copy("Hello!");           // can compile because String type implements ICloneable
			var ob2 = Copy(new ArrayList());    // can compile because ArrayList implements ICloneable
			var ob3 = Copy(new int[4]);         // can compile because arrays implements ICloneable
		//	var ob4 = Copy(DateTime.Now);       // cannot compile as DateTime does not support ICloneable
			var ob4 = Copy(DateTime.Now);       // can compile now since compatibility is checked at runtime, not compile time
		}
	}
}
