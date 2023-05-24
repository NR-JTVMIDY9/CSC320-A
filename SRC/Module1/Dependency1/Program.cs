using Symbion;

namespace Dependency1 {
	class Program {
		static void AddServices() {
			//	ServiceRepository.Add(typeof(ILogger), LoggerFactory.CreateInstance());
			//	ServiceRepository.Add<ILogger>(LoggerFactory.CreateInstance());
			//	ServiceRepository.Add(LoggerFactory.CreateInstance());
			//	LoggerFactory.CreateInstance().Add();
			new DebugLogger().Add<ILogger>();
		}
		static void UseServices() {
			//	ILogger logger = (ILogger)ServiceRepository.Get(typeof(ILogger));
			//	ILogger logger = ServiceRepository.Get<ILogger>();
			var logger = ServiceRepository.Get<ILogger>();
			if (logger == null) {
				logger = new DebugLogger();
				//	ServiceRepository.Add(typeof(ILogger), logger);
				logger.Add();
			}
			//if (logger != null) {
			//	logger.Message("Hello!");
			//	logger.Message("Goodbye!");
			//}
			logger.Message("Hello!");
			logger.Message("Goodbye!");
		}
		static void Main() {
			AddServices();
			UseServices();
		}
	}
}
