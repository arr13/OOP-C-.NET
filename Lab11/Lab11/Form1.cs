using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.txtBoxUsername, "it should be containing ONLY letters a- z (upper or lower case) and at least 2");
            toolTip1.SetToolTip(this.txtBoxPhoneNumber, "it should be of the format (9999) (9999999)");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isValidUserName(txtBoxUsername.Text) == true && 
                isValidPhoneNumber(txtBoxPhoneNumber.Text) == true &&
                isValidEmail(txtBoxEmail.Text) == true && 
                2016 - dTp.Value.Year >= 22)
            {
                MessageBox.Show("OK!");                 
            }
            else
            {
                MessageBox.Show("Not OK!");
            }
        }
        private static bool isValidUserName(String str)
        {
            Regex rg = new Regex(@"^[a-zA-Z]{2,}$");
            Match matcher = rg.Match(str);

            if (matcher.Success == true)
            {
                return true;
            }
            return false;
        }

        private static bool isValidPhoneNumber(String str)
        {
            Regex rg = new Regex(@"^\([0-9]{4}\)\([0-9]{7}\)$");
            Match matcher = rg.Match(str);

            if (matcher.Success == true)
            {
                return true;
            }
            return false;
        }

        private static bool isValidEmail(String str)
        {
            Regex rg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match matcher = rg.Match(str);

            if (matcher.Success == true)
            {
                return true;
            }
            return false;
        }
    }
}
