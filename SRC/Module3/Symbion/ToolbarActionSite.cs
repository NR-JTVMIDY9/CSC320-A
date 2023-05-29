using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Symbion {
	public class ToolbarActionSite : IActionSite {
		private ToolStrip _toolbar;
		private Dictionary<Command, ToolStripButton> _items;

		public ToolbarActionSite(ToolStrip toolbar) {
			_items = new Dictionary<Command, ToolStripButton>();
			_toolbar = toolbar;
		}

		private void OnItemClick(object sender, EventArgs e) {
			var item = (ToolStripButton)sender;
			((Command)item.Tag).Execute();
		}

		private void OnCommandChanged(object sender, EventArgs e) {
			Update((Command)sender);
		}

		public void Add(Command command) {
			command.CommandChanged += OnCommandChanged;
			ToolStripButton item = new ToolStripButton(
				string.Empty, command.Icon, OnItemClick);
			_items.Add(command, item);
			_toolbar.Items.Add(item);
			item.ToolTipText = command.Description;
			item.Enabled = command.Enabled;
			item.Checked = command.Checked;
			item.Tag = command;
		}

		public void AddSeparator() {
			_toolbar.Items.Add(new ToolStripSeparator());
		}

		public void Remove(Command command) {
			ToolStripButton item = _items[command];
			command.CommandChanged -= OnCommandChanged;
			_toolbar.Items.Remove(item);
			_items.Remove(command);
		}

		public void Update(Command command) {
			ToolStripButton item = _items[command];
		//	item.Text = command.Caption;
			item.Image = command.Icon;
			item.ToolTipText = command.Description;
			item.Enabled = command.Enabled;
			item.Checked = command.Checked;
		}
	}
}
