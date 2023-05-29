namespace Symbion {
	public interface IWebBrowserService : IService {
		void Open(string url, string workspaceId);
	}
}
