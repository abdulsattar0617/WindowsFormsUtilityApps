namespace _05_WP_RC_PR_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool validateFields()
        {
            if (nameValueTB.Text.Length == 0) { return false; }
            if (phoneNumberValueTB.Text.Length == 0) { return false; }
            if (emailValueTB.Text.Length == 0) { return false; }
            if (runningReadingValueTB.Text.Length == 0) { return false; }
            if (consumedUnitValueTB.Text.Length == 0) { return false; }
            if (addressValueTB.Text.Length == 0) { return false; }

            return true;
        }

        private void storeCustomerData()
        {
            if (validateFields())
            {
                // NAME 
                Bill.Instance.customer.Name = nameValueTB.Text.Trim().ToUpper();

                // ADDRESS 
                Bill.Instance.customer.Address = addressValueTB.Text.Trim().ToUpper();

                // PHONE NUMBER
                Bill.Instance.customer.PhoneNumber = phoneNumberValueTB.Text.Trim();

                // EMAIL 
                Bill.Instance.customer.Email = emailValueTB.Text.Trim();

                // RUNNING READING or CURRENT READING 
                Bill.Instance.currentReading = runningReadingValueTB.Text;

                // CONSUMED UNITS
                Bill.Instance.billing.ConsumedUnit = Convert.ToDouble(consumedUnitValueTB.Text.Trim());
            }
        }

        private void calculateBillButton_Click(object sender, EventArgs e)
        {
            if (validateFields())
            {
                // 1. Store Customer Data 
                storeCustomerData();

                // 2. calculate bill
                Bill.Instance.calculateBill();

                // STORE BILL IN FILE 
                Bill.Instance.saveBillInFile();

                // UPDATE PREVIOUS BILL
                loadPreviousBills();

                // VISIBLE BUTTONS
                toggleButtons(true);
            }
        }

        private void toggleButtons(bool visible = false)
        {
            if (visible)
            {
                // 1. Visible View Billing Button - TODO
                billingButton.Visible = true;

                // 2. Visible View Bill Button - TODO
                billButton.Visible = true;
            }
            else
            {
                billingButton.Visible = false;
                billButton.Visible = false;
            }
        }

        private void billButton_Click(object sender, EventArgs e)
        {
            BillForm CustomerBill = new BillForm();

            // Launch Bill Form
            CustomerBill.ShowDialog();
        }

        private void billingButton_Click(object sender, EventArgs e)
        {
            BillingForm CustomerBilling = new BillingForm();

            // Launch Billing Form
            CustomerBilling.ShowDialog();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // RESET FIELDS
            // 1. name
            nameValueTB.Text = string.Empty;

            // 2. phone number
            phoneNumberValueTB.Text = string.Empty;

            // 3. email
            emailValueTB.Text = string.Empty;

            // 4. running reading or current reading
            runningReadingValueTB.Text = string.Empty;

            // 5. consumed unit
            consumedUnitValueTB.Text = string.Empty;

            // 6. address
            addressValueTB.Text = string.Empty;
        }

        private void loadPreviousBills()
        {
            // clear all the list 
            previousBillCB.Items.Clear();

            // Read PREVOIUS BILL FILE
            Bill.Instance.readPreviousBillFile();

            foreach (string billNo in Bill.Instance.PreviousBillList)
            {
                if (billNo != "")
                {
                    previousBillCB.Items.Add(billNo);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // load PREVIOUS BILLS
            loadPreviousBills();
        }

        private void previousBillCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1. read selected file
            string fileName = previousBillCB.SelectedItem.ToString().Trim();

            Bill.Instance.readBillFile(fileName);

            // 2. visible buttons
            toggleButtons(true);
        }
    }
}