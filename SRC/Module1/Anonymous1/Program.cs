using Symbion;
using System;

namespace Anonymous1 {
	class Program {
//		static void showAccount(object obj) {
//			obj.DisplayProperties();
//		}
		static void showAccount(dynamic obj) {
			Console.WriteLine(obj.ID);
			Console.WriteLine(obj.Name);
			Console.WriteLine(obj.Balance);
		}
		static void Main() {
			var account = new {
				ID = 101,
				Name = "ABC Trading",
				Balance = 50000m
			};
			//Console.WriteLine(account.ID);
			//Console.WriteLine(account.Name);
			//Console.WriteLine(account.Balance);
			showAccount(account);
		}
	}
}
