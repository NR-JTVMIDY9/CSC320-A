using System;
using System.Threading;
using System.Windows.Forms;

namespace SymBank {
	static class Program {
		[STAThread]
		static void Main() {
			var thread = Thread.CurrentThread;
			thread.CurrentUICulture = thread.CurrentCulture;
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new ShellForm());
		}
	}
}
