using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Symbion {
	public class MenuActionSite : IActionSite {
		private ToolStripMenuItem _menu;
		private Dictionary<Command, ToolStripMenuItem> _items;

		public MenuActionSite(ToolStripMenuItem menu) {
			_items = new Dictionary<Command, ToolStripMenuItem>();
			_menu = menu;
		}

		private void OnItemClick(object sender, EventArgs e) {
			var item = (ToolStripMenuItem)sender;
			var command = (Command)item.Tag;
			command.Execute();
		}

		private void OnCommandChanged(object sender, EventArgs e) {
			Update((Command)sender);
		}


		public void Add(Command command) {
			command.CommandChanged += OnCommandChanged;
			ToolStripMenuItem item = new ToolStripMenuItem(
				command.Caption, command.Icon, OnItemClick, command.Keys);
			_menu.DropDownItems.Add(item);
			item.ToolTipText = command.Description;
			item.Enabled = command.Enabled;
			item.Checked = command.Checked;
			item.Tag = command;
			_items.Add(command, item);
		}

		public void AddSeparator() {
			_menu.DropDownItems.Add(
				new ToolStripSeparator());
		}

		public void Remove(Command command) {
			ToolStripMenuItem item = _items[command];
			command.CommandChanged -= OnCommandChanged;
			_menu.DropDownItems.Remove(item);
			_items.Remove(command);

		}

		public void Update(Command command) {
			ToolStripMenuItem item = _items[command];
			if (item != null) {
				item.Text = command.Caption;
				item.Image = command.Icon;
				item.ShortcutKeys = command.Keys;
				item.ToolTipText = command.Description;
				item.Enabled = command.Enabled;
				item.Checked = command.Checked;
			}
		}
	}
}
