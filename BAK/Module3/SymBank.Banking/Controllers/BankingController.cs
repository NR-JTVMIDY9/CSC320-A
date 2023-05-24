using System;
using System.Collections.Generic;
using SymBank.Banking.Controllers;
using SymBank.Banking.Models;
using System.Linq;
using Symbion;
using System.Threading.Tasks;

[Service(typeof(IAccountController))]
[Service(typeof(ITransactionController))]
[Service(typeof(IAsyncAccountController))]
public class BankingController :
	BaseService,
	IAccountController,
	IAsyncAccountController,
	ITransactionController {

	[Inject]public IAuthorization Authorization { get; set; }

	public BankingController() {
		this.Inject();
	}
	public void Add(Account item) {
		var dc = new SymBankDataContext();
		dc.AccountAdd(item.Code,
			item.Type, item.Name,
			item.ZipCode, Authorization.UserName,
			DateTime.Now, item.Balance);
	}

	public Task AddAsync(Account item) {
		var task = new Task(() => {
			var dc = new SymBankDataContext();
			dc.AccountAdd(item.Code,
				item.Type, item.Name,
				item.ZipCode, Authorization.UserName,
				DateTime.Now, item.Balance);
		});
		task.Start();
		return task;
	}

	public Account GetAccount(int code) {
		var dc = new SymBankDataContext();
		return dc.Accounts.SingleOrDefault(a => a.Code == code);
	}

	public Task<Account> GetAccountAsync(int code) {
		var task = new Task<Account>(() => {
			var dc = new SymBankDataContext();
			return dc.Accounts.SingleOrDefault(a => a.Code == code);
		});
		task.Start();
		return task;
	}

	public List<Account> GetAccountList() {
		var dc = new SymBankDataContext();
		return dc.Accounts.ToList();
	}

	public Task<List<Account>> GetAccountListAsync() {
		var task = new Task<List<Account>>(() => {
			var dc = new SymBankDataContext();
			return dc.Accounts.ToList();
		});
		task.Start();
		return task;
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
		var task = new Task<List<Account>>(() => {
			name = name.ToLower();
			var dc = new SymBankDataContext();
			var query = from account in dc.Accounts
						where account.Name.ToLower().Contains(name)
						orderby account.Name
						select account;
			return query.ToList();
		});
		task.Start();
		return task;
	}

	public int Debit(int source, decimal amount) {
		int? transactionCode = null;
		var dc = new SymBankDataContext();
		dc.AccountDebit(source, amount, Authorization.UserName,
			DateTime.Now, ref transactionCode);
		return (int)transactionCode;
	}

	public int Credit(int source, decimal amount) {
		int? transactionCode = null;
		var dc = new SymBankDataContext();
		dc.AccountCredit(source, amount, Authorization.UserName,
			DateTime.Now, ref transactionCode);
		return (int)transactionCode;
	}

	public int Transfer(int source, int target, decimal amount) {
		int? transactionCode = null;
		var dc = new SymBankDataContext();
		dc.AccountTransfer(source, target, amount, Authorization.UserName,
			DateTime.Now, ref transactionCode);
		return (int)transactionCode;
	}
}
