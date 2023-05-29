using System;
using System.Drawing;
using System.Windows.Forms;

namespace Symbion {
	public class BaseView : UserControl, IView {
		public string Caption { get; set; } = string.Empty;
		public Control Control { get { return this; }}
		public Image Icon { get; set; }
		public IWorkspace Workspace { get; set; }
		public void Close() {
			if (Workspace != null)
				Workspace.Remove(this);
		}
		private static IShell _shell;
		public static IShell Shell {
			get {
				return _shell ?? (_shell =
					ServiceRepository.Get<IShell>());
			}
		}
		public void Show(string workspaceId) {
			Shell.Workspaces[workspaceId].Append(this);
		}
	}
}
