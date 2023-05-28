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
			this.windowWorkspace = new Symbion.WindowWorkspace();
			this.tabWorkspace = new Symbion.TabWorkspace();
			this.deckWorkspace = new Symbion.DeckWorkspace();
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
			this.sbrMain.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.sbrMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
			this.sbrMain.Location = new System.Drawing.Point(0, 451);
			this.sbrMain.Name = "sbrMain";
			this.sbrMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.sbrMain.Size = new System.Drawing.Size(764, 22);
			this.sbrMain.TabIndex = 0;
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Padding = new System.Windows.Forms.Padding(4);
			this.lblStatus.Size = new System.Drawing.Size(749, 17);
			this.lblStatus.Spring = true;
			this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// mbrMain
			// 
			this.mbrMain.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mbrMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuTools});
			this.mbrMain.Location = new System.Drawing.Point(0, 0);
			this.mbrMain.Name = "mbrMain";
			this.mbrMain.ShowItemToolTips = true;
			this.mbrMain.Size = new System.Drawing.Size(764, 28);
			this.mbrMain.TabIndex = 1;
			this.mbrMain.Text = "menuStrip1";
			// 
			// mnuFile
			// 
			this.mnuFile.Name = "mnuFile";
			this.mnuFile.Size = new System.Drawing.Size(44, 24);
			this.mnuFile.Text = "&File";
			// 
			// mnuTools
			// 
			this.mnuTools.Name = "mnuTools";
			this.mnuTools.Size = new System.Drawing.Size(56, 24);
			this.mnuTools.Text = "Too&ls";
			// 
			// tbrMain
			// 
			this.tbrMain.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.tbrMain.Location = new System.Drawing.Point(0, 28);
			this.tbrMain.Name = "tbrMain";
			this.tbrMain.Size = new System.Drawing.Size(764, 25);
			this.tbrMain.TabIndex = 2;
			// 
			// spcMain
			// 
			this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spcMain.Location = new System.Drawing.Point(0, 53);
			this.spcMain.Name = "spcMain";
			// 
			// spcMain.Panel1
			// 
			this.spcMain.Panel1.Controls.Add(this.deckWorkspace);
			this.spcMain.Panel1.Controls.Add(this.windowWorkspace);
			// 
			// spcMain.Panel2
			// 
			this.spcMain.Panel2.Controls.Add(this.tabWorkspace);
			this.spcMain.Size = new System.Drawing.Size(764, 398);
			this.spcMain.SplitterDistance = 254;
			this.spcMain.TabIndex = 3;
			// 
			// windowWorkspace
			// 
			this.windowWorkspace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.windowWorkspace.Dock = System.Windows.Forms.DockStyle.Top;
			this.windowWorkspace.Location = new System.Drawing.Point(0, 0);
			this.windowWorkspace.MinimumSize = new System.Drawing.Size(4, 35);
			this.windowWorkspace.Name = "windowWorkspace";
			this.windowWorkspace.Padding = new System.Windows.Forms.Padding(4);
			this.windowWorkspace.Size = new System.Drawing.Size(254, 35);
			this.windowWorkspace.TabIndex = 0;
			// 
			// tabWorkspace
			// 
			this.tabWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabWorkspace.Location = new System.Drawing.Point(0, 0);
			this.tabWorkspace.Name = "tabWorkspace";
			this.tabWorkspace.Size = new System.Drawing.Size(506, 398);
			this.tabWorkspace.TabIndex = 0;
			// 
			// deckWorkspace
			// 
			this.deckWorkspace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.deckWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
			this.deckWorkspace.Location = new System.Drawing.Point(0, 35);
			this.deckWorkspace.Name = "deckWorkspace";
			this.deckWorkspace.Padding = new System.Windows.Forms.Padding(4);
			this.deckWorkspace.Size = new System.Drawing.Size(254, 363);
			this.deckWorkspace.TabIndex = 1;
			// 
			// ShellForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(764, 473);
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
		private Symbion.DeckWorkspace deckWorkspace;
	}
}

