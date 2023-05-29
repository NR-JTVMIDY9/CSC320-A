namespace Symbion {
	partial class WebBrowserView {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.tbrMain = new System.Windows.Forms.ToolStrip();
			this.btnBack = new System.Windows.Forms.ToolStripButton();
			this.btnForward = new System.Windows.Forms.ToolStripButton();
			this.txtURL = new System.Windows.Forms.ToolStripTextBox();
			this.btnNavigate = new System.Windows.Forms.ToolStripButton();
			this.btnClose = new System.Windows.Forms.ToolStripButton();
			this.webBrowser = new System.Windows.Forms.WebBrowser();
			this.tbrMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbrMain
			// 
			this.tbrMain.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.tbrMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack,
            this.btnForward,
            this.txtURL,
            this.btnNavigate,
            this.btnClose});
			this.tbrMain.Location = new System.Drawing.Point(0, 0);
			this.tbrMain.Name = "tbrMain";
			this.tbrMain.Size = new System.Drawing.Size(818, 39);
			this.tbrMain.TabIndex = 0;
			this.tbrMain.Text = "toolStrip1";
			// 
			// btnBack
			// 
			this.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnBack.Image = global::Symbion.Properties.Resources.Previous;
			this.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(36, 36);
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnForward
			// 
			this.btnForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnForward.Image = global::Symbion.Properties.Resources.Next;
			this.btnForward.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnForward.Name = "btnForward";
			this.btnForward.Size = new System.Drawing.Size(36, 36);
			this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
			// 
			// txtURL
			// 
			this.txtURL.AutoSize = false;
			this.txtURL.Name = "txtURL";
			this.txtURL.Size = new System.Drawing.Size(300, 39);
			// 
			// btnNavigate
			// 
			this.btnNavigate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnNavigate.Image = global::Symbion.Properties.Resources.World;
			this.btnNavigate.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnNavigate.Name = "btnNavigate";
			this.btnNavigate.Size = new System.Drawing.Size(36, 36);
			this.btnNavigate.Click += new System.EventHandler(this.btnNavigate_Click);
			// 
			// btnClose
			// 
			this.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnClose.Image = global::Symbion.Properties.Resources.Cancel;
			this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(36, 36);
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// webBrowser
			// 
			this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser.Location = new System.Drawing.Point(0, 39);
			this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser.Name = "webBrowser";
			this.webBrowser.ScriptErrorsSuppressed = true;
			this.webBrowser.Size = new System.Drawing.Size(818, 546);
			this.webBrowser.TabIndex = 1;
			this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
			// 
			// WebBrowserView
			// 
			this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Controls.Add(this.webBrowser);
			this.Controls.Add(this.tbrMain);
			this.Name = "WebBrowserView";
			this.Size = new System.Drawing.Size(818, 585);
			this.tbrMain.ResumeLayout(false);
			this.tbrMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip tbrMain;
		private System.Windows.Forms.ToolStripButton btnBack;
		private System.Windows.Forms.ToolStripButton btnForward;
		private System.Windows.Forms.ToolStripTextBox txtURL;
		private System.Windows.Forms.ToolStripButton btnNavigate;
		private System.Windows.Forms.ToolStripButton btnClose;
		private System.Windows.Forms.WebBrowser webBrowser;
	}
}
