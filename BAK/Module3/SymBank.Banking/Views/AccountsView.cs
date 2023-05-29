using SymBank.Banking.Controllers;
using SymBank.Banking.Models;
using Symbion;
using System;

namespace SymBank.Banking.Views {
	public partial class AccountsView : Symbion.BaseView {
		[Inject]public IAuthorization Authorization { get; set; }
		[Inject]public IAccountController AccountController { get; set; }
		[Inject]public ITransactionController TransactionController { get; set; }

		private Account _account;

		public AccountsView() {
			InitializeComponent();
			Caption = "Accounts";
			this.Inject();
			ClearAccount();
		}

		private void ClearAccount() {
			_account = new Account();
			accountSource.DataSource = _account;
			cbxType.SelectedIndex = _account.Type;
			//txtCode.Text = string.Empty;
			//txtName.Text = string.Empty;
			//	cbxType.SelectedIndex = 0;
			//txtZipCode.Text = string.Empty;
			//txtBalance.Text = "0";
			txtCode.Focus();
		}
		private void ClearTransaction() {
			txtSource.Text = string.Empty;
			txtTarget.Text = string.Empty;
			txtAmount.Text = "0";
			txtSource.Focus();
		}

		private void btnAdd_Click(object sender, System.EventArgs e) {
			try {
				//var item = new Account {
				//	Code = int.Parse(txtCode.Text),
				//	Name = txtName.Text,
				//	Type = cbxType.SelectedIndex,
				//	ZipCode = txtZipCode.Text,
				//	Balance = decimal.Parse(txtBalance.Text)
				//};
				txtBalance.InRange("Balance", 100m, decimal.MaxValue);
				_account.Type = cbxType.SelectedIndex;
				AccountController.Add(_account);
				var message = $"Account {_account.Code} added.";
				Shell.Status = message;
				Shell.Success(message);
				ClearAccount();
			}
			catch (ValidationException ex) {
				Shell.Failure("Validation failed. " + ex.Message);
				ex.Refocus();
			}
			catch (Exception ex) {
				Shell.Failure("Cannot add account. " + ex.Message);
			}
		}

		private void btnFind_Click(object sender, System.EventArgs e) {
			try {
				var item = AccountController.GetAccount(int.Parse(txtCode.Text));
				if (item == null) throw new Exception("Invalid account ID.");
				//txtCode.Text = item.Code.ToString();
				//txtName.Text = item.Name;
				cbxType.SelectedIndex = item.Type;
				//txtZipCode.Text = item.ZipCode;
				//txtBalance.Text = item.Balance.ToString();
				accountSource.DataSource = _account = item;
				Shell.Status = $"Found account {item.Code}.";
				txtCode.Focus();
			}
			catch (Exception ex) {
				Shell.Failure("Cannot find account. " + ex.Message);
				ClearAccount();
			}
		}

		private void btnDebit_Click(object sender, System.EventArgs e) {
			try {
				var source = int.Parse(txtSource.Text);
				var amount = decimal.Parse(txtAmount.Text);
				TransactionController.Debit(source, amount);
				var message = $"Account {source} debited with {amount:N2}";
				Shell.Success(message);
				Shell.Status = message;
				ClearTransaction();
			}
			catch (Exception ex) {
				Shell.Failure("Cannot debit account. " + ex.Message);
			}
		}

		private void btnCredit_Click(object sender, System.EventArgs e) {
			try {
				var source = int.Parse(txtSource.Text);
				var amount = decimal.Parse(txtAmount.Text);
				TransactionController.Credit(source, amount);
				var message = $"Account {source} credit with {amount:N2}";
				Shell.Success(message);
				Shell.Status = message;
				ClearTransaction();
			}
			catch (Exception ex) {
				Shell.Failure("Cannot credit account. " + ex.Message);
			}
		}

		private void btnTransfer_Click(object sender, System.EventArgs e) {
			try {
				var source = int.Parse(txtSource.Text);
				var target = int.Parse(txtTarget.Text);
				var amount = decimal.Parse(txtAmount.Text);
				TransactionController.Credit(source, amount);
				var message = $"Transfered {amount:N2} from account {source} to {target}.";
				Shell.Success(message);
				Shell.Status = message;
				ClearTransaction();
			}
			catch (Exception ex) {
				Shell.Failure("Cannot transfer amount. " + ex.Message);
			}
		}

		private void btnSearch_Click(object sender, System.EventArgs e) {
			try {
				var results = AccountController.GetAccountsForName(txtSearch.Text);
				grdAccounts.DataSource = results;
			}
			catch (Exception ex) {
				Shell.Failure("Search failed. " + ex.Message);
			}
		}

		private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
			var text = txtName.Text.Trim();
			if (text.Length <= 3) {
				errorProvider.SetError(txtName,
					"Account name must be more the 3 characters.");
				e.Cancel = true;
			}
		}

		private void txtName_Validated(object sender, EventArgs e) {
			errorProvider.SetError(txtName, null);
		}
	}
}
