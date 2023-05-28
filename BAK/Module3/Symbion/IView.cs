using System;
using System.Drawing;
using System.Windows.Forms;

namespace Symbion {
	public interface IView {
		Image Icon { get; }
		string Caption { get; }
		Control Control { get; }
		IWorkspace Workspace { get; set; }
		void Show(string workspaceId);
		void Close();
	}
}
