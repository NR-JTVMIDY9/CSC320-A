using System;

namespace Symbion {
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
	public sealed class InjectAttribute : Attribute {
		public InjectAttribute() { }
	}
}
