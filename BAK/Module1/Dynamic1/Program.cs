using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic1 {
	class Program {
		static dynamic Add(dynamic v1, dynamic v2) {
			return v1 + v2;
		}

		static void Main() {
			Console.WriteLine(Add(99, 66));
			Console.WriteLine(Add(1.99, 66.1));
			Console.WriteLine(Add('C', 2));
			Console.WriteLine(Add("Hello!", "Goodbye!"));
			Console.WriteLine(Add(DateTime.Now, new TimeSpan(1, 2, 3, 4)));
		}
	}
}
