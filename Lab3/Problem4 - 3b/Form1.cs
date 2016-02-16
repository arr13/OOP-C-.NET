using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem4___3b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnNewTask.Enabled = false; // disable button New Task
            btnCheck.Enabled = false; // disable button Check
            lblDisplay.Text = ""; // initialize label for the question
            lblNo.Text = ""; // initialize label for the no answer
            lblVeryGood.Text = ""; // initilize label for the yes answer
            GenerateTask(); // call the function that makes the first task
        }

        private void btnNewTask_Click(object sender, EventArgs e)
        {
            // if the given answer is false or true
            if (lblNo.Text == "No. Please try again.")
            {
                lblNo.Text = "";
                lblVeryGood.Text = "";
                txtBoxAnswer.Text = "";
                btnNewTask.Enabled = false;
            }
            else
            {
                lblNo.Text = "";
                lblVeryGood.Text = "";
                txtBoxAnswer.Text = "";
                txtBoxAnswer.Enabled = false;
                GenerateTask();
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //exit of the program
            Close();
        }

        private void GenerateTask()
        {
            btnNewTask.Enabled = false; // disable button New Task
            int number1 = randomNumbers.Next(0, 10); // creates random number for the first number
            int number2 = randomNumbers.Next(0, 10); // creates random number for the second number
            currentResult = number1 * number2; // find the true answer
            lblDisplay.Text = "How much is " + number1 + " times " + number2 + "?"; // display the question
            txtBoxAnswer.Enabled = true; // enabke textBox where will be given the answer
        }

        private Random randomNumbers = new Random(); // creates random numbers
        private int currentResult; // variable for the true answer

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // if the answer is false use no-answer label
            if (int.Parse(txtBoxAnswer.Text) != currentResult)
            {
                lblNo.Text = "No. Please try again";
                txtBoxAnswer.Text = "";
            }
            else
            {
                lblNo.Text = "Very good!";
                lblDisplay.Text = "";
                txtBoxAnswer.Text = "";
                txtBoxAnswer.Enabled = false;
                btnNewTask.Enabled = true;
            }
        }

        private void txtBoxAnswer_TextChanged(object sender, EventArgs e)
        {
            // if there is or there is no text in textbox enable disable some of the tools
            if (txtBoxAnswer.Text != "")
            {
                btnCheck.Enabled = true;
                lblNo.Text = "";
                lblVeryGood.Text = "";
                btnNewTask.Enabled = false;
            }
            else
            {
                btnCheck.Enabled = false;
            }
        }

    }
}
