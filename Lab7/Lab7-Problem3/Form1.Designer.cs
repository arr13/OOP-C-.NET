namespace Lab7_Problem3
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
            this.txtBoxInsertNumber = new System.Windows.Forms.TextBox();
            this.lblInsertNumber = new System.Windows.Forms.Label();
            this.btnComputeOneS = new System.Windows.Forms.Button();
            this.btnComputeTwoS = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxInsertNumber
            // 
            this.txtBoxInsertNumber.Location = new System.Drawing.Point(47, 46);
            this.txtBoxInsertNumber.Name = "txtBoxInsertNumber";
            this.txtBoxInsertNumber.Size = new System.Drawing.Size(193, 22);
            this.txtBoxInsertNumber.TabIndex = 0;
            this.txtBoxInsertNumber.TextChanged += new System.EventHandler(this.txtBoxInsertNumber_TextChanged);
            // 
            // lblInsertNumber
            // 
            this.lblInsertNumber.AutoSize = true;
            this.lblInsertNumber.Location = new System.Drawing.Point(70, 26);
            this.lblInsertNumber.Name = "lblInsertNumber";
            this.lblInsertNumber.Size = new System.Drawing.Size(142, 17);
            this.lblInsertNumber.TabIndex = 1;
            this.lblInsertNumber.Text = "Please insert number";
            // 
            // btnComputeOneS
            // 
            this.btnComputeOneS.Enabled = false;
            this.btnComputeOneS.Location = new System.Drawing.Point(12, 103);
            this.btnComputeOneS.Name = "btnComputeOneS";
            this.btnComputeOneS.Size = new System.Drawing.Size(104, 44);
            this.btnComputeOneS.TabIndex = 2;
            this.btnComputeOneS.Text = "Compute one`s";
            this.btnComputeOneS.UseVisualStyleBackColor = true;
            this.btnComputeOneS.Click += new System.EventHandler(this.btnComputeOneS_Click);
            // 
            // btnComputeTwoS
            // 
            this.btnComputeTwoS.Enabled = false;
            this.btnComputeTwoS.Location = new System.Drawing.Point(166, 103);
            this.btnComputeTwoS.Name = "btnComputeTwoS";
            this.btnComputeTwoS.Size = new System.Drawing.Size(104, 44);
            this.btnComputeTwoS.TabIndex = 3;
            this.btnComputeTwoS.Text = "Compute two`s";
            this.btnComputeTwoS.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 172);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(166, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(104, 22);
            this.textBox2.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(97, 220);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 31);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 276);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnComputeTwoS);
            this.Controls.Add(this.btnComputeOneS);
            this.Controls.Add(this.lblInsertNumber);
            this.Controls.Add(this.txtBoxInsertNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxInsertNumber;
        private System.Windows.Forms.Label lblInsertNumber;
        private System.Windows.Forms.Button btnComputeOneS;
        private System.Windows.Forms.Button btnComputeTwoS;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnExit;
    }
}

