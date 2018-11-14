using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestsGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            double testOne;
            double testTwo;
            double testThree;
            double testFour;
            double testFive;
            double average;
            string averagePercent;

            testOne = Convert.ToDouble(tstOne.Text);
            testTwo = Convert.ToDouble(tstTwo.Text);
            testThree = Convert.ToDouble(tstThree.Text);
            testFour = Convert.ToDouble(tstFour.Text);
            testFive = Convert.ToDouble(tstFive.Text);

            average = ((testOne + testTwo + testThree + testFour + testFive) / 5) / 100;
            averagePercent = average.ToString("p");
            lblResult.Text = ("Your test average is " + averagePercent);
        }
    }
}
