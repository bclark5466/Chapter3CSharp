using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilesToKilometersGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convert_Click(object sender, EventArgs e)
        {
            int miles;
            double kilos;

            miles = Convert.ToInt32(txtMiles.Text);
            kilos = miles * 1.6;

            lblKilos.Text = " " + kilos;
        }
    }
}
