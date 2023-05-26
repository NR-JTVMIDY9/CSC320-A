using System;
using System.Security.Cryptography;
using System.Text;

namespace Hashing1 {
	class Program {
		static void Main(string[] args) {
			HashAlgorithm ha = SHA256.Create(); // MD5.Create();
			Console.WriteLine(ha.HashSize);
			var originalPassword = "P@ssw0rd";
			var saltedPassword = $"@sym-{originalPassword}-456ABC";
			byte[] password = Encoding.UTF8.GetBytes(saltedPassword);
			originalPassword = null;

			byte[] hashedPassword = ha.ComputeHash(password);
			Console.WriteLine(BitConverter.ToString(hashedPassword));
			Console.WriteLine(Convert.ToBase64String(hashedPassword));
		}
	}
}
