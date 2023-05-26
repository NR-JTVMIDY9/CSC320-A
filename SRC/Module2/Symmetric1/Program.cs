using System;
using System.IO;
using System.Security.Cryptography;

namespace Symmetric1 {
	class Program {
		static void Main(string[] args) {
			SymmetricAlgorithm sa = Aes.Create();
			if (!File.Exists("MyKey.bin")) {
				File.WriteAllBytes("MyKey.bin", sa.Key);
				File.WriteAllBytes("KeyIV.bin", sa.IV);
			}
			else {
				sa.Key = File.ReadAllBytes("MyKey.bin");
				sa.IV = File.ReadAllBytes("KeyIV.bin");
			}

			FileStream stream = new FileStream("secure.bin",
				FileMode.Create, FileAccess.Write);

			CryptoStream cstream = new CryptoStream(stream,
				sa.CreateEncryptor(), CryptoStreamMode.Write);

			StreamWriter writer = new StreamWriter(cstream);
			writer.WriteLine("This line will be encrypted!");

			writer.Close();
			cstream.Close();
			stream.Close();

			stream = new FileStream("secure.bin", FileMode.Open,
				FileAccess.Read);
			cstream = new CryptoStream(stream,
				sa.CreateDecryptor(), CryptoStreamMode.Read);
			StreamReader reader = new StreamReader(cstream);
			var text = reader.ReadLine();
			reader.Close();
			cstream.Close();
			stream.Close();

			Console.WriteLine(text);
		}
	}
}
