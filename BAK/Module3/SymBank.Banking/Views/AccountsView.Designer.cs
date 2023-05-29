namespace SymBank.Banking.Views {
	partial class AccountsView {
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountsView));
			this.grpAccount = new System.Windows.Forms.GroupBox();
			this.txtZipCode = new System.Windows.Forms.TextBox();
			this.accountSource = new System.Windows.Forms.BindingSource(this.components);
			this.lblZipCode = new System.Windows.Forms.Label();
			this.cbxType = new System.Windows.Forms.ComboBox();
			this.lblType = new System.Windows.Forms.Label();
			this.btnFind = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtBalance = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtCode = new System.Windows.Forms.TextBox();
			this.lblBalance = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblCode = new System.Windows.Forms.Label();
			this.grpTransaction = new System.Windows.Forms.GroupBox();
			this.btnTransfer = new System.Windows.Forms.Button();
			this.btnCredit = new System.Windows.Forms.Button();
			this.btnDebit = new System.Windows.Forms.Button();
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.txtTarget = new System.Windows.Forms.TextBox();
			this.txtSource = new System.Windows.Forms.TextBox();
			this.lblAmount = new System.Windows.Forms.Label();
			this.lblTarget = new System.Windows.Forms.Label();
			this.lblSource = new System.Windows.Forms.Label();
			this.pnlSearch = new System.Windows.Forms.Panel();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.grdAccounts = new System.Windows.Forms.DataGridView();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.grpAccount.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.accountSource)).BeginInit();
			this.grpTransaction.SuspendLayout();
			this.pnlSearch.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdAccounts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// grpAccount
			// 
			this.grpAccount.Controls.Add(this.txtZipCode);
			this.grpAccount.Controls.Add(this.lblZipCode);
			this.grpAccount.Controls.Add(this.cbxType);
			this.grpAccount.Controls.Add(this.lblType);
			this.grpAccount.Controls.Add(this.btnFind);
			this.grpAccount.Controls.Add(this.btnAdd);
			this.grpAccount.Controls.Add(this.txtBalance);
			this.grpAccount.Controls.Add(this.txtName);
			this.grpAccount.Controls.Add(this.txtCode);
			this.grpAccount.Controls.Add(this.lblBalance);
			this.grpAccount.Controls.Add(this.lblName);
			this.grpAccount.Controls.Add(this.lblCode);
			resources.ApplyResources(this.grpAccount, "grpAccount");
			this.grpAccount.Name = "grpAccount";
			this.grpAccount.TabStop = false;
			// 
			// txtZipCode
			// 
			this.txtZipCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountSource, "ZipCode", true));
			resources.ApplyResources(this.txtZipCode, "txtZipCode");
			this.txtZipCode.Name = "txtZipCode";
			// 
			// accountSource
			// 
			this.accountSource.DataSource = typeof(SymBank.Banking.Models.Account);
			// 
			// lblZipCode
			// 
			resources.ApplyResources(this.lblZipCode, "lblZipCode");
			this.lblZipCode.Name = "lblZipCode";
			// 
			// cbxType
			// 
			this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxType.FormattingEnabled = true;
			this.cbxType.Items.AddRange(new object[] {
            resources.GetString("cbxType.Items"),
            resources.GetString("cbxType.Items1"),
            resources.GetString("cbxType.Items2")});
			resources.ApplyResources(this.cbxType, "cbxType");
			this.cbxType.Name = "cbxType";
			// 
			// lblType
			// 
			resources.ApplyResources(this.lblType, "lblType");
			this.lblType.Name = "lblType";
			// 
			// btnFind
			// 
			this.btnFind.CausesValidation = false;
			resources.ApplyResources(this.btnFind, "btnFind");
			this.btnFind.Name = "btnFind";
			this.btnFind.UseVisualStyleBackColor = true;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// btnAdd
			// 
			resources.ApplyResources(this.btnAdd, "btnAdd");
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// txtBalance
			// 
			this.txtBalance.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountSource, "Balance", true));
			resources.ApplyResources(this.txtBalance, "txtBalance");
			this.txtBalance.Name = "txtBalance";
			// 
			// txtName
			// 
			this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountSource, "Name", true));
			resources.ApplyResources(this.txtName, "txtName");
			this.txtName.Name = "txtName";
			this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
			this.txtName.Validated += new System.EventHandler(this.txtName_Validated);
			// 
			// txtCode
			// 
			this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountSource, "Code", true));
			resources.ApplyResources(this.txtCode, "txtCode");
			this.txtCode.Name = "txtCode";
			// 
			// lblBalance
			// 
			resources.ApplyResources(this.lblBalance, "lblBalance");
			this.lblBalance.Name = "lblBalance";
			// 
			// lblName
			// 
			resources.ApplyResources(this.lblName, "lblName");
			this.lblName.Name = "lblName";
			// 
			// lblCode
			// 
			resources.ApplyResources(this.lblCode, "lblCode");
			this.lblCode.Name = "lblCode";
			// 
			// grpTransaction
			// 
			resources.ApplyResources(this.grpTransaction, "grpTransaction");
			this.grpTransaction.Controls.Add(this.btnTransfer);
			this.grpTransaction.Controls.Add(this.btnCredit);
			this.grpTransaction.Controls.Add(this.btnDebit);
			this.grpTransaction.Controls.Add(this.txtAmount);
			this.grpTransaction.Controls.Add(this.txtTarget);
			this.grpTransaction.Controls.Add(this.txtSource);
			this.grpTransaction.Controls.Add(this.lblAmount);
			this.grpTransaction.Controls.Add(this.lblTarget);
			this.grpTransaction.Controls.Add(this.lblSource);
			this.grpTransaction.Name = "grpTransaction";
			this.grpTransaction.TabStop = false;
			// 
			// btnTransfer
			// 
			resources.ApplyResources(this.btnTransfer, "btnTransfer");
			this.btnTransfer.Name = "btnTransfer";
			this.btnTransfer.UseVisualStyleBackColor = true;
			this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
			// 
			// btnCredit
			// 
			resources.ApplyResources(this.btnCredit, "btnCredit");
			this.btnCredit.Name = "btnCredit";
			this.btnCredit.UseVisualStyleBackColor = true;
			this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
			// 
			// btnDebit
			// 
			resources.ApplyResources(this.btnDebit, "btnDebit");
			this.btnDebit.Name = "btnDebit";
			this.btnDebit.UseVisualStyleBackColor = true;
			this.btnDebit.Click += new System.EventHandler(this.btnDebit_Click);
			// 
			// txtAmount
			// 
			resources.ApplyResources(this.txtAmount, "txtAmount");
			this.txtAmount.Name = "txtAmount";
			// 
			// txtTarget
			// 
			resources.ApplyResources(this.txtTarget, "txtTarget");
			this.txtTarget.Name = "txtTarget";
			// 
			// txtSource
			// 
			resources.ApplyResources(this.txtSource, "txtSource");
			this.txtSource.Name = "txtSource";
			// 
			// lblAmount
			// 
			resources.ApplyResources(this.lblAmount, "lblAmount");
			this.lblAmount.Name = "lblAmount";
			// 
			// lblTarget
			// 
			resources.ApplyResources(this.lblTarget, "lblTarget");
			this.lblTarget.Name = "lblTarget";
			// 
			// lblSource
			// 
			resources.ApplyResources(this.lblSource, "lblSource");
			this.lblSource.Name = "lblSource";
			// 
			// pnlSearch
			// 
			resources.ApplyResources(this.pnlSearch, "pnlSearch");
			this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlSearch.Controls.Add(this.txtSearch);
			this.pnlSearch.Controls.Add(this.btnSearch);
			this.pnlSearch.Name = "pnlSearch";
			// 
			// txtSearch
			// 
			resources.ApplyResources(this.txtSearch, "txtSearch");
			this.txtSearch.Name = "txtSearch";
			// 
			// btnSearch
			// 
			resources.ApplyResources(this.btnSearch, "btnSearch");
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// grdAccounts
			// 
			this.grdAccounts.AllowUserToAddRows = false;
			this.grdAccounts.AllowUserToDeleteRows = false;
			resources.ApplyResources(this.grdAccounts, "grdAccounts");
			this.grdAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdAccounts.Name = "grdAccounts";
			this.grdAccounts.ReadOnly = true;
			this.grdAccounts.RowTemplate.Height = 24;
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// AccountsView
			// 
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.grdAccounts);
			this.Controls.Add(this.pnlSearch);
			this.Controls.Add(this.grpTransaction);
			this.Controls.Add(this.grpAccount);
			this.Name = "AccountsView";
			this.grpAccount.ResumeLayout(false);
			this.grpAccount.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.accountSource)).EndInit();
			this.grpTransaction.ResumeLayout(false);
			this.grpTransaction.PerformLayout();
			this.pnlSearch.ResumeLayout(false);
			this.pnlSearch.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdAccounts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpAccount;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox txtBalance;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtCode;
		private System.Windows.Forms.Label lblBalance;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblCode;
		private System.Windows.Forms.GroupBox grpTransaction;
		private System.Windows.Forms.TextBox txtAmount;
		private System.Windows.Forms.TextBox txtTarget;
		private System.Windows.Forms.TextBox txtSource;
		private System.Windows.Forms.Label lblAmount;
		private System.Windows.Forms.Label lblTarget;
		private System.Windows.Forms.Label lblSource;
		private System.Windows.Forms.TextBox txtZipCode;
		private System.Windows.Forms.Label lblZipCode;
		private System.Windows.Forms.ComboBox cbxType;
		private System.Windows.Forms.Label lblType;
		private System.Windows.Forms.Button btnTransfer;
		private System.Windows.Forms.Button btnCredit;
		private System.Windows.Forms.Button btnDebit;
		private System.Windows.Forms.Panel pnlSearch;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.DataGridView grdAccounts;
		private System.Windows.Forms.BindingSource accountSource;
		private System.Windows.Forms.ErrorProvider errorProvider;
	}
}
