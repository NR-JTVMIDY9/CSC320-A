using SymBank.Banking.Controllers;
using Symbion;

namespace SymBank.Banking {
	public class BankingModule : BaseModule {
		public override void Init() {
			var obj = new BankingController();
			obj.Add<IAccountController>();
			obj.Add<ITransactionController>();
		}
	}
}