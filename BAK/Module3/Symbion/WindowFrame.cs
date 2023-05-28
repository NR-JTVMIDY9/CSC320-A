using System.ComponentModel;
using System.Windows.Forms;

namespace Symbion {
	public partial class WindowFrame : Form {
		protected IWorkspace workspace;
		protected Component item;
		protected IView view;

		public IView View { get { return view; } }
		public Component Item { get { return item; } }

		public WindowFrame(
			IWorkspace workspace,
			Component item,
			IView view) {
			InitializeComponent();
			this.workspace = workspace;
			this.item = item;
			this.view = view;
			Text = view.Caption;
			Control viewControl = view.Control;
			viewControl.Dock = DockStyle.Fill;
			ClientSize = viewControl.Size;
			Controls.Add(viewControl);
		}
	}
}
