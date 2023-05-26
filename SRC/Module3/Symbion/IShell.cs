namespace Symbion {
	public interface IShell : IService {
		string Status { set; }
		void Success(string message);
		void Failure(string message);
		void Warning(string message);
		bool Confirm(string message);
		void Close();
	}
}
