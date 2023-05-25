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
			this.sbrMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// sbrMain
			// 
			this.sbrMain.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.sbrMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
			this.sbrMain.Location = new System.Drawing.Point(0, 357);
			this.sbrMain.Name = "sbrMain";
			this.sbrMain.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
			this.sbrMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.sbrMain.Size = new System.Drawing.Size(423, 38);
			this.sbrMain.TabIndex = 0;
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Padding = new System.Windows.Forms.Padding(4);
			this.lblStatus.Size = new System.Drawing.Size(338, 33);
			this.lblStatus.Spring = true;
			this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ShellForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(423, 395);
			this.Controls.Add(this.sbrMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ShellForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SymBank";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShellForm_FormClosed);
			this.Load += new System.EventHandler(this.ShellForm_Load);
			this.sbrMain.ResumeLayout(false);
			this.sbrMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip sbrMain;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus;
	}
}

