using System;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Calc calc = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = calc.UpdateDisplay(0);
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = calc.UpdateDisplay(1);
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = calc.UpdateDisplay(2);
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = calc.UpdateDisplay(3);
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = calc.UpdateDisplay(4);
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = calc.UpdateDisplay(5);
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = calc.UpdateDisplay(6);
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = calc.UpdateDisplay(7);
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = calc.UpdateDisplay(8);
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = calc.UpdateDisplay(9);
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = calc.AddDecimal();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            calc.UserValue1 = double.Parse(calc.DisplayValue);
            calc.CalcType = "/";
            displayLabel.Text = "0";
            calc.DisplayValue = "0";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            calc.UserValue1 = double.Parse(calc.DisplayValue);
            calc.CalcType = "*";
            displayLabel.Text = "0";
            calc.DisplayValue = "0";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            calc.UserValue1 = double.Parse(calc.DisplayValue);
            calc.CalcType = "+";
            displayLabel.Text = "0";
            calc.DisplayValue = "0";
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            calc.UserValue1 = double.Parse(calc.DisplayValue);
            calc.CalcType = "-";
            displayLabel.Text = "0";
            calc.DisplayValue = "0";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = calc.ClearDisplay();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = calc.Backspace();
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            calc.UserValue2 = double.Parse(calc.DisplayValue);
            displayLabel.Text = calc.Calculate(calc.UserValue1, calc.UserValue2, calc.CalcType);
        }

        private void signButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = calc.ChangeSign();
        }
    }
}