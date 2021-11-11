using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorApp
{
    public partial class Form1 : Form
    {
        string first;
        string second;
        string userInput;
        string operation;
        double result;

        public Form1()
        {
            InitializeComponent();
        }

        public void DisplayUserInput(string input)
        {
            resultDisplay.Text = "0";
            this.userInput += input;
            resultDisplay.Text = userInput;
        }

        public void SetOperation(string operation)
        {
            this.operation = operation;
            this.first = this.userInput;
            this.userInput = "";
        }

        public void ResetCalculation()
        {
            this.first = "";
            this.second = "";
            this.userInput = "";
            this.result = 0.0;
            resultDisplay.Text = "0";
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            this.DisplayUserInput("0");
        }
        
        private void oneButton_Click(object sender, EventArgs e)
        {
            this.DisplayUserInput("1");
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            this.DisplayUserInput("2");
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            this.DisplayUserInput("3");
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            this.DisplayUserInput("4");
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            this.DisplayUserInput("5");
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            this.DisplayUserInput("6");
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            this.DisplayUserInput("7");
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            this.DisplayUserInput("8");
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            this.DisplayUserInput("9");
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            this.DisplayUserInput(".");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.ResetCalculation();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            this.SetOperation("divide");
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            this.SetOperation("multiply");
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            this.SetOperation("addition");
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            this.SetOperation("substract");
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            this.second = this.userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(this.first);
            secondNum = Convert.ToDouble(this.second);
            this.result = Utilities.Calculate(this.operation, firstNum, secondNum);
            resultDisplay.Text = this.result.ToString();
        }
    }
}
