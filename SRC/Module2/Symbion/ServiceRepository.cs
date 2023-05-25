using System;
using System.Collections.Generic;
using System.Reflection;

namespace Symbion {
	public static class ServiceRepository {
		private static Dictionary<Type, IService> _services;

		static ServiceRepository() {
			_services = new Dictionary<Type, IService>();
		}

		public static void AddServices(this IModule module) {
			Assembly assembly = module.GetType().Assembly;
			Type[] types = assembly.GetExportedTypes();
			foreach (Type type in types) {
				if (!type.IsClass) continue;
				ServiceAttribute[] attributes = (ServiceAttribute[])
					type.GetCustomAttributes(typeof(ServiceAttribute), false);
				if (attributes.Length == 0) continue;
				IService instance = (IService)Activator.CreateInstance(type);
				foreach (ServiceAttribute attribute in attributes)
					_services.Add(attribute.ServiceType, instance);
			}
		}

		public static bool Add(Type serviceType, IService serviceObject) {
			if (!_services.ContainsKey(serviceType)) {
				_services.Add(serviceType, serviceObject);
				return true;
			}
			return false;
		}

		public static bool Add<TService>(this TService serviceObject) where TService : IService {
			Type serviceType = typeof(TService);
			if (!_services.ContainsKey(serviceType)) {
				_services.Add(serviceType, serviceObject);
				return true;
			}
			return false;
		}

		public static IService Get(Type serviceType) {
			IService serviceObject = null;
			_services.TryGetValue(serviceType, out serviceObject);
			return serviceObject;
		}

		public static TService Get<TService>() where TService : IService {
			Type serviceType = typeof(TService);
			IService serviceObject = null;
			_services.TryGetValue(serviceType, out serviceObject);
			return (TService)serviceObject;
		}

		public static TInstance CreateInstance<TInstance>() where TInstance : class {
			Type type = typeof(TInstance);
			ConstructorInfo constructor = type.GetConstructors()[0];
			ParameterInfo[] parameters = constructor.GetParameters();
			List<object> values = new List<object>();
			foreach (ParameterInfo parameter in parameters) {
				IService serviceObject = Get(parameter.ParameterType);
				if (serviceObject == null) throw new Exception(
					$"Cannot resolve parameter {parameter.Name}.");
				values.Add(serviceObject);
			}
			var instance = (TInstance)constructor.Invoke(values.ToArray());
			instance.Inject();
			return instance;
		}

		public static void Inject(this object obj) {
			Type type = obj.GetType();
			PropertyInfo[] properties = type.GetProperties();
			foreach (PropertyInfo property in properties) {
				if (property.GetCustomAttribute<InjectAttribute>() != null) {
					IService serviceObject = Get(property.PropertyType);
					if (serviceObject != null) property.SetValue(obj, serviceObject);
				}
			}
		}
	}
}
