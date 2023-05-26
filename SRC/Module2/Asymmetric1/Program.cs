using Symbion;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Asymmetric1 {
	class Program {
		static void Main() {
			CryptoHelper ch = new CryptoHelper();
			if (!File.Exists("MyKeys.xml")) {
				ch.Save("MyKeys.xml", true);
				ch.Save("PubKey.xml", false);
			}
			ch.Load("PubKey.xml");

			SymmetricAlgorithm sa = Aes.Create();
			string sk = Convert.ToBase64String(sa.Key) + ';' +
				Convert.ToBase64String(sa.IV);
			Console.WriteLine($"SymmetricKey:{sk}");
			byte[] encrypted = ch.Encrypt(sk);

			// send encrypted to server

			ch.Load("MyKeys.xml");
			string decrypted = ch.Decrypt(encrypted);
			Console.WriteLine($"SymmetricKey:{decrypted}");

			sa = Aes.Create();
			string[] fields = decrypted.Split(';');
			sa.Key = Convert.FromBase64String(fields[0]);
			sa.IV = Convert.FromBase64String(fields[1]);





		}
	}
}
