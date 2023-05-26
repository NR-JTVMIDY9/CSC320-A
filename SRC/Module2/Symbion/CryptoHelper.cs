using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Symbion {
	public class CryptoHelper {
		private RSACryptoServiceProvider crypt;

		public CryptoHelper() {
			crypt = new RSACryptoServiceProvider();
		}

		public void Save(string path, bool savePrivateKey) {
			File.WriteAllText(path, crypt.ToXmlString(savePrivateKey));
		}

		public void Load(string path) {
			crypt.FromXmlString(File.ReadAllText(path));
		}

		public byte[] Encrypt(string text) {
			byte[] encrypted = Encoding.UTF8.GetBytes(text);
			return crypt.Encrypt(encrypted, false);
		}

		public string Decrypt(byte[] data) {
			byte[] decrypted = crypt.Decrypt(data, false);
			return Encoding.UTF8.GetString(decrypted);
		}

	}
}
