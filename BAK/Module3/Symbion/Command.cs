using System;
using System.Drawing;
using System.Windows.Forms;

namespace Symbion {
	public class Command {
		public event EventHandler CommandChanged;
		public Image Icon { get; set; }
		public string Caption { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public bool Enabled { get; set; } = true;
		public bool Checked { get; set; }
		public Keys Keys { set; get; } = Keys.None;
		public Action<Command> Action { get; set; }
		public object Parameter { get; set; }
		public void Update() {
			CommandChanged?.Invoke(
				this, EventArgs.Empty);
		}
		public void Execute() {
			if (Enabled) Action?.Invoke(this);
		}
	}
}
