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
			this.sbrMain.SuspendLayout();
			this.mbrMain.SuspendLayout();
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
			// ShellForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(764, 473);
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
	}
}

