﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FixedDebugThree3
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // This declaration is in the correct place.
        // total is outside the method so it can remain a running total.
        double total = 0;
        private void totalButton_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox1.Text);
            total = total + num;
            outputLabel.Text = "Running total: " + total;
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
