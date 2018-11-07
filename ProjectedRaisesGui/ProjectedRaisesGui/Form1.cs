using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectedRaisesGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nxtSalary_Click(object sender, EventArgs e)
        {
            double pay;
            double project;

            pay = Convert.ToDouble(txtsal1.Text);
            project = pay + (pay * .04);

            lblprojected.Text = " " + project;
        }
    }
}
