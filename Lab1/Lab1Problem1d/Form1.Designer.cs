namespace Lab1Problem1d
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
            this.btnHour = new System.Windows.Forms.Button();
            this.btnMinute = new System.Windows.Forms.Button();
            this.btnSecond = new System.Windows.Forms.Button();
            this.btnOn = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.txtTimer = new System.Windows.Forms.TextBox();
            this.groupBoxAMPM = new System.Windows.Forms.GroupBox();
            this.radioButtonAM = new System.Windows.Forms.RadioButton();
            this.radioButtonPM = new System.Windows.Forms.RadioButton();
            this.btnTimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxAMPM.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHour
            // 
            this.btnHour.Location = new System.Drawing.Point(0, 0);
            this.btnHour.Name = "btnHour";
            this.btnHour.Size = new System.Drawing.Size(76, 23);
            this.btnHour.TabIndex = 0;
            this.btnHour.Text = "HOUR";
            this.btnHour.UseVisualStyleBackColor = true;
            // 
            // btnMinute
            // 
            this.btnMinute.Location = new System.Drawing.Point(79, 0);
            this.btnMinute.Name = "btnMinute";
            this.btnMinute.Size = new System.Drawing.Size(76, 23);
            this.btnMinute.TabIndex = 1;
            this.btnMinute.Text = "MINUTE";
            this.btnMinute.UseVisualStyleBackColor = true;
            // 
            // btnSecond
            // 
            this.btnSecond.Location = new System.Drawing.Point(161, 0);
            this.btnSecond.Name = "btnSecond";
            this.btnSecond.Size = new System.Drawing.Size(76, 23);
            this.btnSecond.TabIndex = 2;
            this.btnSecond.Text = "SECOND";
            this.btnSecond.UseVisualStyleBackColor = true;
            // 
            // btnOn
            // 
            this.btnOn.Location = new System.Drawing.Point(243, 0);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(49, 23);
            this.btnOn.TabIndex = 3;
            this.btnOn.Text = "ON";
            this.btnOn.UseVisualStyleBackColor = true;
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(298, 0);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(49, 23);
            this.btnOff.TabIndex = 4;
            this.btnOff.Text = "OFF";
            this.btnOff.UseVisualStyleBackColor = true;
            // 
            // txtTimer
            // 
            this.txtTimer.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtTimer.ForeColor = System.Drawing.Color.White;
            this.txtTimer.Location = new System.Drawing.Point(12, 60);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(96, 22);
            this.txtTimer.TabIndex = 5;
            this.txtTimer.Text = "00:00:00";
            this.txtTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxAMPM
            // 
            this.groupBoxAMPM.Controls.Add(this.radioButtonPM);
            this.groupBoxAMPM.Controls.Add(this.radioButtonAM);
            this.groupBoxAMPM.Location = new System.Drawing.Point(129, 39);
            this.groupBoxAMPM.Name = "groupBoxAMPM";
            this.groupBoxAMPM.Size = new System.Drawing.Size(108, 73);
            this.groupBoxAMPM.TabIndex = 6;
            this.groupBoxAMPM.TabStop = false;
            this.groupBoxAMPM.Text = "AM/PM";
            // 
            // radioButtonAM
            // 
            this.radioButtonAM.AutoSize = true;
            this.radioButtonAM.Location = new System.Drawing.Point(6, 22);
            this.radioButtonAM.Name = "radioButtonAM";
            this.radioButtonAM.Size = new System.Drawing.Size(49, 21);
            this.radioButtonAM.TabIndex = 0;
            this.radioButtonAM.TabStop = true;
            this.radioButtonAM.Text = "AM";
            this.radioButtonAM.UseVisualStyleBackColor = true;
            // 
            // radioButtonPM
            // 
            this.radioButtonPM.AutoSize = true;
            this.radioButtonPM.Location = new System.Drawing.Point(6, 46);
            this.radioButtonPM.Name = "radioButtonPM";
            this.radioButtonPM.Size = new System.Drawing.Size(49, 21);
            this.radioButtonPM.TabIndex = 1;
            this.radioButtonPM.TabStop = true;
            this.radioButtonPM.Text = "PM";
            this.radioButtonPM.UseVisualStyleBackColor = true;
            // 
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(256, 53);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(76, 45);
            this.btnTimer.TabIndex = 7;
            this.btnTimer.Text = "Timer";
            this.btnTimer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(9, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "                                  SNOOZE                               ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 166);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.groupBoxAMPM);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.btnSecond);
            this.Controls.Add(this.btnMinute);
            this.Controls.Add(this.btnHour);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxAMPM.ResumeLayout(false);
            this.groupBoxAMPM.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHour;
        private System.Windows.Forms.Button btnMinute;
        private System.Windows.Forms.Button btnSecond;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.TextBox txtTimer;
        private System.Windows.Forms.GroupBox groupBoxAMPM;
        private System.Windows.Forms.RadioButton radioButtonPM;
        private System.Windows.Forms.RadioButton radioButtonAM;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Label label1;
    }
}

