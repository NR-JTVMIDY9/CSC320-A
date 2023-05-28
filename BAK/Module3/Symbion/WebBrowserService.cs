using System;

namespace Symbion {
	public class WebBrowserService : BaseService, IWebBrowserService {
		public void Open(string url, string workspaceId) {
			WebBrowserView view = new WebBrowserView();
			view.Open(url); view.Show(workspaceId);
		}
	}
}
