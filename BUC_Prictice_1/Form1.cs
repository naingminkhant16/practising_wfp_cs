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
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private double num1, num2,result;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            calculate('+');
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            calculate('-');
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            calculate('*');
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            calculate('/');
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            calculate('A');
        }

        private void btnLg_Click(object sender, EventArgs e)
        {
            calculate('L');
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum1.Text = txtNum2.Text=txtRes.Text= "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTwo f2 = new frmTwo();
            f2.Show();
        }

        private void btnSm_Click(object sender, EventArgs e)
        {
            calculate('S');
        }


        private void calculate(char sign)
        {
            lbNum1Msg.Visible = false;
            lbNum2Msg.Visible = false;
            if (txtNum1.Text == "" || txtNum2.Text == "")
            {
                if (txtNum1.Text == "") lbNum1Msg.Visible = true;
                if (txtNum2.Text == "") lbNum2Msg.Visible = true;
            }
            else
            {
                num1 = Convert.ToDouble(txtNum1.Text);
                num2 = Convert.ToDouble(txtNum2.Text);

                switch (sign)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        result = num1 / num2;
                        break;
                    case 'A':
                        result = (num1 + num2) / 2;
                        break;
                    case 'L':
                        result = (num1 < num2) ? num2 : num1;
                        break;
                    case 'S':
                        result = (num1 > num2) ? num2 : num1;
                        break;
                }

                txtRes.Text = result.ToString();
            }
        }
    }
}
