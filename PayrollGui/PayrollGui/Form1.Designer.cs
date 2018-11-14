namespace PayrollGui
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSocial = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.txtNameIn = new System.Windows.Forms.TextBox();
            this.txtSocialIn = new System.Windows.Forms.TextBox();
            this.txtPayIn = new System.Windows.Forms.TextBox();
            this.txtHoursIn = new System.Windows.Forms.TextBox();
            this.lblNameOut = new System.Windows.Forms.Label();
            this.lblSocialOut = new System.Windows.Forms.Label();
            this.lblPayOut = new System.Windows.Forms.Label();
            this.lblHoursOut = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGross = new System.Windows.Forms.Label();
            this.lblFed = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(253, 192);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Location = new System.Drawing.Point(33, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Please Enter Name";
            // 
            // lblSocial
            // 
            this.lblSocial.AutoSize = true;
            this.lblSocial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSocial.Location = new System.Drawing.Point(33, 80);
            this.lblSocial.Name = "lblSocial";
            this.lblSocial.Size = new System.Drawing.Size(182, 15);
            this.lblSocial.TabIndex = 2;
            this.lblSocial.Text = "Please Enter Social Security Number";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRate.Location = new System.Drawing.Point(33, 121);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(116, 15);
            this.lblRate.TabIndex = 3;
            this.lblRate.Text = "Please Enter Pay Rate";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHours.Location = new System.Drawing.Point(33, 166);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(141, 15);
            this.lblHours.TabIndex = 4;
            this.lblHours.Text = "Please Enter Hours Worked";
            // 
            // txtNameIn
            // 
            this.txtNameIn.Location = new System.Drawing.Point(238, 37);
            this.txtNameIn.Name = "txtNameIn";
            this.txtNameIn.Size = new System.Drawing.Size(100, 20);
            this.txtNameIn.TabIndex = 5;
            // 
            // txtSocialIn
            // 
            this.txtSocialIn.Location = new System.Drawing.Point(238, 78);
            this.txtSocialIn.Name = "txtSocialIn";
            this.txtSocialIn.Size = new System.Drawing.Size(100, 20);
            this.txtSocialIn.TabIndex = 6;
            // 
            // txtPayIn
            // 
            this.txtPayIn.Location = new System.Drawing.Point(238, 121);
            this.txtPayIn.Name = "txtPayIn";
            this.txtPayIn.Size = new System.Drawing.Size(100, 20);
            this.txtPayIn.TabIndex = 7;
            // 
            // txtHoursIn
            // 
            this.txtHoursIn.Location = new System.Drawing.Point(238, 166);
            this.txtHoursIn.Name = "txtHoursIn";
            this.txtHoursIn.Size = new System.Drawing.Size(100, 20);
            this.txtHoursIn.TabIndex = 8;
            // 
            // lblNameOut
            // 
            this.lblNameOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNameOut.Location = new System.Drawing.Point(386, 37);
            this.lblNameOut.Name = "lblNameOut";
            this.lblNameOut.Size = new System.Drawing.Size(100, 23);
            this.lblNameOut.TabIndex = 9;
            // 
            // lblSocialOut
            // 
            this.lblSocialOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSocialOut.Location = new System.Drawing.Point(386, 78);
            this.lblSocialOut.Name = "lblSocialOut";
            this.lblSocialOut.Size = new System.Drawing.Size(100, 23);
            this.lblSocialOut.TabIndex = 10;
            // 
            // lblPayOut
            // 
            this.lblPayOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPayOut.Location = new System.Drawing.Point(386, 121);
            this.lblPayOut.Name = "lblPayOut";
            this.lblPayOut.Size = new System.Drawing.Size(100, 23);
            this.lblPayOut.TabIndex = 11;
            // 
            // lblHoursOut
            // 
            this.lblHoursOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHoursOut.Location = new System.Drawing.Point(386, 166);
            this.lblHoursOut.Name = "lblHoursOut";
            this.lblHoursOut.Size = new System.Drawing.Size(100, 23);
            this.lblHoursOut.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Gross Pay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Federal Withholding";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "State Withholding";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Net Pay";
            // 
            // lblGross
            // 
            this.lblGross.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGross.Location = new System.Drawing.Point(49, 255);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(100, 23);
            this.lblGross.TabIndex = 17;
            // 
            // lblFed
            // 
            this.lblFed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFed.Location = new System.Drawing.Point(180, 255);
            this.lblFed.Name = "lblFed";
            this.lblFed.Size = new System.Drawing.Size(100, 23);
            this.lblFed.TabIndex = 18;
            // 
            // lblState
            // 
            this.lblState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblState.Location = new System.Drawing.Point(333, 255);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(100, 23);
            this.lblState.TabIndex = 19;
            // 
            // lblNet
            // 
            this.lblNet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNet.Location = new System.Drawing.Point(475, 255);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(100, 23);
            this.lblNet.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblFed);
            this.Controls.Add(this.lblGross);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHoursOut);
            this.Controls.Add(this.lblPayOut);
            this.Controls.Add(this.lblSocialOut);
            this.Controls.Add(this.lblNameOut);
            this.Controls.Add(this.txtHoursIn);
            this.Controls.Add(this.txtPayIn);
            this.Controls.Add(this.txtSocialIn);
            this.Controls.Add(this.txtNameIn);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblSocial);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSocial;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.TextBox txtNameIn;
        private System.Windows.Forms.TextBox txtSocialIn;
        private System.Windows.Forms.TextBox txtPayIn;
        private System.Windows.Forms.TextBox txtHoursIn;
        private System.Windows.Forms.Label lblNameOut;
        private System.Windows.Forms.Label lblSocialOut;
        private System.Windows.Forms.Label lblPayOut;
        private System.Windows.Forms.Label lblHoursOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGross;
        private System.Windows.Forms.Label lblFed;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblNet;
    }
}

