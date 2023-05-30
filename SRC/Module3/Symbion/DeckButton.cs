using System.Drawing;
using System.Windows.Forms;

namespace Symbion {
	public class DeckButton : Button {
		public DeckButton() {
			Height = 32;
			Padding = new Padding(4, 0, 0, 0);
			ImageAlign = ContentAlignment.MiddleLeft;
			TextAlign = ContentAlignment.MiddleLeft;
			TextImageRelation = TextImageRelation.ImageBeforeText;
			Dock = DockStyle.Bottom;
		}
		public DeckButton(IView view) : this() {
			Image = view.Icon;
			Text = view.Caption;
			Tag = view;
		}
	}
}
