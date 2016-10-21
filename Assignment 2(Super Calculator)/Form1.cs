using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2_Super_Calculator_
{
    public partial class Form1 : Form
    {
        double firstInput;
        double secondInput;
        double answ;
        bool sum = false;
        bool minus = false;
        bool product = false;
        bool quotient = false;
        string Answer = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button Numbers = (Button)sender;
            OutputScreen.Text = OutputScreen.Text + Numbers.Text;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            OutputScreen.Text = string.Empty;
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            if (OutputScreen.Text.Contains(".") == true)
            {
                OutputScreen.Text = OutputScreen.Text;
            }
            else
            {
                OutputScreen.Text = OutputScreen.Text + ".";
            }
        }

        private void Product_Click(object sender, EventArgs e)
        {
            firstInput = Convert.ToDouble(OutputScreen.Text);
            OutputScreen.Text = string.Empty;
            product = true;


        }

        private void Quotient_Click(object sender, EventArgs e)
        {
            firstInput = Convert.ToDouble(OutputScreen.Text);
            OutputScreen.Text = string.Empty;
            quotient = true;

        }

        private void Sum_Click(object sender, EventArgs e)
        {
                firstInput = Convert.ToDouble(OutputScreen.Text);
                OutputScreen.Text = string.Empty;
                sum = true;
           
        }

        private void Difference_Click(object sender, EventArgs e)
        {
            if (OutputScreen.Text == "")
            {
                OutputScreen.Text = OutputScreen.Text + "-";
            }
            else
            {
                firstInput = Convert.ToDouble(OutputScreen.Text);
                OutputScreen.Text = string.Empty;
                minus = true;
            }

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Equals_Click(object sender, EventArgs e)
        {
           
            if (sum == true)
            {
                secondInput = Convert.ToDouble(OutputScreen.Text);
                answ = firstInput + secondInput;
                Answer = Convert.ToString(answ);
                OutputScreen.Text = Answer;
            }

            else if (minus == true)
            {
                secondInput = Convert.ToDouble(OutputScreen.Text);
                answ = firstInput - secondInput;
                Answer = Convert.ToString(answ);
                OutputScreen.Text = Answer;
            }

            else if (product == true)
            {
                secondInput = Convert.ToDouble(OutputScreen.Text);
                answ = firstInput * secondInput;
                Answer = Convert.ToString(answ);
                OutputScreen.Text = Answer;
            }

            else if (quotient == true)
            {
                secondInput = Convert.ToDouble(OutputScreen.Text);
                answ = firstInput / secondInput;
                Answer = Convert.ToString(answ);
                OutputScreen.Text = Answer;
            }

            sum = false;
            minus = false;
            product = false;
            quotient = false;
        }
    }
}
