namespace Mad_Libs_GUI
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
            this.clickbtn = new System.Windows.Forms.Button();
            this.lblHello = new System.Windows.Forms.Label();
            this.btnBye = new System.Windows.Forms.Button();
            this.btnLastBye = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clickbtn
            // 
            this.clickbtn.Location = new System.Drawing.Point(225, 158);
            this.clickbtn.Name = "clickbtn";
            this.clickbtn.Size = new System.Drawing.Size(75, 23);
            this.clickbtn.TabIndex = 0;
            this.clickbtn.Text = "Click Here";
            this.clickbtn.UseVisualStyleBackColor = true;
            this.clickbtn.Click += new System.EventHandler(this.clickbtn_Click);
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Location = new System.Drawing.Point(222, 112);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(99, 13);
            this.lblHello.TabIndex = 1;
            this.lblHello.Text = "Hello, Visual World!";
            this.lblHello.Visible = false;
            // 
            // btnBye
            // 
            this.btnBye.Location = new System.Drawing.Point(225, 204);
            this.btnBye.Name = "btnBye";
            this.btnBye.Size = new System.Drawing.Size(92, 23);
            this.btnBye.TabIndex = 2;
            this.btnBye.Text = "Click Me Last";
            this.btnBye.UseVisualStyleBackColor = true;
            this.btnBye.Click += new System.EventHandler(this.btnBye_Click);
            // 
            // btnLastBye
            // 
            this.btnLastBye.Location = new System.Drawing.Point(225, 249);
            this.btnLastBye.Name = "btnLastBye";
            this.btnLastBye.Size = new System.Drawing.Size(92, 40);
            this.btnLastBye.TabIndex = 3;
            this.btnLastBye.Text = "No really, Click me last";
            this.btnLastBye.UseVisualStyleBackColor = true;
            this.btnLastBye.Click += new System.EventHandler(this.btnLastBye_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLastBye);
            this.Controls.Add(this.btnBye);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.clickbtn);
            this.Name = "Form1";
            this.Text = "Hello Visual World";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clickbtn;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Button btnBye;
        private System.Windows.Forms.Button btnLastBye;
    }
}

