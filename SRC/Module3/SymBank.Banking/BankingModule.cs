using SymBank.Banking.Controllers;
using SymBank.Banking.Services;
using SymBank.Banking.Views;
using Symbion;

namespace SymBank.Banking {
	public class BankingModule : BaseModule {
		public static Command Accounts = new Command {
			Caption = "&Accounts",
			Description = "Manage accounts",
			Icon = Resources.ApplicationForm,
			Action = command => {
				var view = new AccountsView();
				view.Show("TabSpace");
			}
		};

		public override void Init() {
			base.Init();

			Shell.Sites["FileMenu"].Add(Accounts);


		//	var obj = new BankingController();
		//	obj.Add<IAccountController>();
		//	obj.Add<ITransactionController>();
		}
	}
}
