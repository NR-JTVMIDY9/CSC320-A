namespace SymBank {
	partial class ShellForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShellForm));
			this.sbrMain = new System.Windows.Forms.StatusStrip();
			this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.mbrMain = new System.Windows.Forms.MenuStrip();
			this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
			this.tbrMain = new System.Windows.Forms.ToolStrip();
			this.spcMain = new System.Windows.Forms.SplitContainer();
			this.tabWorkspace = new Symbion.TabWorkspace();
			this.windowWorkspace = new Symbion.WindowWorkspace();
			this.sbrMain.SuspendLayout();
			this.mbrMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
			this.spcMain.Panel1.SuspendLayout();
			this.spcMain.Panel2.SuspendLayout();
			this.spcMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// sbrMain
			// 
			this.sbrMain.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.sbrMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
			this.sbrMain.Location = new System.Drawing.Point(0, 457);
			this.sbrMain.Name = "sbrMain";
			this.sbrMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.sbrMain.Size = new System.Drawing.Size(897, 38);
			this.sbrMain.TabIndex = 0;
			this.sbrMain.Text = "statusStrip1";
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = false;
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Padding = new System.Windows.Forms.Padding(4);
			this.lblStatus.Size = new System.Drawing.Size(882, 33);
			this.lblStatus.Spring = true;
			this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// mbrMain
			// 
			this.mbrMain.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.mbrMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuTools});
			this.mbrMain.Location = new System.Drawing.Point(0, 0);
			this.mbrMain.Name = "mbrMain";
			this.mbrMain.Size = new System.Drawing.Size(897, 40);
			this.mbrMain.TabIndex = 1;
			this.mbrMain.Text = "menuStrip1";
			// 
			// mnuFile
			// 
			this.mnuFile.Name = "mnuFile";
			this.mnuFile.Size = new System.Drawing.Size(64, 36);
			this.mnuFile.Text = "&File";
			// 
			// mnuTools
			// 
			this.mnuTools.Name = "mnuTools";
			this.mnuTools.Size = new System.Drawing.Size(82, 36);
			this.mnuTools.Text = "Too&ls";
			// 
			// tbrMain
			// 
			this.tbrMain.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.tbrMain.Location = new System.Drawing.Point(0, 40);
			this.tbrMain.Name = "tbrMain";
			this.tbrMain.Size = new System.Drawing.Size(897, 25);
			this.tbrMain.TabIndex = 2;
			// 
			// spcMain
			// 
			this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spcMain.Location = new System.Drawing.Point(0, 65);
			this.spcMain.Name = "spcMain";
			// 
			// spcMain.Panel1
			// 
			this.spcMain.Panel1.Controls.Add(this.windowWorkspace);
			// 
			// spcMain.Panel2
			// 
			this.spcMain.Panel2.Controls.Add(this.tabWorkspace);
			this.spcMain.Size = new System.Drawing.Size(897, 392);
			this.spcMain.SplitterDistance = 299;
			this.spcMain.TabIndex = 3;
			// 
			// tabWorkspace
			// 
			this.tabWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabWorkspace.Location = new System.Drawing.Point(0, 0);
			this.tabWorkspace.Name = "tabWorkspace";
			this.tabWorkspace.Size = new System.Drawing.Size(594, 392);
			this.tabWorkspace.TabIndex = 0;
			// 
			// windowWorkspace
			// 
			this.windowWorkspace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.windowWorkspace.Dock = System.Windows.Forms.DockStyle.Top;
			this.windowWorkspace.Location = new System.Drawing.Point(0, 0);
			this.windowWorkspace.Name = "windowWorkspace";
			this.windowWorkspace.Padding = new System.Windows.Forms.Padding(4);
			this.windowWorkspace.Size = new System.Drawing.Size(299, 49);
			this.windowWorkspace.TabIndex = 0;
			// 
			// ShellForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(897, 495);
			this.Controls.Add(this.spcMain);
			this.Controls.Add(this.tbrMain);
			this.Controls.Add(this.sbrMain);
			this.Controls.Add(this.mbrMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.mbrMain;
			this.Name = "ShellForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SymBank";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShellForm_FormClosed);
			this.Load += new System.EventHandler(this.ShellForm_Load);
			this.sbrMain.ResumeLayout(false);
			this.sbrMain.PerformLayout();
			this.mbrMain.ResumeLayout(false);
			this.mbrMain.PerformLayout();
			this.spcMain.Panel1.ResumeLayout(false);
			this.spcMain.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
			this.spcMain.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip sbrMain;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus;
		private System.Windows.Forms.MenuStrip mbrMain;
		private System.Windows.Forms.ToolStripMenuItem mnuFile;
		private System.Windows.Forms.ToolStripMenuItem mnuTools;
		private System.Windows.Forms.ToolStrip tbrMain;
		private System.Windows.Forms.SplitContainer spcMain;
		private Symbion.TabWorkspace tabWorkspace;
		private Symbion.WindowWorkspace windowWorkspace;
	}
}

