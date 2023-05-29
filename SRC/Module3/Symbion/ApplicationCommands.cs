using Symbion.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Symbion {
	public class ApplicationCommands {
		public static Command Exit = new Command {
			Caption = Resources.Exit,
			Icon = Resources.Cancel,
			Description = "Close application",
			Action = command => Application.Exit(),
			Keys = Keys.Alt | Keys.X };
	}
}
