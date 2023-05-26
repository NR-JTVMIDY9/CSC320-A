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
			this.sbrMain = new System.Windows.Forms.StatusStrip();
			this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.sbrMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// sbrMain
			// 
			this.sbrMain.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.sbrMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
			this.sbrMain.Location = new System.Drawing.Point(0, 289);
			this.sbrMain.Name = "sbrMain";
			this.sbrMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.sbrMain.Size = new System.Drawing.Size(757, 22);
			this.sbrMain.TabIndex = 0;
			this.sbrMain.Text = "statusStrip1";
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Padding = new System.Windows.Forms.Padding(4);
			this.lblStatus.Size = new System.Drawing.Size(680, 33);
			this.lblStatus.Spring = true;
			this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ShellForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(757, 311);
			this.Controls.Add(this.sbrMain);
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

