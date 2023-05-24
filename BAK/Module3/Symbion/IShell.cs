namespace Symbion {
	public interface IShell {
		string Status { set; }
		void Success(string message);
		void Failure(string message);
		void Warning(string message);
		void Close();
	}
}
