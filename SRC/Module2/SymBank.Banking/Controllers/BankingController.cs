using System;
using System.Collections.Generic;
using SymBank.Banking.Models;
using SymBank.Banking.Services;
using Symbion;
using System.Linq;

namespace SymBank.Banking.Controllers {
	[Service(typeof(IAccountController))]
	[Service(typeof(ITransactionController))]
	//	[Service(ServiceType = typeof(IAccountController))]
	//	[Service(ServiceType = typeof(ITransactionController))]
	public class BankingController : BaseService,
		IAccountController,
		ITransactionController {

		[Inject]public IAuthorization Authorization { get; set; }

		public BankingController() {
			this.Inject();
		}

		public void Add(Account account) {
			var dc = new SymBankDataContext();
			//dc.Accounts.InsertOnSubmit(account);
			//dc.SubmitChanges();
			dc.AccountAdd(account.Code, account.Type,
				account.Name, account.ZipCode, Authorization.UserName,
				DateTime.Now, account.Balance, null);
		}

		public int Credit(int source, decimal amount) {
			int? transactionCode = null;
			var dc = new SymBankDataContext();
			dc.AccountCredit(source, amount, Authorization.UserName,
				DateTime.Now, ref transactionCode);
			return (int)transactionCode;
		}

		public int Debit(int source, decimal amount) {
			int? transactionCode = null;
			var dc = new SymBankDataContext();
			dc.AccountDebit(source, amount, Authorization.UserName,
				DateTime.Now, ref transactionCode);
			return (int)transactionCode;
		}

		public Account GetAccount(int code) {
			var dc = new SymBankDataContext();
			return dc.Accounts.SingleOrDefault(a => a.Code == code);
		}

		public List<Account> GetAccountList() {
			var dc = new SymBankDataContext();
			return dc.Accounts.ToList();
		}

		public List<Account> GetAccountsForName(string name) {
			name = name.ToLower();
			var dc = new SymBankDataContext();
			var query = from account in dc.Accounts
						where account.Name.ToLower().Contains(name)
						orderby account.Name
						select account;
			return query.ToList();
		}

		public int Transfer(int source, int target, decimal amount) {
			int? transactionCode = null;
			var dc = new SymBankDataContext();
			dc.AccountTransfer(source, target, amount,
				Authorization.UserName,	DateTime.Now,
				ref transactionCode);
			return (int)transactionCode;
		}
	}
}
