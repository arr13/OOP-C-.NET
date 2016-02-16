using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Problem1c
{
    public partial class Calculator : Form
    {
        private enum Operations
        {
            PLUS, MINUS, DIVIDE, MULTIPLY, NO_OP
        };

        private Operations operation;
        private double inputNumber;
        private double result;

        public Calculator()
        {
            InitializeComponent();
            operation = Operations.NO_OP;
            inputNumber = 0.0;
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            

        }

        private void txtCalculatorDisplay_TextChanged(object sender, EventArgs e)
        {
            
             
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            TypeNumber(btn1.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            TypeNumber(btn2.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            TypeNumber(btn3.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            TypeNumber(btn4.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            TypeNumber(btn5.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            TypeNumber(btn6.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            TypeNumber(btn7.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            TypeNumber(btn8.Text);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            TypeNumber(btn9.Text);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            TypeNumber(btn0.Text);
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            TypeNumber(btn00.Text);
        }

        private void TypeNumber(string digit)
        {
            if (txtCalculatorDisplay.Text.Equals("0"))
            {
                txtCalculatorDisplay.Text = digit;
            }
            else
            {
                txtCalculatorDisplay.Text += digit;
            }
        }

        private void InputNumber()
        {
            inputNumber = double.Parse(txtCalculatorDisplay.Text);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            inputNumber = Convert.ToDouble(txtCalculatorDisplay.Text);
            operation = Operations.PLUS;
            txtCalculatorDisplay.Text = "0";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            inputNumber = Convert.ToDouble(txtCalculatorDisplay.Text);
            operation = Operations.MINUS;
            txtCalculatorDisplay.Text = "0";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            inputNumber = Convert.ToDouble(txtCalculatorDisplay.Text);
            operation = Operations.MULTIPLY;
            txtCalculatorDisplay.Text = "0";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            inputNumber = Convert.ToDouble(txtCalculatorDisplay.Text);
            operation = Operations.DIVIDE;
            txtCalculatorDisplay.Text = "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtCalculatorDisplay.Text += ".";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            result = Convert.ToDouble(txtCalculatorDisplay.Text);
            switch (operation)
            {
                case Operations.PLUS:
                    result += inputNumber;
                    inputNumber = result;
                    break;
                case Operations.MINUS:
                    result = inputNumber - result;
                    inputNumber = result;
                    break;
                case Operations.DIVIDE:
                    if (result != 0)
                    {
                        result = inputNumber / result;
                        inputNumber = result;
                    }
                    break;
                case Operations.MULTIPLY:
                    result *= inputNumber;
                    inputNumber = result;
                    break;
                case Operations.NO_OP:
                    txtCalculatorDisplay.Text = "0";
                    break;
            }

            if (operation == Operations.DIVIDE && result == 0)
            {
                txtCalculatorDisplay.Text = "Error";
            }
            else 
            {
                txtCalculatorDisplay.Text = "" + result;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            string text = "";
 
            for (int i = 0; i < txtCalculatorDisplay.Text.Length - 1; ++i)
            {
                text += txtCalculatorDisplay.Text[i];
            }
            
            txtCalculatorDisplay.Text = text;
        }

        private void btnCA_Click(object sender, EventArgs e)
        {
            operation = Operations.NO_OP;
            txtCalculatorDisplay.Text = "0";
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {

        }
    }
}
