using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUC_Prictice_1
{
    public partial class frmProgress : Form
    {
        public frmProgress()
        {
            InitializeComponent();
        }

        private void frmProgress_Load(object sender, EventArgs e)
        {

        }

        private void btnInst_Click(object sender, EventArgs e)
        {
            pb1.Visible = true;
            label1.Visible = true;
            while (pb1.Value != 100)
            {
                System.Threading.Thread.Sleep(1000);
                pb1.Value += 10;
            }
            if (pb1.Value == 100)
            {
                frmAfterProp fap = new frmAfterProp();
                fap.Show();
                this.Hide();
            }
        }
    }
}
