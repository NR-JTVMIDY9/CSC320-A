using System;
using System.Windows.Forms;

namespace Symbion {
	public partial class WebBrowserView : BaseView {
		public WebBrowserView() {
			InitializeComponent();
		}

		public void Open(string url) {
			try {
				txtURL.Text = url;
				webBrowser.Navigate(url);
			}
			catch { }
		}

		private void btnBack_Click(object sender, EventArgs e) {
			if (webBrowser.CanGoBack) webBrowser.GoBack();
		}

		private void btnForward_Click(object sender, EventArgs e) {
			if (webBrowser.CanGoForward) webBrowser.GoForward();
		}

		private void btnNavigate_Click(object sender, EventArgs e) {
			var text = txtURL.Text.Trim();
			if (text.Length > 0) Open(text);
		}

		private void btnClose_Click(object sender, EventArgs e) {
			Close();
		}

		private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {
			Caption = webBrowser.DocumentTitle;
			Workspace.Update(this);
		}
	}
}
