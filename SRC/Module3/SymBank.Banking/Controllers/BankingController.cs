using System;
using System.Collections.Generic;
using SymBank.Banking.Models;
using SymBank.Banking.Services;
using Symbion;
using System.Linq;
using System.Threading.Tasks;

namespace SymBank.Banking.Controllers {
	[Service(typeof(IAccountController))]
	[Service(typeof(ITransactionController))]
	[Service(typeof(IAsyncAccountController))]
	//	[Service(ServiceType = typeof(IAccountController))]
	//	[Service(ServiceType = typeof(ITransactionController))]
	public class BankingController : BaseService,
		IAccountController,
		ITransactionController,
		IAsyncAccountController {

		[Inject]public IAuthorization Authorization { get; set; }

		public BankingController() {
			this.Inject();
		}

		public void Add(Account account) {
			var dc = new SymBankDataContext();
			dc.AccountAdd(account.Code, account.Type,
				account.Name, account.ZipCode, Authorization.UserName,
				DateTime.Now, account.Balance, null);
		}

		public Task AddAsync(Account account) {
			var task = new Task(() => Add(account));
			task.Start(); return task;
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

		public Task<Account> GetAccountAsync(int code) {
			var task = new Task<Account>(() => GetAccount(code));
			task.Start(); return task;
		}

		public List<Account> GetAccountList() {
			var dc = new SymBankDataContext();
			return dc.Accounts.ToList();
		}

		public Task<List<Account>> GetAccountListAsync() {
			var task = new Task<List<Account>>(() => GetAccountList());
			task.Start(); return task;
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

		public Task<List<Account>> GetAccountsForNameAsync(string name) {
			var task = new Task<List<Account>>(() => GetAccountsForName(name));
			task.Start(); return task;
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
