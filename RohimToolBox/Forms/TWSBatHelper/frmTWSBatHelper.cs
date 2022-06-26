using RohimToolBox.CustControls;
using System;
using System.Windows.Forms;

namespace RohimToolBox.Forms.TWSBatHelper {
	public partial class frmTWSBatHelper : Form {
		public frmTWSBatHelper() {
			InitializeComponent();

			// add frmTWSBatHelperPage to first tab
			frmTWSBatHelperPage page1 = new frmTWSBatHelperPage();
			page1.TopLevel = false;
			page1.Dock = DockStyle.Fill;
			page1.Show();
			this.tabPage1.Controls.Add(page1);
		}

		private void btnHelp_Click(object sender, EventArgs e) {
			string text = "Select All Folders & Files\t\tCtrl + A\r\n" +
				"Copy Folders or Files\t\tCtrl + C\r\n";
			MessageBox.Show(text, "Shortcut Keys");
		}
	}
}
