using System.Collections.Generic;

namespace Symbion {
	public interface IShell : IService {
		Dictionary<string, IActionSite> Sites { get; }
		Dictionary<string, IWorkspace> Workspaces { get; }
		string Status { set; }
		void Success(string message);
		void Failure(string message);
		void Warning(string message);
		bool Confirm(string message);
		void Close();
	}
}
