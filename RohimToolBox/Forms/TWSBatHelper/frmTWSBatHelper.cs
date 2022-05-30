using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RohimToolBox.Forms.TWSBatHelper
{
    public partial class frmTWSBatHelper : Form
    {
        public frmTWSBatHelper()
        {
            InitializeComponent();

            // add frmTWSBatHelperPage to first tab
            frmTWSBatHelperPage page1 = new frmTWSBatHelperPage();
            page1.TopLevel = false;
            page1.Dock = DockStyle.Fill;
            page1.Show();
            this.tabPage1.Controls.Add(page1);
        }
    }
}
