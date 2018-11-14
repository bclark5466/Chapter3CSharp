namespace TestsGui
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
            this.lblScore = new System.Windows.Forms.Label();
            this.tstOne = new System.Windows.Forms.TextBox();
            this.tstFour = new System.Windows.Forms.TextBox();
            this.tstThree = new System.Windows.Forms.TextBox();
            this.tstTwo = new System.Windows.Forms.TextBox();
            this.tstFive = new System.Windows.Forms.TextBox();
            this.btnAverage = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(324, 19);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(127, 13);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Please Enter Test Scores";
            // 
            // tstOne
            // 
            this.tstOne.Location = new System.Drawing.Point(57, 71);
            this.tstOne.Name = "tstOne";
            this.tstOne.Size = new System.Drawing.Size(100, 20);
            this.tstOne.TabIndex = 1;
            this.tstOne.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tstFour
            // 
            this.tstFour.Location = new System.Drawing.Point(475, 71);
            this.tstFour.Name = "tstFour";
            this.tstFour.Size = new System.Drawing.Size(100, 20);
            this.tstFour.TabIndex = 2;
            // 
            // tstThree
            // 
            this.tstThree.Location = new System.Drawing.Point(337, 71);
            this.tstThree.Name = "tstThree";
            this.tstThree.Size = new System.Drawing.Size(100, 20);
            this.tstThree.TabIndex = 3;
            // 
            // tstTwo
            // 
            this.tstTwo.Location = new System.Drawing.Point(207, 71);
            this.tstTwo.Name = "tstTwo";
            this.tstTwo.Size = new System.Drawing.Size(100, 20);
            this.tstTwo.TabIndex = 4;
            // 
            // tstFive
            // 
            this.tstFive.Location = new System.Drawing.Point(620, 71);
            this.tstFive.Name = "tstFive";
            this.tstFive.Size = new System.Drawing.Size(100, 20);
            this.tstFive.TabIndex = 5;
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(350, 116);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(75, 23);
            this.btnAverage.TabIndex = 6;
            this.btnAverage.Text = "Calculate";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(303, 180);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(169, 23);
            this.lblResult.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.tstFive);
            this.Controls.Add(this.tstTwo);
            this.Controls.Add(this.tstThree);
            this.Controls.Add(this.tstFour);
            this.Controls.Add(this.tstOne);
            this.Controls.Add(this.lblScore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox tstOne;
        private System.Windows.Forms.TextBox tstFour;
        private System.Windows.Forms.TextBox tstThree;
        private System.Windows.Forms.TextBox tstTwo;
        private System.Windows.Forms.TextBox tstFive;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Label lblResult;
    }
}

