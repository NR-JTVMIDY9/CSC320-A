using System.Collections.Generic;
using System.Windows.Forms;

namespace Symbion {
	public partial class TabWorkspace : BaseWorkspace {
		private Dictionary<IView, TabPage> _views;

		public TabWorkspace() {
			InitializeComponent();
			_views = new Dictionary<IView, TabPage>();
		}
		public override void Append(IView view) {
			TabPage page = new TabPage(view.Caption);
			view.Control.Dock = DockStyle.Fill;
			page.Controls.Add(view.Control);
			tabMain.TabPages.Add(page);
			_views.Add(view, page);
			view.Workspace = this;
		}

		public override void Remove(IView view) {
			TabPage page = _views[view];
			tabMain.TabPages.Remove(page);
			_views.Remove(view);
			view.Workspace = null;
		}

		public override void Update(IView view) {
			TabPage page = _views[view];
			page.Text = view.Caption;
		}
	}
}
