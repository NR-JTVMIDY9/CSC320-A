using Symbion;

namespace SymBank.Banking.Controllers {
	public interface ITransactionController : IService {
		int Debit(int source, decimal amount);
		int Credit(int source, decimal amount);
		int Transfer(int source, int target, decimal amount);
	}
}