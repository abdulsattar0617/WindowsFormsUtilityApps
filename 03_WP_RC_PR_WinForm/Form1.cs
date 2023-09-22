namespace _03_WP_RC_PR_WinForm
{
    public partial class Form1 : Form
    {

        private int[,] formLabelPlanePoint = { { 54, 353 } ,    // first label point
                                                { 54, 387 },    // second label point

                                                { 54, 422 },    // third label point
                                                { 54, 457}     // fourth label point
                                               };

        private long numberOperand = 1;

        public Form1()
        {
            InitializeComponent();

            modeMenuComboBox.SelectedIndex = 0;
        }

        private void numberLabel_Click(object sender, EventArgs e)
        {

        }

        private void bottomLineLabel_Click(object sender, EventArgs e)
        {

        }

        private void modeMenuComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // set location for all labels
            int x, y;

            // reset visibility
            resetVisibility();

            // 0 1 2 3 4
            if (modeMenuComboBox.SelectedIndex == 0)
            {
                // 0 ---> All
                // set evenOdd label location
                x = formLabelPlanePoint[0, 0];
                y = formLabelPlanePoint[0, 1];

                evenOddLabel.Location = new Point(x, y);

                // set arms label location
                x = formLabelPlanePoint[1, 0];
                y = formLabelPlanePoint[1, 1];

                armsLabel.Location = new Point(x, y);

                // set prime Composite label loation
                x = formLabelPlanePoint[2, 0];
                y = formLabelPlanePoint[2, 1];

                primeCompLabel.Location = new Point(x, y);

                // set number factorial label location
                x = formLabelPlanePoint[3, 0];
                y = formLabelPlanePoint[3, 1];

                numFactorialLabel.Location = new Point(x, y);

            }
            else if (modeMenuComboBox.SelectedIndex == 1)
            {
                // 1 ----> Even or Odd
                // set evenOdd label location on top
                x = formLabelPlanePoint[0, 0];
                y = formLabelPlanePoint[0, 1];

                evenOddLabel.Location = new Point(x, y);
            }
            else if (modeMenuComboBox.SelectedIndex == 2)
            {
                // 2  ---> Armstrong or not
                x = formLabelPlanePoint[0, 0];
                y = formLabelPlanePoint[0, 1];

                armsLabel.Location = new Point(x, y);
            }
            else if (modeMenuComboBox.SelectedIndex == 3)
            {
                // 3 ---> Prime or not 
                x = formLabelPlanePoint[0, 0];
                y = formLabelPlanePoint[0, 1];

                primeCompLabel.Location = new Point(x, y);
            }
            else if (modeMenuComboBox.SelectedIndex == 4)
            {
                // 4 ---> Factorial
                x = formLabelPlanePoint[0, 0];
                y = formLabelPlanePoint[0, 1];

                numFactorialLabel.Location = new Point(x, y);
            }


        }

        private void setEvenOdd()
        {
            string expFormat = string.Empty;
            if (numberOperand % 2 == 0)
            {
                expFormat = $"{numberOperand} is an even number";
            }
            else
            {
                expFormat = $"{numberOperand} is an odd number";
            }

            evenOddLabel.Text = expFormat;
        }

        private bool isArmstrong(long n)
        {
            long sum = 0, temp, r = 0;
            temp = n;

            while (temp > 0)
            {
                r = temp % 10;
                sum += (r * r * r);
                temp /= 10;
            }

            if (sum == n) { return true; }
            else { return false; }
        }

        private void setArmstrong()
        {
            // numberOperand is armstrong or not
            string expFormat = string.Empty;

            if (isArmstrong(numberOperand))
            {
                expFormat = $"{numberOperand} is an armstrong number";
            }
            else
            {
                expFormat = $"{numberOperand} is not an armstrong number";
            }

            armsLabel.Text = expFormat;
        }

        private bool isPrime(long n)
        {
            for (long i = 2; i < n; i++)
            {
                if (n % i == 0) { return false; }
            }

            return true;
        }

        private void setPrimeComp()
        {
            string expFormat = string.Empty;
            if (isPrime(numberOperand))
            {
                expFormat = $"{numberOperand} is an prime number";
            }
            else
            {
                expFormat = $"{numberOperand} is an composite number";
            }

            primeCompLabel.Text = expFormat;
        }


        private long findFactorial(long n)
        {
            if (n == 0) { return 1; }
            if (n == 1 || n == 2)
            {
                return n;
            }
            else
            {
                return n * findFactorial(n - 1);
            }

        }

        private void setFactorial()
        {
            string expFormat = string.Empty;

            if (numberOperand > 0 && numberOperand <= 20)
            {
                // calculate factorial
                string nfact = findFactorial(numberOperand).ToString();

                expFormat = $"Factorial of {numberOperand} is {nfact}";

            }
            else if (numberOperand > 20)
            {
                expFormat = $"Factorial of {numberOperand} is too large";
            }
            else
            {
                expFormat = $"Factorial of {numberOperand} is not defined";
            }

            // update string factorial
            numFactorialLabel.Text = expFormat;
        }

        private void setResult()
        {

            // set even odd
            setEvenOdd();

            // set armstrong 
            setArmstrong();

            // set prime or not
            setPrimeComp();

            // set factorial
            setFactorial();
        }

        private void resetVisibility()
        {
            // disable even odd label
            evenOddLabel.Visible = false;

            // disable amrstrong label
            armsLabel.Visible = false;

            // disable prime composite label
            primeCompLabel.Visible = false;

            // disable factorial label
            numFactorialLabel.Visible = false;

            // disable analysis label 
            analysisHeadingLabel.Visible = false;
        }

        private void setVisibility()
        {
            // disable all 
            resetVisibility();

            // enable who required only
            // analysis label
            analysisHeadingLabel.Visible = true;

            // 0 1 2 3 4
            if (modeMenuComboBox.SelectedIndex == 0)
            {
                // 0 ---> all
                // visible even odd label
                evenOddLabel.Visible = true;

                // visible amrstrong label
                armsLabel.Visible = true;

                // visible prime composite label
                primeCompLabel.Visible = true;

                // visible factorial label
                numFactorialLabel.Visible = true;

            }
            else if (modeMenuComboBox.SelectedIndex == 1)
            {
                // 1 ---> even odd
                // visible even odd label
                evenOddLabel.Visible = true;


            }
            else if (modeMenuComboBox.SelectedIndex == 2)
            {
                // 2 ---> armstrong or not
                // visible armstrong label
                armsLabel.Visible = true;

            }
            else if (modeMenuComboBox.SelectedIndex == 3)
            {
                // 3 ---> prime or not
                // visible prime label
                primeCompLabel.Visible = true;
            }
            else if (modeMenuComboBox.SelectedIndex == 4)
            {
                // 4 ---> number factorial
                // visible factorial label
                numFactorialLabel.Visible = true;
            }
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (numberValue.Text.Length > 0)
            {
                // store number
                numberOperand = Convert.ToInt64(numberValue.Text.Trim());

                // set result
                setResult();

                // set visibility
                setVisibility();
            }
        }

        private void headingLabel_Click(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // reset visibility
            resetVisibility();

            // reset numberValue
            numberValue.Text = "";
        }

        private void numberValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void numberValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows only digits, backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}