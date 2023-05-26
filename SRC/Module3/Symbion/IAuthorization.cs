using System.Collections.Generic;

namespace Symbion {
	public interface IAuthorization : IService {
		string UserName { get; }
		bool IsInRole(string roleName);
		bool IsInAnyRoles(IEnumerable<string> roles);
		bool IsInAllRoles(IEnumerable<string> roles);
	}
}
