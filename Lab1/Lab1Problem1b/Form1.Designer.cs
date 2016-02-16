namespace Lab1Problem1b
{
    partial class myCalendar
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblCalendar = new System.Windows.Forms.Label();
            this.lblAppointments = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(6, 39);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // lblCalendar
            // 
            this.lblCalendar.AutoSize = true;
            this.lblCalendar.BackColor = System.Drawing.Color.Yellow;
            this.lblCalendar.Location = new System.Drawing.Point(12, 13);
            this.lblCalendar.Name = "lblCalendar";
            this.lblCalendar.Size = new System.Drawing.Size(65, 17);
            this.lblCalendar.TabIndex = 1;
            this.lblCalendar.Text = "Calendar";
            // 
            // lblAppointments
            // 
            this.lblAppointments.AutoSize = true;
            this.lblAppointments.BackColor = System.Drawing.Color.Yellow;
            this.lblAppointments.Location = new System.Drawing.Point(12, 255);
            this.lblAppointments.Name = "lblAppointments";
            this.lblAppointments.Size = new System.Drawing.Size(94, 17);
            this.lblAppointments.TabIndex = 2;
            this.lblAppointments.Text = "Appointments";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 282);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(269, 84);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Enter appointment";
            // 
            // myCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 378);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblAppointments);
            this.Controls.Add(this.lblCalendar);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "myCalendar";
            this.Text = "My Calendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblCalendar;
        private System.Windows.Forms.Label lblAppointments;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

