
using SymBank.Banking.Controllers;
using Symbion;

[Service(typeof(IAccountController))]
[Service(typeof(ITransactionController))]
public class BankingController :
	IAccountController,
	ITransactionController {

}
