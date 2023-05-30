using SymBank.Properties;
using Symbion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymBank {
	public partial class ShellForm : Form, IShell {
		private Dictionary<string, IActionSite> _sites;
		private Dictionary<string, IWorkspace> _workspaces;

		public string Status {
			set {
				if (frmSplash == null) {
					lblStatus.Text = value ?? Resources.Ready;
					sbrMain.Refresh();
				}
				else frmSplash.Status = value;
			}
		}


		public ShellForm() {
			InitializeComponent();
			_sites = new Dictionary<string, IActionSite>();
			_workspaces = new Dictionary<string, IWorkspace>();

			_workspaces.Add("TabSpace", tabWorkspace);
			_workspaces.Add("WindowSpace", windowWorkspace);
			_workspaces.Add("DeckSpace", deckWorkspace);

			_sites.Add("FileMenu", new MenuActionSite(mnuFile));
			_sites.Add("ToolsMenu", new MenuActionSite(mnuTools));
			_sites.Add("Toolbar", new ToolbarActionSite(tbrMain));

			this.Add<IShell>();
		}

		public Dictionary<string, IActionSite> Sites {
			get { return _sites; }
		}

		public Dictionary<string, IWorkspace> Workspaces {
			get { return _workspaces; }
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
			DebugHelper.Delay(200);
			Status = Resources.InitializingModules;
			ModuleLoader.Init();
			DebugHelper.Delay(2000);
			frmSplash.Close();
			frmSplash = null;
			Status = null;

			_sites["FileMenu"].AddSeparator();
			_sites["FileMenu"].Add(ApplicationCommands.Exit);
			_sites["Toolbar"].Add(ApplicationCommands.Exit);

			var wbs = new WebBrowserService();
			wbs.Add<IWebBrowserService>();
			//wbs.Open("http://www.microsoft.com", "DeckSpace");
			//wbs.Open("http://www.google.com", "DeckSpace");
			//wbs.Open("http://www.hotmail.com", "DeckSpace");
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
	}
}
