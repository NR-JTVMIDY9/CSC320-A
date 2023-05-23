using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Symbion {
	public static class ServiceRepository {
		static Dictionary<Type, IService> _services = new Dictionary<Type, IService>();

		public static bool Add(Type serviceType, IService serviceObject) {
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

		public static bool Add<TService>(this TService serviceObject) where TService : IService {
			Type serviceType = typeof(TService);
			if (!_services.ContainsKey(serviceType)) {
				_services.Add(serviceType, serviceObject);
				return true;
			}
			return false;
		}

		public static TService Get<TService>() where TService : IService {
			IService serviceObject = null;
			Type serviceType = typeof(TService);
			_services.TryGetValue(serviceType, out serviceObject);
			return (TService)serviceObject;
		}

		public static void AddServices(this IModule module) {
			Assembly assembly = module.GetType().Assembly;
			Type[] types = assembly.GetExportedTypes();
			foreach (Type type in types) {
				if (!type.IsClass) continue;
				//	var attributes = (ServiceAttribute[])type.GetCustomAttributes(typeof(ServiceAttribute), false);
				var attributes = type.GetCustomAttributes<ServiceAttribute>(false).ToArray();
				if (attributes.Length == 0) continue;
				var instance = (IService)Activator.CreateInstance(type);
				foreach (var attribute in attributes) {
					Type serviceType = attribute.ServiceType;
					if (!_services.ContainsKey(serviceType))
						_services.Add(serviceType, instance);
				}
			}
		}

		public static TInstance CreateInstance<TInstance>() where TInstance : class {
			Type type = typeof(TInstance);
			ConstructorInfo constructor = type.GetConstructors()[0];
			ParameterInfo[] parameters = constructor.GetParameters();
			List<object> values = new List<object>();
			foreach (ParameterInfo parameter in parameters) {
				IService serviceObject = Get(parameter.ParameterType);
				if (serviceObject == null) throw new Exception(
					$"Cannot resolve parameter {parameter.Name}");
				values.Add(serviceObject);
			}
			return (TInstance)constructor.Invoke(values.ToArray());
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