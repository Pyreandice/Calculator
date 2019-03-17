namespace WindowsFormsApp1
{
    public class CalculatorClass
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
    #endregion

    /// <summary>
    /// Instantiate private enum Operator.
    /// Contains a list of the operators used in basic arithmetic. 
    /// </summary>
        private enum Operator { AdditionChar, SubtractionChar, MultiplicationChar, DivisionChar };

        /// <summary>
        /// Create CurrentValue get; set;
        /// </summary>
        public double CurrentValue { get; set; }

    }
}