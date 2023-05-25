using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Symbion {
	public static class ModuleLoader {
		#region fields
		private static List<IModule> _modules;
		#endregion
		#region constructors
		static ModuleLoader() {
			_modules = new List<IModule>();
		}
		#endregion
		#region methods
		public static void Load(string path) {
			ILogger logger = ServiceRepository.Get<ILogger>();
			IAuthorization auth = ServiceRepository.Get<IAuthorization>();
			ModuleList list = ModuleList.Load(path);
			foreach (ModuleItem item in list.Items) {
				if (auth != null) {
					if (item.Roles.Count > 0 &&
						!auth.IsInAnyRoles(item.Roles)) {
						Debug.WriteLine(string.Format(
							"User not authorized for module {0}.",
							item.Path));
						continue;
					}
				}
				if (!File.Exists(item.Path)) {
					logger.Failure(string.Format(
						"Cannot locate module {0}.", item.Path));
					continue;
				}
				Assembly assembly = null;
				try {
					assembly = Assembly.LoadFrom(item.Path);
				} 
				catch (Exception ex) {
					logger.Failure(string.Format(
						"Error '{0}' occurred in module {1}.",
						ex.Message, item.Path));
					continue;
				}
				Type moduleType = assembly.GetType(item.Name);
				if (moduleType == null) {
					logger.Failure(string.Format(
						"Cannot find class {0} in module {1}.",
						item.Name, item.Path));
					continue;
				}
				try {
					var module = (IModule)Activator.CreateInstance(moduleType);
					_modules.Add(module);
					Debug.WriteLine(string.Format(
						"Module {0} loaded successfully.", item.Path));
				}
				catch (Exception ex) {
					logger.Failure(string.Format(
						"Error '{0}' instancing {1} in module {2}.",
						ex.Message, item.Name, item.Path));
					continue;
				}
			}
		}
		public static void Init() {
			foreach (IModule module in _modules) {
				module.Init();
			//	ServiceRepository.AddServices(module);
				module.AddServices();
			}
		}
		public static void Exit() {
			foreach (IModule module in _modules)
				module.Exit();
		}
		#endregion
	}
}
