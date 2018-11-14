using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadLibGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtEst_TextChanged(object sender, EventArgs e)
        {
            string color;
            string est;
            string bodyPart;
            string animal;
            string noun;
            string pluralNoun;
            double a;
            double b;
            double c;

            color = Convert.ToString(txtColor.Text);
            est = Convert.ToString(txtEst.Text);
            bodyPart = Convert.ToString(txtBody.Text);
            animal = Convert.ToString(txtAnimal.Text);
            noun = Convert.ToString(txtNoun.Text);
            pluralNoun = Convert.ToString(txtPlural.Text);
            a = Convert.ToDouble(txta.Text);
            b = Convert.ToDouble(txtb.Text);

            c = a - b;


        }
    }
}
