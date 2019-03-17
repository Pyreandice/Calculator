using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {
        #region Constants
        /// <summary>
        /// The number zero.
        /// </summary>
        private const char NumberZero = '0';

        /// <summary>
        /// The number one.
        /// </summary>
        private const char NumberOne = '1';

        /// <summary>
        /// The number two.
        /// </summary>
        private const char NumberTwo = '2';

        /// <summary>
        /// The number three.
        /// </summary>
        private const char NumberThree = '3';

        /// <summary>
        /// The number four.
        /// </summary>
        private const char NumberFour = '4';

        /// <summary>
        /// The number five.
        /// </summary>
        private const char NumberFive = '5';

        /// <summary>
        /// The number six.
        /// </summary>
        private const char NumberSix = '6';

        /// <summary>
        /// The number seven.
        /// </summary>
        private const char NumberSeven = '7';

        /// <summary>
        /// The number eight.
        /// </summary>
        private const char NumberEight = '8';

        /// <summary>
        /// The number nine.
        /// </summary>
        private const char NumberNine = '9';

        /// <summary>
        /// The division character.
        /// </summary>
        private const char DivisionChar = '/';

        /// <summary>
        /// The multiplication character.
        /// </summary>
        private const char MultiplicationChar = '*';

        /// <summary>
        /// The subtraction character.
        /// </summary>
        private const char SubtractionChar = '-';

        /// <summary>
        /// The addition character.
        /// </summary>
        private const char AdditionChar = '+';

        /// <summary>
        /// The negative character.
        /// </summary>
        private const char NegativeChar = '-';

        /// <summary>
        /// The decimal character.
        /// </summary>
        private const char DecimalChar = '.';

        /// <summary>
        /// The operand stack.
        /// </summary>
        Stack<char> OperandStack = new Stack<char>();

        /// <summary>
        /// The number stack.
        /// </summary>
        Stack<int> NumberStack = new Stack<int>();
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="Calculator"/> class.
        /// </summary>
        public Calculator()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Enters the number '1' to the text box and stack for later calculation.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NumOneButton_Click(object sender, EventArgs e)
        {
            this.OutputTextBox.Text += NumberOne.ToString();
            this.NumberStack.Push(NumberOne);
        }

        /// <summary>
        /// Enters the number '2' to the text box and stack for later calculation.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NumTwoButton_Click(object sender, EventArgs e)
        {
            this.OutputTextBox.Text += NumberTwo.ToString();
            this.NumberStack.Push(NumberTwo);
        }

        /// <summary>
        /// Enters the number '3' to the text box and stack for later calculation.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NumThreeButton_Click(object sender, EventArgs e)
        {
            this.OutputTextBox.Text += NumberThree.ToString();
            this.NumberStack.Push(NumberThree);
        }

        /// <summary>
        /// Enters the number '4' to the text box and stack for later calculation.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NumFourButton_Click(object sender, EventArgs e)
        {
            this.OutputTextBox.Text += NumberFour.ToString();
            this.NumberStack.Push(NumberFour);
        }

        /// <summary>
        /// Enters the number '5' to the text box and stack for later calculation.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NumFiveButton_Click(object sender, EventArgs e)
        {
            this.OutputTextBox.Text += NumberFive.ToString();
            this.NumberStack.Push(NumberFive);
        }

        /// <summary>
        /// Enters the number '6' to the text box and stack for later calculation.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NumSixButton_Click(object sender, EventArgs e)
        {
            this.OutputTextBox.Text += NumberSix.ToString();
            this.NumberStack.Push(NumberSix);
        }

        /// <summary>
        /// Enters the number '7' to the text box and stack for later calculation.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NumSevenButton_Click(object sender, EventArgs e)
        {
            this.OutputTextBox.Text += NumberSeven.ToString();
            this.NumberStack.Push(NumberSeven);
        }

        /// <summary>
        /// Enter the number '8' to the text box and stack for later calculation.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NumEightButton_Click(object sender, EventArgs e)
        {
            this.OutputTextBox.Text += NumberEight.ToString();
            this.NumberStack.Push(NumberEight);
        }

        /// <summary>
        /// Enter the number '9' to the text box and stack for later calculation.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NumNineButton_Click(object sender, EventArgs e)
        {
            this.OutputTextBox.Text += NumberNine.ToString();
            this.NumberStack.Push(NumberNine);
        }

        /// <summary>
        /// Enter the number '0' to the text box and stack for later calculation.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NumZeroButton_Click(object sender, EventArgs e)
        {
            this.OutputTextBox.Text += NumberZero.ToString();
            this.NumberStack.Push(NumberZero);
        }

        /// <summary>
        /// Enter the operator '/' to the text box and stack for later calculation.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DivisonButton_Click(object sender, EventArgs e)
        {
            this.OutputTextBox.Text += DivisionChar.ToString();
            this.OperandStack.Push(DivisionChar);
        }

        /// <summary>
        /// Enter the operator '*' to the text box and stack for later calculation.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            this.OutputTextBox.Text += MultiplicationChar.ToString();
            this.OperandStack.Push(MultiplicationChar);
        }

        /// <summary>
        /// Enter the operator '-' to the text box and stack for later calculation.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SubtractionButton_Click(object sender, EventArgs e)
        {
            this.OutputTextBox.Text += SubtractionChar.ToString();
            this.OperandStack.Push(SubtractionChar);
        }

        /// <summary>
        /// Enter the operator '+' to the text box and stack for later calculation.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AdditionButton_Click(object sender, EventArgs e)
        {
            this.OutputTextBox.Text += AdditionChar.ToString();
            this.OperandStack.Push(AdditionChar);
        }

        /// <summary>
        /// Pop the Last item pushed onto the stack.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.NumberStack.Pop();
            this.OperandStack.Pop();
        }

        /// <summary>
        /// Clears both stacks and resets the program GUI environment.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.NumberStack.Clear();
            this.OperandStack.Clear();
            this.OutputTextBox.Clear();
        }
    }
}
