using SymBank.Properties;
using Symbion;
using System;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

namespace SymBank {
	public partial class ShellForm : Form, IShell {
		public ShellForm() {
			InitializeComponent();
		}

		private SplashScreen frmSplash;

		private void ShellForm_Load(object sender, EventArgs e) {
			frmSplash = new SplashScreen();
			frmSplash.Show();
			AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
			LoggerFactory.CreateInstance().Add();
			new PrincipalAuthorization().Add<IAuthorization>();
			Status = Resources.LoadingModules;
			ModuleLoader.Load("Modules.xml");
			DebugHelper.Delay(2000);
			Status = Resources.InitializingModules;
			ModuleLoader.Init();
			DebugHelper.Delay(2000);
			frmSplash.Close();
			frmSplash = null;
			Status = null;
		}

		private void ShellForm_FormClosed(object sender, FormClosedEventArgs e) {
			ModuleLoader.Exit();
		}

		public void Success(string message) {
			MessageBox.Show(this, message, Resources.Success,
			MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		public void Failure(string message) {
			MessageBox.Show(this, message, Resources.Failure,
				MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		public void Warning(string message) {
			MessageBox.Show(this, message, Resources.Warning,
				MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
		public bool Confirm(string message) {
			return MessageBox.Show(this, message, Resources.Confirm,
				MessageBoxButtons.YesNo, MessageBoxIcon.Question)
				== DialogResult.Yes;
		}

		public string Status {
			set {
				if (frmSplash == null) {
					lblStatus.Text = value ?? Resources.Ready;
					sbrMain.Refresh();
				}
				else frmSplash.Status = value;
			}
		}

	}
}
