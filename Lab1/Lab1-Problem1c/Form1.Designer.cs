namespace Lab1_Problem1c
{
    partial class Calculator
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
            this.txtCalculatorDisplay = new System.Windows.Forms.TextBox();
            this.pnlNumbers = new System.Windows.Forms.Panel();
            this.btn00 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.pnlMathOperations = new System.Windows.Forms.Panel();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.pnlDelete = new System.Windows.Forms.Panel();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCA = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSin = new System.Windows.Forms.Button();
            this.btn1x = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.pnlNumbers.SuspendLayout();
            this.pnlMathOperations.SuspendLayout();
            this.pnlDelete.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCalculatorDisplay
            // 
            this.txtCalculatorDisplay.Location = new System.Drawing.Point(8, 16);
            this.txtCalculatorDisplay.Name = "txtCalculatorDisplay";
            this.txtCalculatorDisplay.Size = new System.Drawing.Size(259, 22);
            this.txtCalculatorDisplay.TabIndex = 0;
            this.txtCalculatorDisplay.Text = "0";
            this.txtCalculatorDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCalculatorDisplay.TextChanged += new System.EventHandler(this.txtCalculatorDisplay_TextChanged);
            // 
            // pnlNumbers
            // 
            this.pnlNumbers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlNumbers.Controls.Add(this.btn00);
            this.pnlNumbers.Controls.Add(this.btn0);
            this.pnlNumbers.Controls.Add(this.btn9);
            this.pnlNumbers.Controls.Add(this.btn8);
            this.pnlNumbers.Controls.Add(this.btn7);
            this.pnlNumbers.Controls.Add(this.btn6);
            this.pnlNumbers.Controls.Add(this.btn5);
            this.pnlNumbers.Controls.Add(this.btn4);
            this.pnlNumbers.Controls.Add(this.btn2);
            this.pnlNumbers.Controls.Add(this.btn3);
            this.pnlNumbers.Controls.Add(this.btn1);
            this.pnlNumbers.Location = new System.Drawing.Point(8, 48);
            this.pnlNumbers.Name = "pnlNumbers";
            this.pnlNumbers.Size = new System.Drawing.Size(88, 119);
            this.pnlNumbers.TabIndex = 1;
            // 
            // btn00
            // 
            this.btn00.Location = new System.Drawing.Point(30, 90);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(51, 23);
            this.btn00.TabIndex = 10;
            this.btn00.Text = "00";
            this.btn00.UseVisualStyleBackColor = true;
            this.btn00.Click += new System.EventHandler(this.btn00_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(6, 90);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(25, 23);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(56, 61);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(25, 23);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(30, 61);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(25, 23);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(6, 61);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(25, 23);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(56, 32);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(25, 23);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(30, 32);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(25, 23);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(6, 32);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(25, 23);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(30, 3);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(25, 23);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(56, 3);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(25, 23);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(6, 3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(25, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // pnlMathOperations
            // 
            this.pnlMathOperations.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMathOperations.Controls.Add(this.btnPlus);
            this.pnlMathOperations.Controls.Add(this.btnDot);
            this.pnlMathOperations.Controls.Add(this.btnEqual);
            this.pnlMathOperations.Controls.Add(this.btnDivide);
            this.pnlMathOperations.Controls.Add(this.btnMultiply);
            this.pnlMathOperations.Controls.Add(this.btnMinus);
            this.pnlMathOperations.Location = new System.Drawing.Point(109, 48);
            this.pnlMathOperations.Name = "pnlMathOperations";
            this.pnlMathOperations.Size = new System.Drawing.Size(62, 119);
            this.pnlMathOperations.TabIndex = 2;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(3, 3);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(25, 80);
            this.btnPlus.TabIndex = 6;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(3, 89);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(25, 23);
            this.btnDot.TabIndex = 5;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(30, 89);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(25, 23);
            this.btnEqual.TabIndex = 4;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(30, 61);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(25, 23);
            this.btnDivide.TabIndex = 3;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(30, 32);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(25, 23);
            this.btnMultiply.TabIndex = 2;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(30, 3);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(25, 23);
            this.btnMinus.TabIndex = 1;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // pnlDelete
            // 
            this.pnlDelete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDelete.Controls.Add(this.btnC);
            this.pnlDelete.Controls.Add(this.btnCA);
            this.pnlDelete.Location = new System.Drawing.Point(284, 48);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Size = new System.Drawing.Size(48, 71);
            this.pnlDelete.TabIndex = 3;
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(3, 7);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(38, 23);
            this.btnC.TabIndex = 2;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCA
            // 
            this.btnCA.Location = new System.Drawing.Point(3, 36);
            this.btnCA.Name = "btnCA";
            this.btnCA.Size = new System.Drawing.Size(38, 23);
            this.btnCA.TabIndex = 1;
            this.btnCA.Text = "C/A";
            this.btnCA.UseVisualStyleBackColor = true;
            this.btnCA.Click += new System.EventHandler(this.btnCA_Click);
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(284, 133);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(48, 23);
            this.btnOff.TabIndex = 3;
            this.btnOff.Text = "OFF";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnExp);
            this.panel1.Controls.Add(this.btnCos);
            this.panel1.Controls.Add(this.btnLog);
            this.panel1.Controls.Add(this.btn1x);
            this.panel1.Controls.Add(this.btnSin);
            this.panel1.Location = new System.Drawing.Point(186, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(81, 119);
            this.panel1.TabIndex = 7;
            // 
            // btnSin
            // 
            this.btnSin.Location = new System.Drawing.Point(3, 3);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(38, 23);
            this.btnSin.TabIndex = 1;
            this.btnSin.Text = "sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btn1x
            // 
            this.btn1x.Location = new System.Drawing.Point(47, 3);
            this.btn1x.Name = "btn1x";
            this.btn1x.Size = new System.Drawing.Size(25, 84);
            this.btn1x.TabIndex = 6;
            this.btn1x.Text = "1-x";
            this.btn1x.UseVisualStyleBackColor = true;
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(3, 89);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(38, 23);
            this.btnLog.TabIndex = 7;
            this.btnLog.Text = "log";
            this.btnLog.UseVisualStyleBackColor = true;
            // 
            // btnCos
            // 
            this.btnCos.Location = new System.Drawing.Point(3, 32);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(38, 23);
            this.btnCos.TabIndex = 8;
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = true;
            // 
            // btnExp
            // 
            this.btnExp.Location = new System.Drawing.Point(3, 60);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(38, 23);
            this.btnExp.TabIndex = 9;
            this.btnExp.Text = "exp";
            this.btnExp.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 174);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.pnlDelete);
            this.Controls.Add(this.pnlMathOperations);
            this.Controls.Add(this.pnlNumbers);
            this.Controls.Add(this.txtCalculatorDisplay);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.pnlNumbers.ResumeLayout(false);
            this.pnlMathOperations.ResumeLayout(false);
            this.pnlDelete.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCalculatorDisplay;
        private System.Windows.Forms.Panel pnlNumbers;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Panel pnlMathOperations;
        private System.Windows.Forms.Panel pnlDelete;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCA;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btn1x;
        private System.Windows.Forms.Button btnSin;
    }
}

