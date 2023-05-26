using Symbion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymBank {
	public partial class ShellForm : Form, IShell {
		public string Status {
			set {
				lblStatus.Text = value ?? "Ready.";
			}
		}

		public ShellForm() {
			InitializeComponent();
			this.Add<IShell>();
		}

		private void ShellForm_Load(object sender, EventArgs e) {
			AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
			LoggerFactory.CreateInstance().Add();
			new PrincipalAuthorization().Add<IAuthorization>();
			ModuleLoader.Load("Modules.xml");
			ModuleLoader.Init();
		}

		private void ShellForm_FormClosed(object sender, FormClosedEventArgs e) {
			ModuleLoader.Exit();
		}

		public void Success(string message) {
			MessageBox.Show(this, message, "Information",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public void Failure(string message) {
			MessageBox.Show(this, message, "Error",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public void Warning(string message) {
			MessageBox.Show(this, message, "Alert",
				MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		public bool Confirm(string message) {
			return MessageBox.Show(this, message, "Confirmation",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question)
				== DialogResult.Yes;
		}
	}
}
