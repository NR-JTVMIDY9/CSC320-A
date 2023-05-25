using SymBank.Banking.Models;
using Symbion;
using System.Collections.Generic;

namespace SymBank.Banking.Services {
	public interface IAccountController : IService {
		void Add(Account account);
		Account GetAccount(int code);
		List<Account> GetAccountList();
		List<Account> GetAccountsForName(string name);
	}
}
