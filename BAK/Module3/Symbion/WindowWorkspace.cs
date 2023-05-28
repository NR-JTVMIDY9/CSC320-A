using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Symbion {
	public partial class WindowWorkspace : BaseWorkspace {
		protected Dictionary<IView, WindowFrame> _views;
		public WindowWorkspace() {
			InitializeComponent();
			_views = new Dictionary<IView, WindowFrame>();
			int height = tbrMain.Height + Padding.Top + Padding.Bottom;
			MinimumSize = new Size(0, height);
		}

		protected void OnItemClick(object sender, EventArgs e) {
			ToolStripItem item = (ToolStripItem)sender;
			WindowFrame form = (WindowFrame)item.Tag;
			form.Activate();
		}

		private void btnCloseAll_Click(object sender, EventArgs e) {
			foreach (IView view in _views.Keys) Remove(view);
		}

		public override void Append(IView view) {
			ToolStripItem listItem = btnWindowList.DropDownItems.Add(view.Caption);
			WindowFrame frame = new WindowFrame(this, listItem, view);
			listItem.Click += OnItemClick;
			listItem.Tag = frame;
			frame.Show();
			_views.Add(view, frame);
			view.Workspace = this;
		}

		public override void Remove(IView view) {
			WindowFrame frame = _views[view];
			btnWindowList.DropDownItems.Remove((ToolStripItem)frame.Item);
			frame.Close(); _views.Remove(view);
			view.Workspace = null;
		}
		public override void Update(IView view) {
			WindowFrame frame = _views[view];
			ToolStripItem listItem = (ToolStripItem)frame.Item;
			listItem.Text = frame.Text = view.Caption;
		}
	}
}
