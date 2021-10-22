using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_simple_calculator
{
    public partial class Form1 : Form
    {

        int number1;
        int number2;

        String function = "";

        public Form1()
        {
            InitializeComponent();
        }

        void numberCLick(object sender)
        {
            Button button = (Button)sender;

            if (testBoxResult.Text.Equals("0"))
            {
                testBoxResult.Text = button.Text;
            }
            else
            {
                testBoxResult.Text = testBoxResult.Text + button.Text;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Dont touch here LOL
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            saveNumber1();
            function = "+";
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            saveNumber1();
            function = "-";
        }

        private void ButtonMultiple_Click(object sender, EventArgs e)
        {
            saveNumber1();
            function = "*";
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            saveNumber1();
            function = "/";
        }

        private void ButtonModel_Click(object sender, EventArgs e)
        {
            saveNumber1();
            function = "%";
        }

        private void ButtonCE_Click(object sender, EventArgs e)
        {
            testBoxResult.Text = "0";
            function = "";
        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToInt32(testBoxResult.Text);
            testBoxResult.Text = "";

            if(function == "+")
            {
                testBoxResult.Text = (number1 + number2).ToString();
                
            }else if (function == "-")
            {
                testBoxResult.Text = (number1 - number2).ToString();

            }
            else if (function == "*")
            {
                testBoxResult.Text = (number1 * number2).ToString();

            }
            else if (function == "/")
            {
                testBoxResult.Text = (number1 / number2).ToString();

            }
            else if (function == "%")
            {
                testBoxResult.Text = (number1 % number2).ToString();

            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            numberCLick(sender);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            numberCLick(sender);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            numberCLick(sender);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            numberCLick(sender);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            numberCLick(sender);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            numberCLick(sender);
        }

        private void Buttton7_Click(object sender, EventArgs e)
        {
            numberCLick(sender);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            numberCLick(sender);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            numberCLick(sender);
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            numberCLick(sender);
        }

        void saveNumber1()
        {
            number1 = Convert.ToInt32(testBoxResult.Text);
            testBoxResult.Text = "";
        }
    }
}
