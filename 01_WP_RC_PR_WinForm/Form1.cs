using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _01_WP_RC_PR_WinForm
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// It will store the evaluated result of each exression
        /// </summary>
        private ArrayList expressionResult = new ArrayList();

        /// <summary>
        /// It will store the buttons clicked by the user, the most recent will be in the last.
        /// </summary>
        private ArrayList pressedButtonList = new ArrayList();

        /// <summary>
        /// It will be used for performing the operatoin  
        /// </summary>
        private string Operator = "x";

        /// <summary>
        /// Will be used as first operand to perform binary operation
        /// </summary>
        private double firstOperand = 1;

        /// <summary>
        /// Will be used as second operand to perform binary operation
        /// </summary>
        private double secondOperand = 1;

        /// <summary>
        /// It will hold the result of operation
        /// </summary>
        private double result = 0;

        /// <summary>
        /// Store the current evaluating expression.
        /// </summary>
        private string expressionValue = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
        private void oneButton_Click(object sender, EventArgs e)
        {
            clickDigit("1");
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            clickDigit("2");
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            clickDigit("3");
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            clickDigit("4");
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            clickDigit("5");
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            clickDigit("6");
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            clickDigit("7");
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            clickDigit("8");
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            clickDigit("9");
        }
        private void zeroButton_Click(object sender, EventArgs e)
        {
            clickDigit("0");
        }

        private void clickDigit(string digit)
        {
            if (lastClickEqualOperator())
            {
                // equal operator was clicked last
                // reset all fields by invoking clickC method
                clickC();
            }

            if (lastClickDigit())
            {
                // last click is digit or "."
                if (inputTextBox.Text.StartsWith("."))
                {
                    string number = inputTextBox.Text.Substring(1);
                    inputTextBox.Text = number + "." + digit;

                }
                else
                {
                    inputTextBox.Text += digit;
                }
            }
            else if (lastClickOperator())
            {
                // last click is operator
                inputTextBox.Text = digit;
            }
            // else
            // {
            //     // first digit or input
            //     inputTextBox.Text = digit;
            // }
            // add digit to pressedButtonList
            pressedButtonList.Add(digit);
        }

        private bool lastClickDigit()
        {

            if (pressedButtonList.Count > 0)
            {
                string lastClick = pressedButtonList[pressedButtonList.Count - 1].ToString();
                if (lastClick == "0") { return true; }
                if (lastClick == "1") { return true; }
                if (lastClick == "2") { return true; }
                if (lastClick == "3") { return true; }
                if (lastClick == "4") { return true; }
                if (lastClick == "5") { return true; }
                if (lastClick == "6") { return true; }
                if (lastClick == "7") { return true; }
                if (lastClick == "8") { return true; }
                if (lastClick == "9") { return true; }
                if (lastClick == ".") { return true; }

                return false;
            }
            else { return true; }

        }

        private bool lastClickEqualOperator()
        {

            if (pressedButtonList.Count > 0)
            {
                string lastClick = pressedButtonList[pressedButtonList.Count - 1].ToString();

                if (lastClick == "=")
                {
                    return true;
                }
            }
            return false;
        }

        private bool lastClickOperator()
        {
            if (pressedButtonList.Count > 0)
            {
                string lastClick = pressedButtonList[pressedButtonList.Count - 1].ToString();
                if (lastClick == "+") { return true; }
                if (lastClick == "-") { return true; }
                if (lastClick == "/") { return true; }
                if (lastClick == "%") { return true; }
                if (lastClick == "x") { return true; }
                if (lastClick == "ce") { return true; }
            }
            return false;
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            // add "." to pressedButtonList
            pressedButtonList.Add(".");

            if (inputTextBox.Text.Length > 0)
            {
                inputTextBox.Text = $".{inputTextBox.Text}";
            }
            else
            {
                inputTextBox.Text = ".0";
            }
        }

        private void signChangeButton_Click(object sender, EventArgs e)
        {

            // add "+/-" to pressedButtonList
            pressedButtonList.Add("+/-");

            if (inputTextBox.Text.StartsWith("-"))
            {
                // input is negative
                inputTextBox.Text = inputTextBox.Text.Substring(1);
            }
            else
            {

                string num = inputTextBox.Text;
                num = $"{num}-";
                inputTextBox.Text = num;
            }

            // update expression string value
            // with first number operator
            expressionValue = $"= ( {inputTextBox.Text} )negate";

            // update expressionTextBox with expression string value
            expressionTextBox.Text = expressionValue;



        }

        private void cButton_Click(object sender, EventArgs e)
        {
            clickC();
        }

        private void clickC()
        {
            // clear input text box
            inputTextBox.Text = "";

            // clear expression text box
            expressionTextBox.Text = "";

            // clear expression results
            expressionResult.Clear();

            // clear pressed button list
            pressedButtonList.Clear();

            // set operator with default value 'x'
            Operator = "x";

            // set first operand with default value '1'
            firstOperand = 1;

            // set second operand with default value '2'
            secondOperand = 1;

            // clear expression string value
            expressionValue = "";
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Length > 0)
            {
                // remove the last character from inputTextBox 
                inputTextBox.Text = inputTextBox.Text.Substring(0, inputTextBox.Text.Length - 1);

                // remove the last element from pressedButtonList
                pressedButtonList.RemoveAt(pressedButtonList.Count - 1);

            }

        }

        private void ceButton_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Length > 0)
            {
                // clear the input screen
                inputTextBox.Text = "";

                // pop the last expression value from value array of expression
                if (expressionResult.Count > 0)
                {
                    expressionResult.RemoveAt(expressionResult.Count - 1);
                }
            }

            // add "ce" to pressedButtonList
            pressedButtonList.Add("ce");
        }

        private void oneByXButton_Click(object sender, EventArgs e)
        {
            clickUnaryOperator("1/x");
        }


        private void xSquareButton_Click(object sender, EventArgs e)
        {

            clickUnaryOperator("sqr");
        }

        private void xSquareRootButton_Click(object sender, EventArgs e)
        {
            clickUnaryOperator("sqrt");
        }

        private void clickUnaryOperator(string Opr)
        {
            // calculate square root 
            if (inputTextBox.Text.Length > 0)
            {
                // add Opr to clicked button list
                pressedButtonList.Add(Opr);

                // calculating result value

                // store number from input screen
                if (inputTextBox.Text.EndsWith("-"))
                {
                    // if input number is negative
                    firstOperand = Convert.ToDouble(inputTextBox.Text.Substring(0, inputTextBox.Text.Length - 1));

                    switch (Opr)
                    {
                        case "1/x":
                            // negative exp for 1/x
                            expressionValue = $"( {firstOperand:.##}- )/1";
                            break;

                        case "sqr":
                            // negative exp for sqr
                            expressionValue = $"( {firstOperand:.##}- )sqr";
                            break;

                        case "sqrt":
                            // negative exp for sqrt
                            expressionValue = $"( {firstOperand:.##}- )sqrt";
                            break;

                    }

                    firstOperand = -firstOperand;

                }
                else
                {
                    // Positive Case 
                    // if input number is positive
                    firstOperand = Convert.ToDouble(inputTextBox.Text);

                    switch (Opr)
                    {
                        case "1/x":
                            // positive exp for 1/x
                            expressionValue = $"( {firstOperand:.##} )/1";
                            break;

                        case "sqr":
                            // positive exp for sqr
                            expressionValue = $"( {firstOperand:.##} )sqr";
                            break;

                        case "sqrt":
                            // positive exp for sqrt
                            expressionValue = $"( {firstOperand:.##} )sqrt";
                            break;

                    }
                }

                double result = 0;

                switch (Opr)
                {
                    case "1/x":
                        // result calculation for 1/x
                        result = Math.Round(1.0d / firstOperand, 10);
                        break;

                    case "sqr":
                        // result calculation for sqr
                        result = Math.Pow(firstOperand, 2);
                        break;

                    case "sqrt":
                        // result calculation for sqrt
                        result = Math.Round(Math.Sqrt(firstOperand), 4);
                        break;

                }

                // update expressionTextBox with expression string value
                expressionTextBox.Text = expressionValue;

                // add result value to expressionValue
                expressionResult.Add(result);


                // update inputTextBox 
                inputTextBox.Text = result.ToString();

                // reset firstOperand
                firstOperand = 1;
            }
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            // check inputTextBox must not be empty
            if (inputTextBox.Text.Length > 0)
            {
                // store second number from input screen
                if (!inputTextBox.Text.EndsWith("-"))
                {
                    // Positive second operand
                    secondOperand = Convert.ToDouble(inputTextBox.Text);

                    if (firstOperand < 0)
                    {
                        // negative first operand
                        // positive second operand
                        if (Operator == "x")
                        {
                            // expressionValue = $"(prod)    {firstOperand} {Operator} {secondOperand} = n";   // works
                            expressionValue = $"(prod)    {firstOperand} {Operator} {secondOperand} ";
                        }
                        else
                        {
                            expressionValue = $"= {secondOperand} {Operator} {firstOperand.ToString().Substring(1)}-";
                        }
                    }
                    else
                    {
                        // Positive both - first and second operand

                        if (Operator == "x")
                        {
                            // expressionValue = $"(prod)    {firstOperand} {Operator} {secondOperand} = n";    // works 
                            expressionValue = $"(prod)    {firstOperand} {Operator} {secondOperand} ";
                        }
                        else
                        {
                            expressionValue = $"= {secondOperand} {Operator} {firstOperand}";
                        }
                    }
                }
                else
                {
                    // if second input number is negative
                    secondOperand = Convert.ToDouble(inputTextBox.Text.Substring(0, inputTextBox.Text.Length - 1));

                    if (firstOperand < 0)
                    {
                        // negative both - first operand & second operand
                        if (Operator == "x")
                        {
                            // expressionValue = $"(prod)    {firstOperand} {Operator} -{secondOperand} = n";   // works
                            expressionValue = $"(prod)    {firstOperand} {Operator} -{secondOperand} ";
                        }
                        else
                        {
                            expressionValue = $"= {secondOperand}- {Operator} {firstOperand.ToString().Substring(1)}-";
                        }
                    }
                    else
                    {
                        // postive first operand 
                        // negative second operand
                        // expressionValue = $"(prod)    {firstOperand} {Operator} -{secondOperand} = n";   // works
                        expressionValue = $"(prod)    {firstOperand} {Operator} -{secondOperand} ";
                    }

                    secondOperand = -secondOperand;
                }

                // set result = first 'operand' second (operand --> +, -, *, /, %)
                result = calculateResult(firstOperand, secondOperand, Operator);
                Math.Round(result, 4);


                // add result to expressionValue array
                expressionResult.Add(result);

                // print result on input screen
                if (result < 0) // negative result
                {
                    string res = result.ToString().Substring(1);
                    res = $"{res}-";
                    inputTextBox.Text = res;
                }
                else
                {
                    inputTextBox.Text = result.ToString();
                }

                // add "=" to pressedButtonList
                pressedButtonList.Add("=");


                // update expressionTextBox with expression string value
                expressionTextBox.Text = expressionValue;

                // reset the values of first and second operand
                firstOperand = 1;
                secondOperand = 1;
            }

        }

        private double calculateResult(double num1, double num2, string op)
        {
            double res = 0;
            if (op == "+") { res = num1 + num2; }
            else if (op == "-") { res = num1 - num2; }
            else if (op == "x") { res = num1 * num2; }
            else if (op == "/") { res = num1 / num2; }
            else if (op == "%") { res = num1 % num2; }

            return Math.Round(res, 4);
        }
        private void plusButton_Click(object sender, EventArgs e)
        {
            clickOperator("+");
        }

        /// <summary>
        /// Opr will take an operator (+, -, /, %) as argument.
        /// </summary>
        /// <param name="Opr"></param>
        private void clickOperator(string Opr)
        {
            // can be used for operators:  +, -, /, %, x(multiply)
            // check inputTextBox must not be empty
            if (inputTextBox.Text.Length > 0)
            {
                // add Opr to pressedButtonList
                pressedButtonList.Add(Opr);

                // set Operator to Opr 
                Operator = Opr;

                // store first number from input screen
                if (inputTextBox.Text.EndsWith("-"))
                {
                    // if input number is negative
                    firstOperand = Convert.ToDouble(inputTextBox.Text.Substring(0, inputTextBox.Text.Length - 1));

                    // update expression string value
                    // with first number operator

                    if (Operator == "x")
                    {
                        // for multiply operator only
                        expressionValue = $"(prod)    -{firstOperand} {Operator}";

                    }
                    else
                    {
                        // for other than multiply operator, such as +, -, /, %
                        expressionValue = $"{Operator} {firstOperand}-";
                    }

                    // making number negative as it is
                    firstOperand = -firstOperand;
                }
                else
                {
                    // if input number is positive
                    firstOperand = Convert.ToDouble(inputTextBox.Text);

                    if (Operator == "x")
                    {
                        // for multiply operator only
                        expressionValue = $"(prod)    {firstOperand} {Operator}";
                    }
                    else
                    {
                        // for other than multiply operator, such as +, -, /, %
                        expressionValue = $"{Operator} {firstOperand}";

                    }
                }

                // update expressionTextBox with expression string value
                expressionTextBox.Text = expressionValue;
            }
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            clickOperator("-");
        }

        private void moduloButton_Click(object sender, EventArgs e)
        {
            clickOperator("%");
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            clickOperator("x");
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            clickOperator("/");

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // OPERATORS HANDLING

            // Note: +, -, *, / and % are defined in Form1_KeyPress method

            // case for numeric keypad enter key and main keyboard enter key
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                // TODO - generating % insted Enter key, solve this error
                equalButton.PerformClick();
            }


            // ce button
            if (e.KeyCode == Keys.Delete) { ceButton.PerformClick(); }

            // c button
            if (e.KeyCode == Keys.Escape) { cButton.PerformClick(); }

            // clear or rm button
            if (e.KeyCode == Keys.Back) { removeButton.PerformClick(); }

            // +/- mode
            if (e.KeyCode == Keys.F9) { signChangeButton.PerformClick(); }

            // 1/x mode 
            if (e.KeyCode == Keys.R) { oneByXButton.PerformClick(); }

            // sqrt mode -- key : @
            // Note: it is implemented in Form1_KeyPress method

            // sqr mode -- key : Q
            if (e.KeyCode == Keys.Q) { xSquareButton.PerformClick(); }


            // NUMBERS OR DIGITS
            // 0
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0) { zeroButton.PerformClick(); }

            // 1
            if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1) { oneButton.PerformClick(); }


            // 2
            // if (e.KeyCode == Keys.NumPad2 || || e.KeyCode == Keys.D2) { twoButton.PerformClick(); }   // adding extra number (2)
            if (e.KeyCode == Keys.NumPad2) { twoButton.PerformClick(); }

            // 3
            if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3) { threeButton.PerformClick(); }

            // 4
            if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4) { fourButton.PerformClick(); }

            // 5
            // if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5) { fiveButton.PerformClick(); }  // adding extra number (5)
            if (e.KeyCode == Keys.NumPad5) { fiveButton.PerformClick(); }

            // 6
            if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6) { sixButton.PerformClick(); }

            // 7
            if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7) { sevenButton.PerformClick(); }

            // 8
            // if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8) { eightButton.PerformClick(); } // adding extra key (8)
            if (e.KeyCode == Keys.NumPad8) { eightButton.PerformClick(); }

            // 9 
            if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9) { nineButton.PerformClick(); }



        }



        private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void inputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // don't allow any key to enter in inputTextBox
            e.Handled = true;


            // Note: below code allows numbers and '.' to enter in inputTextBox 
            // if ((e.KeyChar > (char)Keys.D9 || e.KeyChar < (char)Keys.D0) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            // {
            //     e.Handled = true;
            // }
            // //Edit: Alternative
            // if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            // {
            //     e.Handled = true;
            // }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // %
            if (e.KeyChar == '%')
            {
                // modulo
                moduloButton.PerformClick();
            }
            // @  -- sqrt 
            if (e.KeyChar == '@')
            {
                xSquareRootButton.PerformClick();
            }


            if (e.KeyChar == '+')
            {
                plusButton.PerformClick();
            }

            if (e.KeyChar == '-')
            {
                minusButton.PerformClick();
            }

            if (e.KeyChar == '*')
            {
                multiplyButton.PerformClick();
            }

            if (e.KeyChar == '/')
            {
                divideButton.PerformClick();
            }

            if (e.KeyChar == '.')
            {
                dotButton.PerformClick();
            }

            if (e.KeyChar == '=')
            {
                equalButton.PerformClick();
            }
        }
    }
}