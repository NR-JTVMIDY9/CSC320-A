using System;
using System.Drawing;
using System.Windows.Forms;

namespace Symbion {
	public class BaseView : UserControl, IView {
		public virtual Image Icon { get; set; }
		public virtual string Caption { get; set; } = string.Empty;
		public Control Control { get { return this; } }
		public IWorkspace Workspace { get; set; }

		private static IShell _shell;
		public static IShell Shell {
			get { return _shell ?? (_shell = ServiceRepository.Get<IShell>()); }
		}

		public void Show(string workspaceId) {
			Shell.Workspaces[workspaceId].Append(this);
		}
		public void Close() { if (Workspace != null) Workspace.Remove(this); }
	}
}
