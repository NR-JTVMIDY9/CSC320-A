using System;
using System.Windows.Forms;

namespace Symbion {
	public class ValidationException : Exception {
		private Control _control;

		public ValidationException(Control control, string message) : base(message) {
			_control = control;
		}

		public void SetError(ErrorProvider provider) {
			provider.SetError(_control, Message);
			_control.Focus();
		}

		public void Refocus() {
			if (_control != null)
				_control.Focus();
		}


	}
}
