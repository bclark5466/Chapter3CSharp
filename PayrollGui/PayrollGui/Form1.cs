using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string name;
            long social;
            double payRate;
            string payRateCash;
            int hours;
            double grossPay;
            string grossPayCash;
            double federal;
            string federalCash;
            double state;
            string stateCash;
            double net;
            string netCash;

            name = Convert.ToString(txtNameIn.Text);
            social = Convert.ToInt64(txtSocialIn.Text);
            payRate = Convert.ToDouble(txtPayIn.Text);
            hours = Convert.ToInt32(txtHoursIn.Text);

            payRateCash = payRate.ToString("C");
            lblNameOut.Text = "" + name;
            lblSocialOut.Text = "" + social;
            lblPayOut.Text = "" + payRateCash;
            lblHoursOut.Text = "" + hours;

            grossPay = payRate * hours;
            grossPayCash = grossPay.ToString("C");
            lblGross.Text = "" + grossPayCash;

            federal = grossPay * .15;
            federalCash = federal.ToString("C");
            lblFed.Text = "" + federalCash;

            state = grossPay * .05;
            stateCash = state.ToString("C");
            lblState.Text = "" + stateCash;

            net = grossPay - federal - state;
            netCash = net.ToString("C");
            lblNet.Text = "" + netCash;


        }
    }
}
