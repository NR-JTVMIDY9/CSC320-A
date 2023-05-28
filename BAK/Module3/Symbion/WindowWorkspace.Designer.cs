namespace Symbion {
	partial class WindowWorkspace {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowWorkspace));
			this.tbrMain = new System.Windows.Forms.ToolStrip();
			this.btnWindowList = new System.Windows.Forms.ToolStripDropDownButton();
			this.btnCloseAll = new System.Windows.Forms.ToolStripButton();
			this.tbrMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbrMain
			// 
			this.tbrMain.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.tbrMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnWindowList,
            this.btnCloseAll});
			this.tbrMain.Location = new System.Drawing.Point(4, 4);
			this.tbrMain.Name = "tbrMain";
			this.tbrMain.Size = new System.Drawing.Size(138, 27);
			this.tbrMain.TabIndex = 0;
			this.tbrMain.Text = "toolStrip1";
			// 
			// btnWindowList
			// 
			this.btnWindowList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnWindowList.Image = ((System.Drawing.Image)(resources.GetObject("btnWindowList.Image")));
			this.btnWindowList.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnWindowList.Name = "btnWindowList";
			this.btnWindowList.Size = new System.Drawing.Size(34, 24);
			// 
			// btnCloseAll
			// 
			this.btnCloseAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnCloseAll.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseAll.Image")));
			this.btnCloseAll.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnCloseAll.Name = "btnCloseAll";
			this.btnCloseAll.Size = new System.Drawing.Size(24, 24);
			this.btnCloseAll.Click += new System.EventHandler(this.btnCloseAll_Click);
			// 
			// WindowWorkspace
			// 
			this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Controls.Add(this.tbrMain);
			this.Name = "WindowWorkspace";
			this.Padding = new System.Windows.Forms.Padding(4);
			this.Size = new System.Drawing.Size(146, 32);
			this.tbrMain.ResumeLayout(false);
			this.tbrMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip tbrMain;
		private System.Windows.Forms.ToolStripDropDownButton btnWindowList;
		private System.Windows.Forms.ToolStripButton btnCloseAll;
	}
}
