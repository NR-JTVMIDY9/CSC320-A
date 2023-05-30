using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Symbion {
	public static class Validation {
		public const string CannotBeNull = "{0} cannot be null.";
		public const string CannotBeEmpty = "{0} is required and cannot be empty.";
		public const string OutOfRange = "{0} must be between {1} and {2}.";
		public const string IsNotValid = "{0} is not valid.";

		public static void NotNull(this Control control, string name) {
			if (control.Text == null) throw new ValidationException(
				control, string.Format(CannotBeNull, name));
		}

		public static void Length(this Control control, string name, int minLength, int maxLength) {
			var text = control.Text.Trim(); control.Text = text;
			if (text.Length < minLength || text.Length > maxLength)
				throw new ValidationException(control,
					string.Format(OutOfRange, name, minLength, maxLength));
		}

		public static void NotEmpty(this Control control, string name) {
			NotNull(control, name);
			if (control.Text.Length == 0)
				throw new ValidationException(
					control, string.Format(CannotBeEmpty, name));
		}

		public static void InRange(this Control control, string name, int minValue, int maxValue) {
			int value;
			if (!int.TryParse(control.Text, out value))
				throw new ValidationException(control,
					string.Format(IsNotValid, name));
			if (value < minValue || value > maxValue)
				throw new ValidationException(control,
					string.Format(OutOfRange, name, minValue, maxValue));
		}

		public static void InRange(this Control control, string name, decimal minValue, decimal maxValue) {
			decimal value;
			if (!decimal.TryParse(control.Text, out value))
				throw new ValidationException(control,
					string.Format(IsNotValid, name));
			if (value < minValue || value > maxValue)
				throw new ValidationException(control,
					string.Format(OutOfRange, name, minValue, maxValue));
		}

		public static void Matches(this Control control, string name, string pattern) {
			var rex = new Regex(pattern);
			if (!rex.IsMatch(control.Text))
				throw new ValidationException(control,
					string.Format(IsNotValid, name));
		}

	}
}
