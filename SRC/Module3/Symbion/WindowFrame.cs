using System.ComponentModel;
using System.Windows.Forms;

namespace Symbion {
	public partial class WindowFrame : Form {
		private IWorkspace _workspace;
		private Component _item;
		private IView _view;

		public WindowFrame(
			IWorkspace workspace,
			Component item,
			IView view) {
			InitializeComponent();
			_workspace = workspace;
			_item = item;
			_view = view;
			Text = view.Caption;
			Control viewControl = view.Control;
			viewControl.Dock = DockStyle.Fill;
			ClientSize = viewControl.Size;
			Controls.Add(viewControl);
		}

		public IView View { get { return _view; } }
		public Component Item { get { return _item; } }
		public IWorkspace Workspace {  get { return _workspace; } }
	}
}
