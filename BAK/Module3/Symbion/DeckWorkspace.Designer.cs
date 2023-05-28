namespace Symbion {
	partial class DeckWorkspace {
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
			this.btnActive = new Symbion.DeckButton();
			this.viewPanel = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// btnActive
			// 
			this.btnActive.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnActive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnActive.Location = new System.Drawing.Point(4, 4);
			this.btnActive.Name = "btnActive";
			this.btnActive.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
			this.btnActive.Size = new System.Drawing.Size(138, 32);
			this.btnActive.TabIndex = 0;
			this.btnActive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnActive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnActive.UseVisualStyleBackColor = true;
			this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
			// 
			// viewPanel
			// 
			this.viewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.viewPanel.Location = new System.Drawing.Point(4, 36);
			this.viewPanel.Name = "viewPanel";
			this.viewPanel.Size = new System.Drawing.Size(138, 106);
			this.viewPanel.TabIndex = 1;
			// 
			// DeckWorkspace
			// 
			this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Controls.Add(this.viewPanel);
			this.Controls.Add(this.btnActive);
			this.Name = "DeckWorkspace";
			this.Padding = new System.Windows.Forms.Padding(4);
			this.Size = new System.Drawing.Size(146, 146);
			this.ResumeLayout(false);

		}

		#endregion

		private DeckButton btnActive;
		private System.Windows.Forms.Panel viewPanel;
	}
}
