using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int sum;
            num1 = Convert.ToInt32(txtEnterNumber.Text);
            num2 = Convert.ToInt32(txtEnterNumber2.Text);

            sum = num1 + num2;

            lblResult.Text = "= " + sum;

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int diff;
            num1 = Convert.ToInt32(txtEnterNumber.Text);
            num2 = Convert.ToInt32(txtEnterNumber2.Text);

            diff = num1 - num2;

            lblResultSub.Text = "= " + diff;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;
            double div;
            num1 = Convert.ToDouble(txtEnterNumber.Text);
            num2 = Convert.ToDouble(txtEnterNumber2.Text);

            div = num1 / num2;

            lblResultDiv.Text = "= " + div;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int multi;
            num1 = Convert.ToInt32(txtEnterNumber.Text);
            num2 = Convert.ToInt32(txtEnterNumber2.Text);

            multi = num1 * num2;

            lblResultMulti.Text = "= " + multi;
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int mod;
            num1 = Convert.ToInt32(txtEnterNumber.Text);
            num2 = Convert.ToInt32(txtEnterNumber2.Text);

            mod = num2 % num1;

            lblResultMod.Text = "= " + mod;
        }

        private void calcAll_Click(object sender, EventArgs e)
        {
            double num
        }
    }
}
