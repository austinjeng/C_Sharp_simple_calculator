using System;
using System.Windows.Forms;

namespace C_Sharp_simple_calculator
{
    public partial class Form1 : Form
    {

        double number1;
        double number2;

        String function = "";

        

        public Form1()
        {
            InitializeComponent();

            testBoxResult.Text = "0";
        }

        void numberCLick(object sender)
        {
            Button button = (Button)sender;

            if (testBoxResult.Text.Equals("0") && button.Text.Equals("."))
            {
                testBoxResult.Text = testBoxResult.Text + button.Text;
                
            } 
            else if(testBoxResult.Text.Equals(".") && button.Text.Equals("."))
            {
                testBoxResult.Text = button.Text;
            }
            else if(testBoxResult.Text.Equals("0"))
            {
                testBoxResult.Text = button.Text;
            }
            else {
                testBoxResult.Text = testBoxResult.Text + button.Text;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
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
            number2 = Convert.ToDouble(testBoxResult.Text);
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

        private void ButtonDecimal_Click(object sender, EventArgs e)
        {
            numberCLick(sender);
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
            if(testBoxResult.Text == "")
            {
                MessageBox.Show("Input can not be empty! Please make sure you have valid input!");
                return;
            }

            number1 = Convert.ToDouble(testBoxResult.Text);
            testBoxResult.Text = "";
        }

        
    }
}
