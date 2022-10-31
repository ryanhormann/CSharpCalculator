using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calc
    {
        //constructors
        public Calc()
        {
            DisplayValue = "0";
            UserValue1 = 0;
            UserValue2 = 0;
            CalcType = "";
        }

        //properties
        public String DisplayValue { get; set; }

        public double UserValue1 { get; set; }

        public double UserValue2 { get; set; }

        public string CalcType { get; set; }

        //methods
        public string UpdateDisplay(double num)
        {
            if (DisplayValue == "0")
            {
                DisplayValue = num.ToString();
            }
            else
            {
                DisplayValue = DisplayValue + num.ToString();
            }

            return DisplayValue;
        }

        public string AddDecimal()
        {
            if (!DisplayValue.Contains("."))
            {
                DisplayValue = DisplayValue + ".";
            }

            return DisplayValue;
        }

        public string ChangeSign()
        {
            if (double.Parse(DisplayValue) != 0)
            {
                if (!DisplayValue.Contains("-"))
                {
                    DisplayValue = "-" + DisplayValue;
                }
                else
                {
                    DisplayValue = DisplayValue.Remove(0, 1);
                }
            }

            return DisplayValue;
        }

        public string ClearDisplay()
        {
            DisplayValue = "0";
            UserValue1 = 0;
            UserValue2 = 0;
            CalcType = "";

            return DisplayValue;
        }

        public string Calculate(double num1, double num2, string type)
        {
            if (type == "/" && UserValue2 == 0)
            {
                MessageBox.Show("Cannot divide by zero");
                ClearDisplay();
                return DisplayValue;
            }
            else
            {
                switch (type)
                {
                    case "/":
                        DisplayValue = Division(num1, num2).ToString();
                        break;
                    case "*":
                        DisplayValue = Multiplication(num1, num2).ToString();
                        break;
                    case "+":
                        DisplayValue = Addition(num1, num2).ToString();
                        break;
                    case "-":
                        DisplayValue = Subtraction(num1, num2).ToString();
                        break;
                }
            }

            return DisplayValue;
        }

        private double Division(double num1, double num2)
        {
            return num1 / num2;
        }

        private double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        private double Addition(double num1, double num2)
        {
            return num1 + num2;
        }

        private double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }

        public string Backspace()
        {
            if (DisplayValue.Length == 2 && DisplayValue.Contains("-"))
            {
                return DisplayValue;
            }
            else if (DisplayValue.Length == 1)
            {
                DisplayValue = "0";
            }
            else
            {
                DisplayValue = DisplayValue.Remove(DisplayValue.Length - 1, 1);
            }

            return DisplayValue;
        }
    }
}
