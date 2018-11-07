namespace Windows_Calculator
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtEnterNumber = new System.Windows.Forms.TextBox();
            this.txtEnterNumber2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.lblResultSub = new System.Windows.Forms.Label();
            this.lblResultDiv = new System.Windows.Forms.Label();
            this.lblResultMulti = new System.Windows.Forms.Label();
            this.lblResultMod = new System.Windows.Forms.Label();
            this.calcAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter another number";
            // 
            // txtEnterNumber
            // 
            this.txtEnterNumber.Location = new System.Drawing.Point(215, 17);
            this.txtEnterNumber.Name = "txtEnterNumber";
            this.txtEnterNumber.Size = new System.Drawing.Size(100, 20);
            this.txtEnterNumber.TabIndex = 2;
            // 
            // txtEnterNumber2
            // 
            this.txtEnterNumber2.Location = new System.Drawing.Point(215, 80);
            this.txtEnterNumber2.Name = "txtEnterNumber2";
            this.txtEnterNumber2.Size = new System.Drawing.Size(100, 20);
            this.txtEnterNumber2.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(17, 142);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblResult.Location = new System.Drawing.Point(215, 142);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(100, 23);
            this.lblResult.TabIndex = 5;
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(17, 185);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(75, 23);
            this.btnSub.TabIndex = 6;
            this.btnSub.Text = "Subtract";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(17, 230);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 23);
            this.btnDiv.TabIndex = 7;
            this.btnDiv.Text = "Divide";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(17, 275);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(75, 23);
            this.btnMulti.TabIndex = 8;
            this.btnMulti.Text = "Multiply";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(17, 318);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(75, 23);
            this.btnMod.TabIndex = 9;
            this.btnMod.Text = "Modulus";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // lblResultSub
            // 
            this.lblResultSub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblResultSub.Location = new System.Drawing.Point(215, 185);
            this.lblResultSub.Name = "lblResultSub";
            this.lblResultSub.Size = new System.Drawing.Size(100, 23);
            this.lblResultSub.TabIndex = 10;
            // 
            // lblResultDiv
            // 
            this.lblResultDiv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblResultDiv.Location = new System.Drawing.Point(215, 230);
            this.lblResultDiv.Name = "lblResultDiv";
            this.lblResultDiv.Size = new System.Drawing.Size(100, 23);
            this.lblResultDiv.TabIndex = 11;
            // 
            // lblResultMulti
            // 
            this.lblResultMulti.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblResultMulti.Location = new System.Drawing.Point(215, 275);
            this.lblResultMulti.Name = "lblResultMulti";
            this.lblResultMulti.Size = new System.Drawing.Size(100, 23);
            this.lblResultMulti.TabIndex = 12;
            // 
            // lblResultMod
            // 
            this.lblResultMod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblResultMod.Location = new System.Drawing.Point(215, 318);
            this.lblResultMod.Name = "lblResultMod";
            this.lblResultMod.Size = new System.Drawing.Size(100, 23);
            this.lblResultMod.TabIndex = 13;
            // 
            // calcAll
            // 
            this.calcAll.Location = new System.Drawing.Point(118, 104);
            this.calcAll.Name = "calcAll";
            this.calcAll.Size = new System.Drawing.Size(75, 23);
            this.calcAll.TabIndex = 14;
            this.calcAll.Text = "Calculate All";
            this.calcAll.UseVisualStyleBackColor = true;
            this.calcAll.Click += new System.EventHandler(this.calcAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 376);
            this.Controls.Add(this.calcAll);
            this.Controls.Add(this.lblResultMod);
            this.Controls.Add(this.lblResultMulti);
            this.Controls.Add(this.lblResultDiv);
            this.Controls.Add(this.lblResultSub);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtEnterNumber2);
            this.Controls.Add(this.txtEnterNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEnterNumber;
        private System.Windows.Forms.TextBox txtEnterNumber2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Label lblResultSub;
        private System.Windows.Forms.Label lblResultDiv;
        private System.Windows.Forms.Label lblResultMulti;
        private System.Windows.Forms.Label lblResultMod;
        private System.Windows.Forms.Button calcAll;
    }
}

