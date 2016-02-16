using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem5___3b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // hide labels that vizualize the count and the current result 
            lblAllHeads.Text = ""; 
            lblAllTails.Text = "";
            lblCurrentFlip.Text = "";

            //disable the button that shows the result of the count
            btnShow.Enabled = false;
        }

        private void btnToss_Click(object sender, EventArgs e)
        {
            // enable the button that shows the result
            btnShow.Enabled = true;

            // hides the labels that shows the result if the button toss has been pressed again
            if (lblAllHeads.Text != "")
            {
                lblAllHeads.Text = "";
                lblAllTails.Text = "";
            }

            int rndNumber = randomNumber.Next(1, 101); // declares a random number and initialize it
            // calls the method Flip() and show the current flip in label
            if (Flip(rndNumber) == true)
            {
                lblCurrentFlip.Text = "tail"; 
            }
            else
            {
                lblCurrentFlip.Text = "head";
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            // hide label for the current result
            lblCurrentFlip.Text = "";

            // shows the result of the count
            lblAllTails.Text = "tails: " + countFlips[0];
            lblAllHeads.Text = "heads: " + countFlips[1];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close the program
            Close();
        }

        private Random randomNumber = new Random(); // object thst creates random number
        private int[] countFlips = new int[2]; // array that counts all the flips

        private bool Flip(int currentFlip)
        {
            if (currentFlip % 2 == 0)
            {
                countFlips[0]++; // increment the element for tails
                return false;
            }
            else
            {
                countFlips[1]++; // increment the element for heads
                return true;
            }
        }
    }
}
