using SymBank.Properties;
using Symbion;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

namespace SymBank {
	public partial class ShellForm : Form, IShell {

		private Dictionary<string, IActionSite> _sites;
		private Dictionary<string, IWorkspace> _workspaces;


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
			WebBrowserService wbs = new WebBrowserService();
			wbs.Add<IWebBrowserService>();
			//wbs.Open("http://www.microsoft.com", "DeckSpace");
			//wbs.Open("http://www.google.com", "DeckSpace");
			//wbs.Open("http://www.hotmail.com", "DeckSpace");
			_sites["FileMenu"].Add(ApplicationCommands.Exit);
			_sites["Toolbar"].Add(ApplicationCommands.Exit);
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

		public Dictionary<string, IWorkspace> Workspaces {
			get {
				return _workspaces;
			}
		}
	}
}
