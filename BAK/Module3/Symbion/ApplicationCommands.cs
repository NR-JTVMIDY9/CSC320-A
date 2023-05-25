using Symbion.Properties;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Symbion {
	public class ApplicationCommands {
		public static Command Exit = new Command {
			Caption = "E&xit",
			Icon = Resources.Cancel,
			Description = "Closes application",
			Action = command => Application.Exit(),
			Keys = Keys.Alt | Keys.X
		};
	}
}
