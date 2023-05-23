
using Symbion;
using System;
using System.Security.Principal;

namespace Dependency1 {
	class Program {
		static void AddServices() {
			//	ServiceRepository.Add(typeof(ILogger), LoggerFactory.CreateInstance());
			//	ServiceRepository.Add<ILogger>(LoggerFactory.CreateInstance());
			//	ServiceRepository.Add(LoggerFactory.CreateInstance());
			//	LoggerFactory.CreateInstance().Add();
			AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
			new PrincipalAuthorization().Add<IAuthorization>();
		}
		static void UseServices() {
			//	ILogger logger = (ILogger)ServiceRepository.Get(typeof(ILogger));
			//	ILogger logger = ServiceRepository.Get<ILogger>();
			ILogger logger = BaseLogger.Instance;
			if (logger != null) logger.Write("Logger service located!");
			var auth = ServiceRepository.Get<IAuthorization>();
			Console.WriteLine(auth.UserName);
			Console.WriteLine(auth.IsInRole("Administrators"));
			Console.WriteLine(auth.IsInRole("Banking"));
		}
		static void Main(string[] args) {
			//	AddServices();
			//	UseServices();
			AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
			new PrincipalAuthorization().Add<IAuthorization>();
			LoggerFactory.CreateInstance().Add();
			ModuleLoader.Load("Modules.xml");
			ModuleLoader.Init();

			//	var worker = ServiceRepository.CreateInstance<BankingWorker>();
			var worker = new BankingWorker();
			worker.Add();
			Console.WriteLine(worker.Account);
			Console.WriteLine(worker.Transaction);


			ModuleLoader.Exit();
		}
	}
}
