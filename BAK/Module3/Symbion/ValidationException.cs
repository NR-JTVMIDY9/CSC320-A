using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Symbion {
	public class ValidationException : Exception {
		private Control _control;

		public ValidationException(Control control, string message) : base(message) {
			_control = control;
		}

		public void Refocus() {
			if (_control != null) _control.Focus();
		}
	}
}
