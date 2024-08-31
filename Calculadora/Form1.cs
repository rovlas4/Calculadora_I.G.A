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
        public Form1()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (mainDisplay.Text != "0")
                mainDisplay.Text += "0";
        }

        private void mainDisplay_TextChanged(object sender, EventArgs e)
        {
            List<string> symbolList = new List<string>();
            symbolList.Add("+");
            symbolList.Add("-");
            symbolList.Add("×");
            symbolList.Add("÷");

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
                }
                if (secondDisplay.Text.EndsWith(var))
                {

                }
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            mainDisplay.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            mainDisplay.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            mainDisplay.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            mainDisplay.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            mainDisplay.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            mainDisplay.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            mainDisplay.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            mainDisplay.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            mainDisplay.Text += "9";
        }

        private void allClear_Click(object sender, EventArgs e)
        {
            mainDisplay.Text = "0";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            mainDisplay.Text += "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            mainDisplay.Text += "-";
        }

        private void times_Click(object sender, EventArgs e)
        {
            mainDisplay.Text += "×";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            mainDisplay.Text += "÷";
        }
    }
}
