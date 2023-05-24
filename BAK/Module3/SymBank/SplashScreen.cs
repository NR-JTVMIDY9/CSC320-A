using SymBank.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymBank {
	public partial class SplashScreen : Form {
		public SplashScreen() {
			InitializeComponent();
		}

		public string Status {
			set {
				lblStatus.Text = value ?? Resources.PleaseWait;
				lblStatus.Refresh();
			}
		}
	}
}
