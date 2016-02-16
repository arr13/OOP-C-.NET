using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_Problem3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBoxInsertNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxInsertNumber.Text != "")
            {
                btnComputeOneS.Enabled = true;
                btnComputeTwoS.Enabled = true;
            }
        }

        private void btnComputeOneS_Click(object sender, EventArgs e)
        {
           int number = int.Parse(txtBoxInsertNumber.Text);
           textBox1.Text = Convert.ToString(ComputeOneS(number));
            
        }

        private int ComputeOneS(int number)
        {
            int mask = 1 << 31;
            for (int i = 30; i >= 0; --i)
            {
                number = number ^ mask;
                mask = 1 << i;
            }
            return number;
        }
    }
}
