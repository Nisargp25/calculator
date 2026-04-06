using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double num1 = 0;
        private double num2 = 0;
        private string operation = "";
        private bool isOperationPressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void AppendNumber(string number)
        {
            if (isOperationPressed)
            {
                displayTextBox.Text = number;
                isOperationPressed = false;
            }
            else
            {
                displayTextBox.Text += number;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            AppendNumber("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AppendNumber("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            AppendNumber("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AppendNumber("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AppendNumber("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AppendNumber("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AppendNumber("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            AppendNumber("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            AppendNumber("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            AppendNumber("9");
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!displayTextBox.Text.Contains("."))
            {
                displayTextBox.Text += ".";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HandleOperation("+");
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            HandleOperation("-");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            HandleOperation("*");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            HandleOperation("/");
        }

        private void HandleOperation(string op)
        {
            if (double.TryParse(displayTextBox.Text, out double value))
            {
                if (operation != "" && !isOperationPressed)
                {
                    num2 = value;
                    CalculateResult();
                    displayTextBox.Text = num1.ToString();
                }
                else
                {
                    num1 = value;
                }
            }
            operation = op;
            isOperationPressed = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (double.TryParse(displayTextBox.Text, out double value))
            {
                num2 = value;
                CalculateResult();
                displayTextBox.Text = num1.ToString();
                operation = "";
            }
        }

        private void CalculateResult()
        {
            switch (operation)
            {
                case "+":
                    num1 = num1 + num2;
                    break;
                case "-":
                    num1 = num1 - num2;
                    break;
                case "*":
                    num1 = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        num1 = num1 / num2;
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        displayTextBox.Text = "0";
                        ClearAll();
                    }
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            displayTextBox.Text = "0";
            num1 = 0;
            num2 = 0;
            operation = "";
            isOperationPressed = false;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            string current = displayTextBox.Text;
            if (current.Length > 0)
            {
                displayTextBox.Text = current.Substring(0, current.Length - 1);
            }
            if (displayTextBox.Text.Length == 0)
            {
                displayTextBox.Text = "0";
            }
        }
    }
}
