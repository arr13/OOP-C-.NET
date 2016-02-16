namespace Problem5___3b
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
            this.btnToss = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCurrentFlip = new System.Windows.Forms.Label();
            this.lblAllTails = new System.Windows.Forms.Label();
            this.lblAllHeads = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnToss
            // 
            this.btnToss.Location = new System.Drawing.Point(69, 12);
            this.btnToss.Name = "btnToss";
            this.btnToss.Size = new System.Drawing.Size(130, 36);
            this.btnToss.TabIndex = 0;
            this.btnToss.Text = "Toss";
            this.btnToss.UseVisualStyleBackColor = true;
            this.btnToss.Click += new System.EventHandler(this.btnToss_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(69, 109);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(130, 36);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(69, 207);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 36);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCurrentFlip
            // 
            this.lblCurrentFlip.AutoSize = true;
            this.lblCurrentFlip.Location = new System.Drawing.Point(110, 68);
            this.lblCurrentFlip.Name = "lblCurrentFlip";
            this.lblCurrentFlip.Size = new System.Drawing.Size(46, 17);
            this.lblCurrentFlip.TabIndex = 3;
            this.lblCurrentFlip.Text = "label1";
            // 
            // lblAllTails
            // 
            this.lblAllTails.AutoSize = true;
            this.lblAllTails.Location = new System.Drawing.Point(54, 169);
            this.lblAllTails.Name = "lblAllTails";
            this.lblAllTails.Size = new System.Drawing.Size(46, 17);
            this.lblAllTails.TabIndex = 4;
            this.lblAllTails.Text = "label2";
            // 
            // lblAllHeads
            // 
            this.lblAllHeads.AutoSize = true;
            this.lblAllHeads.Location = new System.Drawing.Point(164, 169);
            this.lblAllHeads.Name = "lblAllHeads";
            this.lblAllHeads.Size = new System.Drawing.Size(46, 17);
            this.lblAllHeads.TabIndex = 5;
            this.lblAllHeads.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.lblAllHeads);
            this.Controls.Add(this.lblAllTails);
            this.Controls.Add(this.lblCurrentFlip);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnToss);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToss;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCurrentFlip;
        private System.Windows.Forms.Label lblAllTails;
        private System.Windows.Forms.Label lblAllHeads;
    }
}

