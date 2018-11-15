namespace Greenvile_Revenue
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPast = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPresent = new System.Windows.Forms.TextBox();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.lblCompare = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter number of previous contestants";
            // 
            // txtPast
            // 
            this.txtPast.Location = new System.Drawing.Point(400, 45);
            this.txtPast.Name = "txtPast";
            this.txtPast.Size = new System.Drawing.Size(100, 20);
            this.txtPast.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please enter number of current contestants";
            // 
            // txtPresent
            // 
            this.txtPresent.Location = new System.Drawing.Point(400, 90);
            this.txtPresent.Name = "txtPresent";
            this.txtPresent.Size = new System.Drawing.Size(100, 20);
            this.txtPresent.TabIndex = 3;
            // 
            // lblRevenue
            // 
            this.lblRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblRevenue.Location = new System.Drawing.Point(400, 177);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(234, 23);
            this.lblRevenue.TabIndex = 4;
            // 
            // lblCompare
            // 
            this.lblCompare.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblCompare.Location = new System.Drawing.Point(400, 223);
            this.lblCompare.Name = "lblCompare";
            this.lblCompare.Size = new System.Drawing.Size(234, 23);
            this.lblCompare.TabIndex = 5;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(410, 132);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblCompare);
            this.Controls.Add(this.lblRevenue);
            this.Controls.Add(this.txtPresent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPast);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPresent;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblCompare;
        private System.Windows.Forms.Button btnCalc;
    }
}

