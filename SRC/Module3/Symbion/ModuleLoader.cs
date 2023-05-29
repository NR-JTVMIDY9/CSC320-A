using Symbion.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
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
							CultureInfo.CurrentCulture,
							Resources.UserNotAuthorizedForModule,
							item.Path));
						continue;
					}
				}
				if (!File.Exists(item.Path)) {
					logger.Failure(string.Format(
						CultureInfo.CurrentCulture,
						Resources.CannotLocateModule,
						item.Path));
					continue;
				}
				Assembly assembly = null;
				try {
					assembly = Assembly.LoadFrom(item.Path);
				} 
				catch (Exception ex) {
					logger.Failure(string.Format(
						CultureInfo.CurrentCulture,
						Resources.ErrorLoadingModule,
						ex.Message, item.Path));
					continue;
				}
				Type moduleType = assembly.GetType(item.Name);
				if (moduleType == null) {
					logger.Failure(string.Format(
						CultureInfo.CurrentCulture,
						Resources.CannotFindClassInModule,
						item.Name, item.Path));
					continue;
				}
				try {
					var module = (IModule)Activator.CreateInstance(moduleType);
					_modules.Add(module);
					Debug.WriteLine(string.Format(
						CultureInfo.CurrentCulture,
						Resources.ModuleLoaded, item.Path));
				}
				catch (Exception ex) {
					logger.Failure(string.Format(
						CultureInfo.CurrentCulture,
						Resources.ErrorInstancingClassInModule,
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
