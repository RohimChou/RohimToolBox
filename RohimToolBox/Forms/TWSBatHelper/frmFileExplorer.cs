﻿using RohimToolBox.CustControls;
using System;
using System.Threading;
using System.Windows.Forms;

namespace RohimToolBox.Forms.TWSBatHelper {
	public partial class frmFileExplorer : Form {
		public frmFileExplorer() {
			InitializeComponent();

			// add frmTWSBatHelperPage to first tab
			frmFileExplorerPage page1 = new frmFileExplorerPage();
			page1.TopLevel = false;
			page1.Dock = DockStyle.Fill;
			page1.Show();
			this.tabPage1.Controls.Add(page1);
		}

		private void btnHelp_Click(object sender, EventArgs e) {
			string text = "Select All Folders & Files\t\tCtrl + A\r\n" +
				"Copy Folders or Files\t\tCtrl + C\r\n";

			Form owner = this.ParentForm ?? this;
			using (new CenterWinDialog(owner)) {
				MessageBox.Show(text, "Shortcut Keys");
			}
		}
	}
}
