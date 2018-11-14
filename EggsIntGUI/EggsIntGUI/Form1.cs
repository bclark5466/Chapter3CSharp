using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsIntGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int chkOne;
            int chkTwo;
            int chkThree;
            int chkFour;
            int chkFive;
            int sum;
            int dozen;
            int remainder;

            chkOne = Convert.ToInt32(txtOne.Text);
            chkTwo = Convert.ToInt32(txtTwo.Text);
            chkThree = Convert.ToInt32(txtThree.Text);
            chkFour = Convert.ToInt32(txtFour.Text);
            chkFive = Convert.ToInt32(txtFive.Text);

            sum = (chkOne + chkTwo + chkThree + chkFour + chkFive);
            dozen = sum / 12;
            remainder = sum % 12;

            lblOutput.Text = dozen + " dozen and " + remainder;

        }
    }
}
