using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greenvile_Revenue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double previous;
            double present;
            double revenue;
            string revenueMoney;

            previous = Convert.ToDouble(txtPast.Text);
            present = Convert.ToDouble(txtPresent.Text);
            revenue = present * 25;
            revenueMoney = revenue.ToString("C");

            lblRevenue.Text = "This year's revenue is " + revenueMoney;

            if (present > previous)
            {
                lblCompare.Text = "This years turnout was greater than last years";
            }
            else 
            {
                lblCompare.Text = "This years turnout was lesser than last years";
            }
            
        }
    }
}
