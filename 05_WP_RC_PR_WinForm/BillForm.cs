using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_WP_RC_PR_WinForm
{
    public partial class BillForm : Form
    {
        public BillForm()
        {
            InitializeComponent();

        }

        private void loadFields()
        {

            // 1. Bill of Supply For: Jul-2019
            billOfSupplyValue.Text = Bill.Instance.BILL_SUPPLY_DATE;


            // 2. HSN code 27160000

            // 3. BILL NO.(GGN):
            billNumberValue.Text = Bill.Instance.billNumber;

            // 4. Consumer No and Customer Name:
            // Customer number
            customerNumberValue.Text = Bill.Instance.customer.customerNumber;

            // Customer Name
            customerNameValue.Text = Bill.Instance.customer.Name;

            // Customer Address
            customerAddressValue.Text = Bill.Instance.customer.Address;

            // 5. Bill Date:
            billDateValue.Text = Bill.Instance.BILL_DATE;

            // 6. Bill Amount Rs:
            billAmountValue.Text = Bill.Instance.billing.TotalBill.ToString();

            // 7. Due Date:
            billDueDateValue.Text = Bill.Instance.BILL_DUE_DATE;

            // 8. pay With Due
            payWithDueValue.Text = (Bill.Instance.billing.TotalBill + Bill.Instance.DUE_CHARGES).ToString();

            // 9. Mobile/Email:
            phoneNEmailValue.Text = Bill.Instance.customer.PhoneNumber + " / " + Bill.Instance.customer.Email;

            // 10. Billing Unit:
            billingUnitValue.Text = Bill.Instance.Billing_Unit;

            // 11. Tariff/Category:
            categoryValue.Text = Bill.Instance.CATEGORY;


            // 12. Pole No:
            poleNumberValue.Text = Bill.Instance.POLL_NUMBER;


            // 13. Security Deposit(Rs):
            securityDepositValue.Text = Bill.Instance.SECURITY_DEPOSIT.ToString();

            // 14. Sanct. Load:
            sanctLoadValue.Text = Bill.Instance.SANC_LOAD + " KW";

            // 15. Supply Date (Meter supply date):
            supplyDateValue.Text = Bill.Instance.METER_SUPPLY_DATE;

            // 16. Current Reading Date:
            currentReadingDateValue.Text = Bill.Instance.CURRENT_READING_DATE;

            // 17. Previous Reading Date:
            previousReadingDateValue.Text = Bill.Instance.PREVIOUS_READING_DATE;

            // 18. Current Reading
            currentReadingValue.Text = Bill.Instance.currentReading;

            // 19. Previous Reading
            previousReadingValue.Text = Bill.Instance.previousReading;


            // 20. Unit
            unitValue.Text = Bill.Instance.billing.ConsumedUnit.ToString();

            // 21. Adj. Unit
            // HARD WRITTEN AT PAGE

            // 22. Total
            totalValue.Text = Bill.Instance.billing.ConsumedUnit.ToString();

            // 23. Meter No:
            meterNumberValue.Text = Bill.Instance.METER_NUMBER;

            // 24. Meter Status:
            meterStatusValue.Text = Bill.Instance.METER_STATUS;

            // 25. Bill Period:
            billPeriodValue.Text = Bill.Instance.BILL_PERIOD + " Month(s) /";
        }

        private void BillForm_Load(object sender, EventArgs e)
        {
            // Load all fields
            loadFields();
        }


    }
}
