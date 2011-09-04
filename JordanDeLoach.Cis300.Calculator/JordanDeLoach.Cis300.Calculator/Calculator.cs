using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JordanDeLoach.Cis300.Calculator
{
    public partial class Calculator : Form
    {
        /// <summary>
        /// Boolean to tell wether or not the Calculator is currently in display mode or not.
        /// </summary>
        private bool _display = true;
        private Stack _stack = new Stack();

        public Calculator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets calculator mode to input, and clears if in Display mode.
        /// </summary>
        private void SetToInputMode()
        {
            if(_display)
                uxResult.Text = "";

            _display = false;
        }

        /// <summary>
        /// Adds the digit to the display.
        /// </summary>
        /// <param name="value"></param>
        private void AddToDisplay(string value)
        {
            if (_display || uxResult.Text == "0")
            {
                SetToInputMode();
                uxResult.Text = value;
            }
            else
            {
                uxResult.Text = uxResult.Text + value;
            }
        }

        /// <summary>
        /// Clears the display and sets the calculator to display mode.
        /// </summary>
        private void ClearDisplay()
        {
            _display = true;
            uxResult.Text = "0";
        }

        /// <summary>
        /// Enters a binary (+,-,X,/) operator
        /// </summary>
        /// <param name="operation"></param>
        private void EnterBinaryOperator(char operation)
        {


            if (!_display)
            {
                HandleEnterButton();
            }
            _stack.Push(operation);
            _display = true;
            // TODO implement next assignment
        }

        /// <summary>
        /// Handles a binary operation.
        /// </summary>
        /// <param name="operation">The operator to be used</param>
        /// <param name="firstOperand">The first value</param>
        /// <param name="secondOperand">The second value</param>
        private double PerformBinaryOperation(char operation, double firstOperand, double secondOperand)
        {
            if (operation == '+')
            {
                return firstOperand + secondOperand;
            }
            else if(operation == '-')
            {
                return firstOperand - secondOperand;
            }
            else if (operation == 'X')
            {
                return firstOperand * secondOperand;
            }
            else
            {
                return firstOperand / secondOperand;
            }
        }

        /// <summary>
        /// Handles when the enter button is placed, taking stuff off the stack, computing, etc.
        /// </summary>
        private void HandleEnterButton()
        {
            _display = true;
            double currentOperand = Convert.ToDouble(uxResult.Text);

            while((_stack.Count > 0) && ((_stack.Peek() is string) || (_stack.Peek() is double)))           
            {
                if (_stack.Peek() is double)
                {
                    double top = (double)_stack.Pop();
                    char operation = (char)_stack.Pop();
                    currentOperand = PerformBinaryOperation(operation, top, currentOperand);
                }
                else if (_stack.Peek() is string)
                {
                    currentOperand = currentOperand * -1;
                }
            }

            uxResult.Text = currentOperand.ToString();

            if (_stack.Count > 0)
            {
                _stack.Push(currentOperand);
            }
        }

        /// <summary>
        /// Event handler for clearing the screen. (CE)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxClearScreen_Click(object sender, EventArgs e)
        {
            ClearDisplay();
            _stack.Clear();
        }

        /// <summary>
        /// Event handler for clearing the screen. (C)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxClear_Click(object sender, EventArgs e)
        {
            ClearDisplay();
        }

        /// <summary>
        /// Handles a click on the 0 button, adds a 0 to the screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxZero_Click(object sender, EventArgs e)
        {
            AddToDisplay("0");
        }

        /// <summary>
        /// Adds a one to the display, handling the event of clicking one.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOne_Click(object sender, EventArgs e)
        {
            AddToDisplay("1");
        }

        /// <summary>
        /// Adds a two to the display.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxTwo_Click(object sender, EventArgs e)
        {
            AddToDisplay("2");
        }

        /// <summary>
        /// Adds a three to the display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxThree_Click(object sender, EventArgs e)
        {
            AddToDisplay("3");
        }

        /// <summary>
        /// Adds a four to the display.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxFour_Click(object sender, EventArgs e)
        {
            AddToDisplay("4");
        }

        /// <summary>
        /// Adds a five to the display.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxFive_Click(object sender, EventArgs e)
        {
            AddToDisplay("5");
        }

        /// <summary>
        /// Adds a six to the display.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSix_Click(object sender, EventArgs e)
        {
            AddToDisplay("6");
        }

        /// <summary>
        /// Adds a seven to the display.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSeven_Click(object sender, EventArgs e)
        {
            AddToDisplay("7");
        }

        /// <summary>
        /// Adds a eight to the display.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxEight_Click(object sender, EventArgs e)
        {
            AddToDisplay("8");
        }

        /// <summary>
        /// Adds a nine to the display.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxNine_Click(object sender, EventArgs e)
        {
            AddToDisplay("9");
        }

        /// <summary>
        /// Handles a click to the divide operand.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxDivide_Click(object sender, EventArgs e)
        {
            EnterBinaryOperator('/');
        }

        /// <summary>
        /// Handles a click to the multiply operand.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxMultiply_Click(object sender, EventArgs e)
        {
            EnterBinaryOperator('X');
        }

        /// <summary>
        /// Handles a click to the subtract operand.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSubtract_Click(object sender, EventArgs e)
        {
            EnterBinaryOperator('-');
        }

        /// <summary>
        /// Handles a click to the add operand.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAdd_Click(object sender, EventArgs e)
        {
            EnterBinaryOperator('+');
        }

        private void uxPeriod_Click(object sender, EventArgs e)
        {
            SetToInputMode();

            if (!uxResult.Text.Contains('.'))
            {
                AddToDisplay(".");
            }
        }

        private void uxEnter_Click(object sender, EventArgs e)
        {
            HandleEnterButton();
        }
    }
}
