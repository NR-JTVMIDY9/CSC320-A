using SymBank.Banking.Models;
using SymBank.Banking.Services;
using Symbion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SymBank.Banking.Views {
	public partial class AccountsView : BaseView {
		[Inject]public IAuthorization Authorization { get; set; }
		[Inject]public IAccountController AccountController { get; set; }
		[Inject]public ITransactionController TransactionController { get; set; }

		//	private Account _account;

		public AccountsView() {
			InitializeComponent();
			cbxType.DataSource = Enum.GetValues(typeof(AccountType));
			Caption = "Accounts";
			ClearAccount();
			this.Inject();
		}

		private void ClearAccount() {
			Account = new Account { Name = "New Account" };
		//	accountSource.DataSource = _account;
		//	cbxType.SelectedIndex = 0;
			//	txtCode.Text = string.Empty;
			//	txtName.Text = string.Empty;
			//	txtZipCode.Text = string.Empty;
			//	txtBalance.Text = "0";
			txtCode.Focus();
		}

		private void ClearTransaction() {
			txtSource.Text = string.Empty;
			txtTarget.Text = string.Empty;
			txtAmount.Text = "0";
			txtSource.Focus();
		}

		public void ClearErrors() {
			errorProvider.SetError(txtCode, null);
			errorProvider.SetError(txtName, null);
			errorProvider.SetError(txtBalance, null);
			errorProvider.SetError(txtZipCode, null);
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			try {
				ClearErrors();
				txtCode.NotEmpty("Account code");
				txtName.NotEmpty("Account name");
				txtName.Length("Account name length", 4, 30);
				txtBalance.InRange("Opening balance", 100m, 999999m);
				txtZipCode.Matches("Zip code", "^\\d{5}$");
				//var item = new Account {
				//	Code = int.Parse(txtCode.Text),
				//	Name = txtName.Text,
				//	Type = cbxType.SelectedIndex,
				//	ZipCode = txtZipCode.Text,
				//	Balance = decimal.Parse(txtBalance.Text)
				//};
				//	Account.Type = (AccountType)cbxType.SelectedIndex;
				AccountController.Add(Account);
				var message = $"Account {Account.Code} added.";
				Shell.Status = message;
				Shell.Success(message);
				ClearAccount();
			}
			catch (ValidationException ex) {
				//	Shell.Failure("Cannot add account. " + ex.Message);
				ex.SetError(errorProvider);
				//	ex.Refocus();
			}
			catch (Exception ex) {
				Shell.Failure("Cannot add account. " + ex.Message);
			}
		}

		public Account Account {
			get {
				return (Account)accountSource.DataSource;
			}
			set {
				accountSource.DataSource = value;
			//	cbxType.SelectedIndex = (int)value.Type;
			}
		}

		private void btnFind_Click(object sender, EventArgs e) {
			try {
				var code = int.Parse(txtCode.Text);
				Account = AccountController.GetAccount(code);
				if (Account == null) throw new Exception("Invalid account code.");
				//	cbxType.SelectedIndex = Account.Type;
				//	accountSource.DataSource = Account;
				//	txtCode.Text = _account.Code.ToString();
				//	txtName.Text = _account.Name;
				//	txtZipCode.Text = _account.ZipCode;
				//	txtBalance.Text = _acount.Balance.ToString();
				Shell.Status = $"Found account {Account.Code}.";
				txtCode.Focus();
			}
			catch (Exception ex) {
				Shell.Failure("Cannot find account. " + ex.Message);
				ClearAccount();
			}
		}

		private void btnDebit_Click(object sender, EventArgs e) {
			try {
				var source = int.Parse(txtSource.Text);
				var amount = decimal.Parse(txtAmount.Text);
				var result = TransactionController.Debit(source, amount);
				var message1 = $"Account {source} debited with {amount:N2}.";
				var message2 = message1 + $"\nTransaction code is {result}.";
				Shell.Status = message1;
				Shell.Success(message2);

			//	Finds and displays account after debit
				txtCode.Text = source.ToString();
				btnFind_Click(sender, e);

				ClearTransaction();
			}
			catch (Exception ex) {
				Shell.Failure("Cannot debit account. " + ex.Message);
			}
		}

		private void btnCredit_Click(object sender, EventArgs e) {
			try {
				var source = int.Parse(txtSource.Text);
				var amount = decimal.Parse(txtAmount.Text);
				var result = TransactionController.Credit(source, amount);
				var message1 = $"Account {source} credited with {amount:N2}.";
				var message2 = message1 + $"\nTransaction code is {result}.";
				Shell.Status = message1;
				Shell.Success(message2);

				//	Finds and displays account after debit
				txtCode.Text = source.ToString();
				btnFind_Click(sender, e);

				ClearTransaction();
			}
			catch (Exception ex) {
				Shell.Failure("Cannot credit account. " + ex.Message);
			}
		}

		private void btnTransfer_Click(object sender, EventArgs e) {
			try {
				var source = int.Parse(txtSource.Text);
				var target = int.Parse(txtTarget.Text);
				var amount = decimal.Parse(txtAmount.Text);
				var result = TransactionController.Transfer(source, target, amount);
				var message1 = $"Transferred {amount:N2} from account {source} to {target}.";
				var message2 = message1 + $"\nTransaction code is {result}.";
				Shell.Status = message1;
				Shell.Success(message2);

				//	Finds and displays account after debit
				txtCode.Text = source.ToString();
				btnFind_Click(sender, e);

				ClearTransaction();
			}
			catch (Exception ex) {
				Shell.Failure("Cannot transfer amount. " + ex.Message);
			}
		}

		private void btnSearch_Click(object sender, EventArgs e) {
			try {
				var name = txtSearch.Text.Trim();
				var results = AccountController.GetAccountsForName(name);
				grdAccounts.DataSource = results;
			}
			catch (Exception ex) {
				Shell.Failure("Search failed. " + ex.Message);
			}
			finally {
				txtSearch.Focus();
			}
		}

		private void grdAccounts_SelectionChanged(object sender, EventArgs e) {
			try {
				//	Account = (Account) grdAccounts.CurrentRow.DataBoundItem;
				var code = int.Parse(grdAccounts.CurrentRow.Cells[0].Value.ToString());
				Account = AccountController.GetAccount(code);
				//	cbxType.SelectedIndex = Account.Type
			}
			catch { }
			

		}

		private void txtName_Validating(object sender, CancelEventArgs e) {
			var text = txtName.Text.Trim();
			txtName.Text = text;
			if (text.Length <= 3) {
				//	Shell.Failure("Name must be more than 3 characters.");
				errorProvider.SetError(txtName,
					"Name must be more than 3 characters.");
				e.Cancel = true;
			}
		}

		private void txtName_Validated(object sender, EventArgs e) {
			errorProvider.SetError(txtName, null);
		}
	}
}
