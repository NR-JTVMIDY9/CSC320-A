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
			this.btnFind = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.cbxType = new System.Windows.Forms.ComboBox();
			this.accountSource = new System.Windows.Forms.BindingSource(this.components);
			this.txtZipCode = new System.Windows.Forms.TextBox();
			this.txtBalance = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtCode = new System.Windows.Forms.TextBox();
			this.lblZipCode = new System.Windows.Forms.Label();
			this.lblBalance = new System.Windows.Forms.Label();
			this.lblType = new System.Windows.Forms.Label();
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
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
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
			resources.ApplyResources(this.grpAccount, "grpAccount");
			this.grpAccount.Controls.Add(this.btnFind);
			this.grpAccount.Controls.Add(this.btnAdd);
			this.grpAccount.Controls.Add(this.cbxType);
			this.grpAccount.Controls.Add(this.txtZipCode);
			this.grpAccount.Controls.Add(this.txtBalance);
			this.grpAccount.Controls.Add(this.txtName);
			this.grpAccount.Controls.Add(this.txtCode);
			this.grpAccount.Controls.Add(this.lblZipCode);
			this.grpAccount.Controls.Add(this.lblBalance);
			this.grpAccount.Controls.Add(this.lblType);
			this.grpAccount.Controls.Add(this.lblName);
			this.grpAccount.Controls.Add(this.lblCode);
			this.errorProvider.SetError(this.grpAccount, resources.GetString("grpAccount.Error"));
			this.errorProvider.SetIconAlignment(this.grpAccount, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("grpAccount.IconAlignment"))));
			this.errorProvider.SetIconPadding(this.grpAccount, ((int)(resources.GetObject("grpAccount.IconPadding"))));
			this.grpAccount.Name = "grpAccount";
			this.grpAccount.TabStop = false;
			// 
			// btnFind
			// 
			resources.ApplyResources(this.btnFind, "btnFind");
			this.btnFind.CausesValidation = false;
			this.errorProvider.SetError(this.btnFind, resources.GetString("btnFind.Error"));
			this.errorProvider.SetIconAlignment(this.btnFind, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnFind.IconAlignment"))));
			this.errorProvider.SetIconPadding(this.btnFind, ((int)(resources.GetObject("btnFind.IconPadding"))));
			this.btnFind.Name = "btnFind";
			this.btnFind.UseVisualStyleBackColor = true;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// btnAdd
			// 
			resources.ApplyResources(this.btnAdd, "btnAdd");
			this.errorProvider.SetError(this.btnAdd, resources.GetString("btnAdd.Error"));
			this.errorProvider.SetIconAlignment(this.btnAdd, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnAdd.IconAlignment"))));
			this.errorProvider.SetIconPadding(this.btnAdd, ((int)(resources.GetObject("btnAdd.IconPadding"))));
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// cbxType
			// 
			resources.ApplyResources(this.cbxType, "cbxType");
			this.cbxType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.accountSource, "Type", true));
			this.cbxType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountSource, "Type", true));
			this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.errorProvider.SetError(this.cbxType, resources.GetString("cbxType.Error"));
			this.cbxType.FormattingEnabled = true;
			this.errorProvider.SetIconAlignment(this.cbxType, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cbxType.IconAlignment"))));
			this.errorProvider.SetIconPadding(this.cbxType, ((int)(resources.GetObject("cbxType.IconPadding"))));
			this.cbxType.Name = "cbxType";
			// 
			// accountSource
			// 
			this.accountSource.DataSource = typeof(SymBank.Banking.Models.Account);
			// 
			// txtZipCode
			// 
			resources.ApplyResources(this.txtZipCode, "txtZipCode");
			this.txtZipCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountSource, "ZipCode", true));
			this.errorProvider.SetError(this.txtZipCode, resources.GetString("txtZipCode.Error"));
			this.errorProvider.SetIconAlignment(this.txtZipCode, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtZipCode.IconAlignment"))));
			this.errorProvider.SetIconPadding(this.txtZipCode, ((int)(resources.GetObject("txtZipCode.IconPadding"))));
			this.txtZipCode.Name = "txtZipCode";
			// 
			// txtBalance
			// 
			resources.ApplyResources(this.txtBalance, "txtBalance");
			this.txtBalance.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountSource, "Balance", true));
			this.errorProvider.SetError(this.txtBalance, resources.GetString("txtBalance.Error"));
			this.errorProvider.SetIconAlignment(this.txtBalance, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBalance.IconAlignment"))));
			this.errorProvider.SetIconPadding(this.txtBalance, ((int)(resources.GetObject("txtBalance.IconPadding"))));
			this.txtBalance.Name = "txtBalance";
			// 
			// txtName
			// 
			resources.ApplyResources(this.txtName, "txtName");
			this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountSource, "Name", true));
			this.errorProvider.SetError(this.txtName, resources.GetString("txtName.Error"));
			this.errorProvider.SetIconAlignment(this.txtName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtName.IconAlignment"))));
			this.errorProvider.SetIconPadding(this.txtName, ((int)(resources.GetObject("txtName.IconPadding"))));
			this.txtName.Name = "txtName";
			this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
			this.txtName.Validated += new System.EventHandler(this.txtName_Validated);
			// 
			// txtCode
			// 
			resources.ApplyResources(this.txtCode, "txtCode");
			this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountSource, "Code", true));
			this.errorProvider.SetError(this.txtCode, resources.GetString("txtCode.Error"));
			this.errorProvider.SetIconAlignment(this.txtCode, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtCode.IconAlignment"))));
			this.errorProvider.SetIconPadding(this.txtCode, ((int)(resources.GetObject("txtCode.IconPadding"))));
			this.txtCode.Name = "txtCode";
			// 
			// lblZipCode
			// 
			resources.ApplyResources(this.lblZipCode, "lblZipCode");
			this.errorProvider.SetError(this.lblZipCode, resources.GetString("lblZipCode.Error"));
			this.errorProvider.SetIconAlignment(this.lblZipCode, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblZipCode.IconAlignment"))));
			this.errorProvider.SetIconPadding(this.lblZipCode, ((int)(resources.GetObject("lblZipCode.IconPadding"))));
			this.lblZipCode.Name = "lblZipCode";
			// 
			// lblBalance
			// 
			resources.ApplyResources(this.lblBalance, "lblBalance");
			this.errorProvider.SetError(this.lblBalance, resources.GetString("lblBalance.Error"));
			this.errorProvider.SetIconAlignment(this.lblBalance, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblBalance.IconAlignment"))));
			this.errorProvider.SetIconPadding(this.lblBalance, ((int)(resources.GetObject("lblBalance.IconPadding"))));
			this.lblBalance.Name = "lblBalance";
			// 
			// lblType
			// 
			resources.ApplyResources(this.lblType, "lblType");
			this.errorProvider.SetError(this.lblType, resources.GetString("lblType.Error"));
			this.errorProvider.SetIconAlignment(this.lblType, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblType.IconAlignment"))));
			this.errorProvider.SetIconPadding(this.lblType, ((int)(resources.GetObject("lblType.IconPadding"))));
			this.lblType.Name = "lblType";
			// 
			// lblName
			// 
			resources.ApplyResources(this.lblName, "lblName");
			this.errorProvider.SetError(this.lblName, resources.GetString("lblName.Error"));
			this.errorProvider.SetIconAlignment(this.lblName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblName.IconAlignment"))));
			this.errorProvider.SetIconPadding(this.lblName, ((int)(resources.GetObject("lblName.IconPadding"))));
			this.lblName.Name = "lblName";
			// 
			// lblCode
			// 
			resources.ApplyResources(this.lblCode, "lblCode");
			this.errorProvider.SetError(this.lblCode, resources.GetString("lblCode.Error"));
			this.errorProvider.SetIconAlignment(this.lblCode, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblCode.IconAlignment"))));
			this.errorProvider.SetIconPadding(this.lblCode, ((int)(resources.GetObject("lblCode.IconPadding"))));
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
			this.errorProvider.SetError(this.grpTransaction, resources.GetString("grpTransaction.Error"));
			this.errorProvider.SetIconAlignment(this.grpTransaction, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("grpTransaction.IconAlignment"))));
			this.errorProvider.SetIconPadding(this.grpTransaction, ((int)(resources.GetObject("grpTransaction.IconPadding"))));
			this.grpTransaction.Name = "grpTransaction";
			this.grpTransaction.TabStop = false;
			// 
			// btnTransfer
			// 
			resources.ApplyResources(this.btnTransfer, "btnTransfer");
			this.errorProvider.SetError(this.btnTransfer, resources.GetString("btnTransfer.Error"));
			this.errorProvider.SetIconAlignment(this.btnTransfer, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnTransfer.IconAlignment"))));
			this.errorProvider.SetIconPadding(this.btnTransfer, ((int)(resources.GetObject("btnTransfer.IconPadding"))));
			this.btnTransfer.Name = "btnTransfer";
			this.btnTransfer.UseVisualStyleBackColor = true;
			this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
			// 
			// btnCredit
			// 
			resources.ApplyResources(this.btnCredit, "btnCredit");
			this.errorProvider.SetError(this.btnCredit, resources.GetString("btnCredit.Error"));
			this.errorProvider.SetIconAlignment(this.btnCredit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCredit.IconAlignment"))));
			this.errorProvider.SetIconPadding(this.btnCredit, ((int)(resources.GetObject("btnCredit.IconPadding"))));
			this.btnCredit.Name = "btnCredit";
			this.btnCredit.UseVisualStyleBackColor = true;
			this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
			// 
			// btnDebit
			// 
			resources.ApplyResources(this.btnDebit, "btnDebit");
			this.errorProvider.SetError(this.btnDebit, resources.GetString("btnDebit.Error"));
			this.errorProvider.SetIconAlignment(this.btnDebit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnDebit.IconAlignment"))));
			this.errorProvider.SetIconPadding(this.btnDebit, ((int)(resources.GetObject("btnDebit.IconPadding"))));
			this.btnDebit.Name = "btnDebit";
			this.btnDebit.UseVisualStyleBackColor = true;
			this.btnDebit.Click += new System.EventHandler(this.btnDebit_Click);
			// 
			// txtAmount
			// 
			resources.ApplyResources(this.txtAmount, "txtAmount");
			this.errorProvider.SetError(this.txtAmount, resources.GetString("txtAmount.Error"));
			this.errorProvider.SetIconAlignment(this.txtAmount, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtAmount.IconAlignment"))));
			this.errorProvider.SetIconPadding(this.txtAmount, ((int)(resources.GetObject("txtAmount.IconPadding"))));
			this.txtAmount.Name = "txtAmount";
			// 
			// txtTarget
			// 
			resources.ApplyResources(this.txtTarget, "txtTarget");
			this.errorProvider.SetError(this.txtTarget, resources.GetString("txtTarget.Error"));
			this.errorProvider.SetIconAlignment(this.txtTarget, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtTarget.IconAlignment"))));
			this.errorProvider.SetIconPadding(this.txtTarget, ((int)(resources.GetObject("txtTarget.IconPadding"))));
			this.txtTarget.Name = "txtTarget";
			// 
			// txtSource
			// 
			resources.ApplyResources(this.txtSource, "txtSource");
			this.errorProvider.SetError(this.txtSource, resources.GetString("txtSource.Error"));
			this.errorProvider.SetIconAlignment(this.txtSource, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtSource.IconAlignment"))));
			this.errorProvider.SetIconPadding(this.txtSource, ((int)(resources.GetObject("txtSource.IconPadding"))));
			this.txtSource.Name = "txtSource";
			// 
			// lblAmount
			// 
			resources.ApplyResources(this.lblAmount, "lblAmount");
			this.errorProvider.SetError(this.lblAmount, resources.GetString("lblAmount.Error"));
			this.errorProvider.SetIconAlignment(this.lblAmount, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblAmount.IconAlignment"))));
			this.errorProvider.SetIconPadding(this.lblAmount, ((int)(resources.GetObject("lblAmount.IconPadding"))));
			this.lblAmount.Name = "lblAmount";
			// 
			// lblTarget
			// 
			resources.ApplyResources(this.lblTarget, "lblTarget");
			this.errorProvider.SetError(this.lblTarget, resources.GetString("lblTarget.Error"));
			this.errorProvider.SetIconAlignment(this.lblTarget, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblTarget.IconAlignment"))));
			this.errorProvider.SetIconPadding(this.lblTarget, ((int)(resources.GetObject("lblTarget.IconPadding"))));
			this.lblTarget.Name = "lblTarget";
			// 
			// lblSource
			// 
			resources.ApplyResources(this.lblSource, "lblSource");
			this.errorProvider.SetError(this.lblSource, resources.GetString("lblSource.Error"));
			this.errorProvider.SetIconAlignment(this.lblSource, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblSource.IconAlignment"))));
			this.errorProvider.SetIconPadding(this.lblSource, ((int)(resources.GetObject("lblSource.IconPadding"))));
			this.lblSource.Name = "lblSource";
			// 
			// pnlSearch
			// 
			resources.ApplyResources(this.pnlSearch, "pnlSearch");
			this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlSearch.Controls.Add(this.btnSearch);
			this.pnlSearch.Controls.Add(this.txtSearch);
			this.errorProvider.SetError(this.pnlSearch, resources.GetString("pnlSearch.Error"));
			this.errorProvider.SetIconAlignment(this.pnlSearch, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pnlSearch.IconAlignment"))));
			this.errorProvider.SetIconPadding(this.pnlSearch, ((int)(resources.GetObject("pnlSearch.IconPadding"))));
			this.pnlSearch.Name = "pnlSearch";
			// 
			// btnSearch
			// 
			resources.ApplyResources(this.btnSearch, "btnSearch");
			this.btnSearch.CausesValidation = false;
			this.errorProvider.SetError(this.btnSearch, resources.GetString("btnSearch.Error"));
			this.errorProvider.SetIconAlignment(this.btnSearch, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSearch.IconAlignment"))));
			this.errorProvider.SetIconPadding(this.btnSearch, ((int)(resources.GetObject("btnSearch.IconPadding"))));
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtSearch
			// 
			resources.ApplyResources(this.txtSearch, "txtSearch");
			this.errorProvider.SetError(this.txtSearch, resources.GetString("txtSearch.Error"));
			this.errorProvider.SetIconAlignment(this.txtSearch, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtSearch.IconAlignment"))));
			this.errorProvider.SetIconPadding(this.txtSearch, ((int)(resources.GetObject("txtSearch.IconPadding"))));
			this.txtSearch.Name = "txtSearch";
			// 
			// grdAccounts
			// 
			resources.ApplyResources(this.grdAccounts, "grdAccounts");
			this.grdAccounts.AllowUserToAddRows = false;
			this.grdAccounts.AllowUserToDeleteRows = false;
			this.grdAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.errorProvider.SetError(this.grdAccounts, resources.GetString("grdAccounts.Error"));
			this.errorProvider.SetIconAlignment(this.grdAccounts, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("grdAccounts.IconAlignment"))));
			this.errorProvider.SetIconPadding(this.grdAccounts, ((int)(resources.GetObject("grdAccounts.IconPadding"))));
			this.grdAccounts.Name = "grdAccounts";
			this.grdAccounts.ReadOnly = true;
			this.grdAccounts.RowTemplate.Height = 33;
			this.grdAccounts.SelectionChanged += new System.EventHandler(this.grdAccounts_SelectionChanged);
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			resources.ApplyResources(this.errorProvider, "errorProvider");
			// 
			// AccountsView
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.Controls.Add(this.grdAccounts);
			this.Controls.Add(this.pnlSearch);
			this.Controls.Add(this.grpTransaction);
			this.Controls.Add(this.grpAccount);
			this.errorProvider.SetError(this, resources.GetString("$this.Error"));
			this.errorProvider.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment"))));
			this.errorProvider.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding"))));
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
		private System.Windows.Forms.ComboBox cbxType;
		private System.Windows.Forms.TextBox txtZipCode;
		private System.Windows.Forms.TextBox txtBalance;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtCode;
		private System.Windows.Forms.Label lblZipCode;
		private System.Windows.Forms.Label lblBalance;
		private System.Windows.Forms.Label lblType;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblCode;
		private System.Windows.Forms.GroupBox grpTransaction;
		private System.Windows.Forms.Panel pnlSearch;
		private System.Windows.Forms.Label lblAmount;
		private System.Windows.Forms.Label lblTarget;
		private System.Windows.Forms.Label lblSource;
		private System.Windows.Forms.Button btnTransfer;
		private System.Windows.Forms.Button btnCredit;
		private System.Windows.Forms.Button btnDebit;
		private System.Windows.Forms.TextBox txtAmount;
		private System.Windows.Forms.TextBox txtTarget;
		private System.Windows.Forms.TextBox txtSource;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.DataGridView grdAccounts;
		private System.Windows.Forms.BindingSource accountSource;
		private System.Windows.Forms.ErrorProvider errorProvider;
	}
}
