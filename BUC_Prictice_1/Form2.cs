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
    public partial class frmTwo : Form
    {
        public frmTwo()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            DateTime d;
            d = dtp.Value;
            if (rdnCs.Checked)
                MessageBox.Show("You have chosen Computer Science (CS) on "+ 
                    d.ToString()+" and your uni is "+cbBox.SelectedItem);
            if (rdbCt.Checked) 
                MessageBox.Show("You have chosen Computer Technology (CT) on "+
                    d.ToString() + " and your uni is " + cbBox.SelectedItem);
        
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
           
            frmProgress fp = new frmProgress();
            fp.Show();
            this.Hide();
           
        }
    }
}
