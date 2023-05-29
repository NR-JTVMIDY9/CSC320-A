namespace Symbion {
	public interface IActionSite {
		void Add(Command command);
		void Update(Command command);
		void Remove(Command command);
		void AddSeparator();
	}
}
