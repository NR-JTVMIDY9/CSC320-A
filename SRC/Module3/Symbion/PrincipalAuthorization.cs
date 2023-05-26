using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Threading;

namespace Symbion {
	public class PrincipalAuthorization : BaseService, IAuthorization {
		private IPrincipal _principal;

		public string UserName {
			get {
				return _principal.Identity.Name;
			}
		}

		public bool IsInAllRoles(IEnumerable<string> roles) {
			foreach (string roleName in roles)
				if (!IsInRole(roleName))
					return false;
			return true;
		}

		public bool IsInAnyRoles(IEnumerable<string> roles) {
			foreach (string roleName in roles)
				if (IsInRole(roleName))
					return true;
			return false;
		}

		public bool IsInRole(string roleName) {
			return _principal.IsInRole(roleName);
		}

		public PrincipalAuthorization() {
			//	WindowsIdentity identity = WindowsIdentity.GetCurrent();
			//	_principal = new WindowsPrincipal(identity);
			_principal = Thread.CurrentPrincipal;
		}

	}
}
