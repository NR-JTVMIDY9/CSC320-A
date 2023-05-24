using SymBank.Banking.Models;
using Symbion;
using System.Collections.Generic;

namespace SymBank.Banking.Controllers {
	public interface IAccountController : IService {
		void Add(Account item);
		Account GetAccount(int code);
		List<Account> GetAccountList();
		List<Account> GetAccountsForName(string name);
	}
}
