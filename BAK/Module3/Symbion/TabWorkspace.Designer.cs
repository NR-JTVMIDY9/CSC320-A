namespace Symbion {
	partial class TabWorkspace {
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
			this.tabMain = new System.Windows.Forms.TabControl();
			this.SuspendLayout();
			// 
			// tbrMain
			// 
			this.tbrMain.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.tbrMain.Location = new System.Drawing.Point(0, 0);
			this.tbrMain.Name = "tbrMain";
			this.tbrMain.Size = new System.Drawing.Size(150, 25);
			this.tbrMain.TabIndex = 0;
			this.tbrMain.Text = "toolStrip1";
			// 
			// tabMain
			// 
			this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabMain.Location = new System.Drawing.Point(0, 25);
			this.tabMain.Name = "tabMain";
			this.tabMain.SelectedIndex = 0;
			this.tabMain.Size = new System.Drawing.Size(150, 125);
			this.tabMain.TabIndex = 1;
			// 
			// TabWorkspace
			// 
			this.Controls.Add(this.tabMain);
			this.Controls.Add(this.tbrMain);
			this.Name = "TabWorkspace";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip tbrMain;
		private System.Windows.Forms.TabControl tabMain;
	}
}
