using System;

namespace Symbion {
	public interface IWorkspace {
		void Append(IView view);
		void Remove(IView view);
		void Update(IView view);
	}
}