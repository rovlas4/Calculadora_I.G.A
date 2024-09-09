using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        List<string> symbolList = new List<string>();
        int num1 = 0;
        bool signPressed = false;
        bool numberPressed = false;
        int operation = 0;

        public Form1()
        {
            InitializeComponent();
            symbolList.Add("+");
            symbolList.Add("-");
            symbolList.Add("×");
            symbolList.Add("÷");
        }

        private void zero_Click(object sender, EventArgs e)
        {
            numberPressed = true;

            if (mainDisplay.Text != "0")
                mainDisplay.Text += "0";
        }

        private void mainDisplay_TextChanged(object sender, EventArgs e)
        {
            if (mainDisplay.Text.StartsWith("0") && mainDisplay.Text.Length > 1)
            {
                mainDisplay.Text = mainDisplay.Text.Remove(0, 1);
            }

            foreach (string var in symbolList)
            {
                if (mainDisplay.Text.EndsWith(var))
                {
                    secondDisplay.Text = mainDisplay.Text;
                    mainDisplay.Text = mainDisplay.Text.Substring(0, mainDisplay.Text.Length-1);
                    num1 = Int32.Parse(mainDisplay.Text);
                }
            }

            if (signPressed && numberPressed)
            {
                mainDisplay.Text = mainDisplay.Text.Substring(mainDisplay.Text.Length-1, 1);
                signPressed = false;
            }

            numberPressed = false;
        }

        private void one_Click(object sender, EventArgs e)
        {
            numberPressed = true;
            mainDisplay.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            numberPressed = true;
            mainDisplay.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            numberPressed = true;
            mainDisplay.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            numberPressed = true;
            mainDisplay.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            numberPressed = true;
            mainDisplay.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            numberPressed = true;
            mainDisplay.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            numberPressed = true;
            mainDisplay.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            numberPressed = true;
            mainDisplay.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            numberPressed = true;
            mainDisplay.Text += "9";
        }

        private void allClear_Click(object sender, EventArgs e)
        {
            mainDisplay.Text = "0";
            secondDisplay.Text = "";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            signPressed = true;
            mainDisplay.Text += "+";
            operation = 1;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            signPressed = true;
            mainDisplay.Text += "-";
            operation = 2;
        }

        private void times_Click(object sender, EventArgs e)
        {
            signPressed = true;
            mainDisplay.Text += "×";
            operation = 3;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            signPressed = true;
            mainDisplay.Text += "÷";
            operation = 4;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void equal_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (!secondDisplay.Text.Equals(""))
            {
                switch (operation)
                {
                    case 1:
                        result = (Int32.Parse(mainDisplay.Text)) + (Int32.Parse(secondDisplay.Text.Substring(0, secondDisplay.Text.Length - 1)));
                        secondDisplay.Text = secondDisplay.Text + mainDisplay.Text;
                        mainDisplay.Text = result.ToString();
                        operation = 0;
                        break;
                    case 2:
                        result = (Int32.Parse(mainDisplay.Text)) - (Int32.Parse(secondDisplay.Text.Substring(0, secondDisplay.Text.Length - 1)));
                        secondDisplay.Text = secondDisplay.Text + mainDisplay.Text;
                        mainDisplay.Text = result.ToString();
                        operation = 0;
                        break;
                    case 3:
                        result = (Int32.Parse(mainDisplay.Text)) * (Int32.Parse(secondDisplay.Text.Substring(0, secondDisplay.Text.Length - 1)));
                        secondDisplay.Text = secondDisplay.Text + mainDisplay.Text;
                        mainDisplay.Text = result.ToString();
                        operation = 0;
                        break;
                    case 4:
                        if ((Int32.Parse(mainDisplay.Text)==0))
                        {
                            MessageBox.Show("No se puede dividir entre cero");
                        }
                        else
                        {
                            result = (Int32.Parse(secondDisplay.Text.Substring(0, secondDisplay.Text.Length - 1))) / (Int32.Parse(mainDisplay.Text));
                            secondDisplay.Text = secondDisplay.Text + mainDisplay.Text;
                            mainDisplay.Text = result.ToString();
                            operation = 0;
                        }
                        break;
                    default: break;
                }
            }
        }
    }
}
