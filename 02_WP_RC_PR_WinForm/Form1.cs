using System.Collections;

namespace _02_WP_RC_PR_WinForm
{
    public partial class Form1 : Form
    {
        private int[] firstLabelPlanePoint = { 61, 425 };
        private int[] secondLabelPlanePoint = { 56, 460 };
        private int[] firstValuePlanePoint = { 165, 425 };
        private int[] secondValuePlanePoint = { 165, 460 };

        private string modeOne = "Min";
        private string modeTwo = "Max";
        private string modeThree = "Both";

        ArrayList inputNumbers = new ArrayList();

        double maxNumber = 0;
        double minNumber = 0;

        public Form1()
        {
            InitializeComponent();

            // 0 1 2 - min max both
            modeMenuComboBox.SelectedIndex = 2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // reset input array
            inputNumbers.Clear();

            // reset minNumber
            minNumber = 0;

            // reset maxNumber
            maxNumber = 0;

            // reset inputTextBox
            inputTextBox.Text = "";

            // reset visbility for, calculation labe, min & max label and value
            // resetVisibility();

            // reset maxvalue
            maxValue.Text = "0";

            // reset minvalue
            minValue.Text = "0";

        }

        private void resetVisibility()
        {
            // reset visibility for calculation label
            calculationLabel.Visible = false;

            // reset visibility for minlabel
            minLabel.Visible = false;

            // reset visibility for minvalue
            minValue.Visible = false;

            // reset visibility for max label
            maxLabel.Visible = false;

            // reset visibility for max value
            maxValue.Visible = false;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void modeMenuComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // change modeHeading
            int x, y;

            resetVisibility();

            if (modeMenuComboBox.SelectedIndex == 0)
            {
                // min mode 
                // min label setting
                x = firstLabelPlanePoint[0];
                y = firstLabelPlanePoint[1];

                minLabel.Location = new Point(x, y);

                // min value setting
                x = firstValuePlanePoint[0];
                y = firstValuePlanePoint[1];

                minValue.Location = new Point(x, y);

                // set modeHeading
                modeHeadingLabel.Text = "Minimum calculator";

            }
            if (modeMenuComboBox.SelectedIndex == 1)
            {
                // max mode
                // max label setting
                x = firstLabelPlanePoint[0];
                y = firstLabelPlanePoint[1];

                maxLabel.Location = new Point(x, y);

                // max value setting
                x = firstValuePlanePoint[0];
                y = firstValuePlanePoint[1];

                maxValue.Location = new Point(x, y);

                // set modeHeading
                modeHeadingLabel.Text = "Maximum calculator";
            }
            if (modeMenuComboBox.SelectedIndex == 2)
            {
                // both (min & max) mode
                // min label setting
                x = firstLabelPlanePoint[0];
                y = firstLabelPlanePoint[1];

                minLabel.Location = new Point(x, y);

                // min value setting
                x = firstValuePlanePoint[0];
                y = firstValuePlanePoint[1];

                minValue.Location = new Point(x, y);

                // max label setting
                x = secondLabelPlanePoint[0];
                y = secondLabelPlanePoint[1];

                maxLabel.Location = new Point(x, y);

                // max value setting
                x = secondValuePlanePoint[0];
                y = secondValuePlanePoint[1];

                maxValue.Location = new Point(x, y);

                // set modeHeading
                modeHeadingLabel.Text = "Min and Max calculator";
            }

        }

        private string cleanInput()
        {
            string numberlist = string.Empty;

            // copy input number list 
            numberlist = inputTextBox.Text;

            numberlist = numberlist.Trim();

            // remove head and trail commas if avail
            numberlist = numberlist.Trim(',');

            // remove head and trail spaces
            numberlist = numberlist.Trim();

            return numberlist;
        }

        private bool storeInput(string numberlist)
        {
            // store each element from numberlist to array list inputNumbers
            if (numberlist.Length > 0)
            {
                if (numberlist.Contains(','))
                {
                    // comma separated input number list
                    foreach (string num in numberlist.Split(','))
                    {
                        inputNumbers.Add(Convert.ToDouble(num));
                    }
                }
                else if (numberlist.Contains(' '))
                {
                    // space separated input number list
                    foreach (string num in numberlist.Split(' '))
                    {
                        inputNumbers.Add(Convert.ToDouble(num));
                    }
                }
                else
                {
                    foreach (string num in numberlist.Split(' '))
                    {
                        inputNumbers.Add(Convert.ToDouble(num));
                    }
                }
                return true;
            }
            else
            {
                return false;
            }

        }

        private void calculateResult()
        {
            inputNumbers.Sort();

            minNumber = Convert.ToDouble(inputNumbers[0]);
            maxNumber = Convert.ToDouble(inputNumbers[inputNumbers.Count - 1]);

            // set min value
            minValue.Text = minNumber.ToString();

            // set max value
            maxValue.Text = maxNumber.ToString();
        }

        private void setVisibility()
        {
            // visible calculate lable
            calculationLabel.Visible = true;


            if (modeMenuComboBox.SelectedIndex == 0)
            {
                // for min - 0
                // visible min label
                minLabel.Visible = true;

                // visible min value
                minValue.Visible = true;
            }
            if (modeMenuComboBox.SelectedIndex == 1)
            {
                // for max - 1
                // visible max label
                maxLabel.Visible = true;

                // visible max value
                maxValue.Visible = true;
            }
            if (modeMenuComboBox.SelectedIndex == 2)
            {
                // for both - 2

                // visible min label
                minLabel.Visible = true;

                // visible min value
                minValue.Visible = true;

                // // visible max label
                maxLabel.Visible = true;

                // visible max value
                maxValue.Visible = true;
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Length > 0)
            {
                // clear inputNumbers array
                inputNumbers.Clear();

                // clean input number list
                string numberlist = cleanInput();

                // store it in string
                storeInput(numberlist);

                // calculate result
                calculateResult();

                // set visibility
                setVisibility();
            }

        }



        private void inputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows only digits, dot(period), space, comma, backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {



        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Modifiers == Keys.Control)
            {
                calculateButton.PerformClick();
            }
        }

        private void maxValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}