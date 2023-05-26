using SymBank.Banking.Models;
using Symbion;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SymBank.Banking.Services {
	public interface IAsyncAccountController : IService {
		Task AddAsync(Account account);
		Task<Account> GetAccountAsync(int code);
		Task<List<Account>> GetAccountListAsync();
		Task<List<Account>> GetAccountsForNameAsync(string name);
	}
}
