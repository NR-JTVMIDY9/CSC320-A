using System;
using System.Windows.Forms;

namespace Symbion {
	public class BaseWorkspace : UserControl, IWorkspace {
		public virtual void Append(IView view) { }
		public virtual void Remove(IView view) { }
		public virtual void Update(IView view) { }

		private static IShell _shell;
		public static IShell Shell {
			get { return _shell ?? (_shell = ServiceRepository.Get<IShell>()); }
		}
	}
}
