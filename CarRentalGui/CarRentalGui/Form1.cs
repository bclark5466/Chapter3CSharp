using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double days;
            double miles;
            double totalCost;
            string moneyProduct;

            days = Convert.ToDouble(txtDays.Text);
            miles = Convert.ToDouble(txtMiles.Text);

            totalCost = (20 * days + .25 * miles);
            moneyProduct = totalCost.ToString("C");

            lblResult.Text = " " + moneyProduct;

            
        }
    }
}
