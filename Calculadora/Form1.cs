using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        List<string> symbolList = new List<string>();
        bool signPressed = false;
        bool numberPressed = false;
        bool equalPressed = false;
        int operation = 0;
        int totalSum = 0;
        bool openClose = false;
        bool equalRsult = false; 
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
            if (numberPressed && equalPressed)
            {
                string last = mainDisplay.Text.Substring(mainDisplay.Text.Length - 1, 1);
                mainDisplay.Text = last;
                secondDisplay.Text = "";
            }

            if (mainDisplay.Text.StartsWith("0") && mainDisplay.Text.Length > 1 && !symbolList.Any(c => mainDisplay.Text.EndsWith(c)))
            {
                mainDisplay.Text = mainDisplay.Text.Remove(0, 1);
            }

            foreach (string var in symbolList)
            {
                if (mainDisplay.Text.EndsWith(var))
                {
                    secondDisplay.Text = mainDisplay.Text;
                    if (!mainDisplay.Text.Equals("0"))
                        mainDisplay.Text = mainDisplay.Text.Substring(0, mainDisplay.Text.Length-1);
                    break;
                }
            }

            if (signPressed && numberPressed)
            {
                mainDisplay.Text = mainDisplay.Text.Substring(mainDisplay.Text.Length-1, 1);
                signPressed = false;
            }

            equalPressed = false;
            numberPressed = false;
        }

        private void one_Click(object sender, EventArgs e)
        {
            equalRsult=false;
            numberPressed = true;
            mainDisplay.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            equalRsult = false;
            numberPressed = true;
            mainDisplay.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            equalRsult = false;
            numberPressed = true;
            mainDisplay.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            equalRsult = false;
            numberPressed = true;
            mainDisplay.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            equalRsult = false;
            numberPressed = true;
            mainDisplay.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            equalRsult = false;
            numberPressed = true;
            mainDisplay.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            equalRsult = false;
            numberPressed = true;
            mainDisplay.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            equalRsult = false;
            numberPressed = true;
            mainDisplay.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            equalRsult = false;
            numberPressed = true;
            mainDisplay.Text += "9";
        }

        private void allClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            mainDisplay.Text = "0";
            secondDisplay.Text = "";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            signPressed = true;
            if (!mainDisplay.Text.Equals("") && equalRsult==false)
            {
                equal_Click(sender, e);
            }
            operation = 1;
            mainDisplay.Text += "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            signPressed = true;
            if (!mainDisplay.Text.Equals("") && equalRsult == false)
            {
                equal_Click(sender, e);
            }
            operation = 2;
            mainDisplay.Text += "-";
        }

        private void times_Click(object sender, EventArgs e)
        {
            signPressed = true;
            if (!mainDisplay.Text.Equals("") && equalRsult == false)
            {
                equal_Click(sender, e);
            }
            operation = 3;
            mainDisplay.Text += "×";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            signPressed = true;
            if (!mainDisplay.Text.Equals("") && equalRsult == false)
            {
                equal_Click(sender, e);
            }
            operation = 4;
            mainDisplay.Text += "÷";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void equal_Click(object sender, EventArgs e)
        {
            int result = 0;
            equalRsult = true;
            if (!secondDisplay.Text.Equals(""))
            {
                switch (operation)
                {
                    case 1:
                        result=addition(result);
                        break;
                    case 2:
                        result=subtraction(result);
                        break;
                    case 3:
                        result = multiplication(result);
                        break;
                    case 4:
                        result = division(result);
                        break;
                    default: break;
                }
                totalSum += result;
                absoluteSum.Text = "SUMA = " + totalSum.ToString();
            }
            equalPressed = true;
        }
        private int addition(int result)
        {
            historial.Text += secondDisplay.Text + mainDisplay.Text + "=";
            result = (Int32.Parse(mainDisplay.Text)) + (Int32.Parse(secondDisplay.Text.Substring(0, secondDisplay.Text.Length - 1)));
            secondDisplay.Text = secondDisplay.Text + mainDisplay.Text;
            mainDisplay.Text = result.ToString();
            historial.Text += result.ToString()+Environment.NewLine;
            return result;
        }
        private int subtraction(int result)
        {
            historial.Text += secondDisplay.Text + mainDisplay.Text + "=";
            result = ((Int32.Parse(secondDisplay.Text.Substring(0, secondDisplay.Text.Length - 1)) - Int32.Parse(mainDisplay.Text)));
            secondDisplay.Text = secondDisplay.Text + mainDisplay.Text;
            mainDisplay.Text = result.ToString();
            historial.Text += result.ToString() + Environment.NewLine;
            return result;
        }
        private int multiplication(int result)
        {
            historial.Text += secondDisplay.Text + mainDisplay.Text + "=";
            result = (Int32.Parse(mainDisplay.Text)) * (Int32.Parse(secondDisplay.Text.Substring(0, secondDisplay.Text.Length - 1)));
            secondDisplay.Text = secondDisplay.Text + mainDisplay.Text;
            mainDisplay.Text = result.ToString();
            historial.Text += result.ToString() + Environment.NewLine;
            return result;
        }
        private int division(int result)
        {
            if ((Int32.Parse(mainDisplay.Text) == 0))
            {
                MessageBox.Show("No se puede dividir entre cero");
                clear();
            }
            else
            {
                historial.Text += secondDisplay.Text + mainDisplay.Text + "=";
                result = (Int32.Parse(secondDisplay.Text.Substring(0, secondDisplay.Text.Length - 1))) / (Int32.Parse(mainDisplay.Text));
                secondDisplay.Text = secondDisplay.Text + mainDisplay.Text;
                mainDisplay.Text = result.ToString();
                historial.Text += result.ToString() + Environment.NewLine;
                return result;
            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openClose == false)
            {
                this.Width = 665;
                openClose = true;
                historial.Visible = true;
                absoluteSum.Visible = true;
                absoluteSum.Text="SUMA = " + totalSum.ToString();
            }
            else
            {
                this.Width = 350;
                openClose = false;
                historial.Visible = false;
                absoluteSum.Visible = false;
            }
        }
        private void saveHistorial_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog.Title = "Guardar Historial";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, historial.Text);
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de texto|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                historial.Text = System.IO.File.ReadAllText(ofd.FileName);
                openTotalSum();
            }
        }
        private void openTotalSum()
        {
            string[] lines = historial.Lines;
            int totalSum = 0;
            foreach (string line in lines)
            {
                if (line.Length > 0) 
                {
                    int eqIndex = line.IndexOf('=');
                    string stNum = line.Substring(eqIndex + 1, line.Length - eqIndex - 1);
                    totalSum += Int32.Parse(stNum);
                }
            }
            absoluteSum.Text = "SUMA = " + totalSum.ToString();
        }
    }
}
