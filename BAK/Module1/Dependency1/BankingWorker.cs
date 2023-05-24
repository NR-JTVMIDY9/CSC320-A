using SymBank.Banking.Controllers;
using Symbion;

public class BankingWorker : IService {
	[Inject]public IAccountController Account { get; set; }
	[Inject]public ITransactionController Transaction { get; set; }

	public BankingWorker(
		IAccountController account,
		ITransactionController transaction) {
		Account = account;
		Transaction = transaction;
	}

	public BankingWorker() { this.Inject(); }
}
