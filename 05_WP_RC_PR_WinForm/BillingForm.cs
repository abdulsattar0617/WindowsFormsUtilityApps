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
    public partial class BillingForm : Form
    {
        public BillingForm()
        {
            InitializeComponent();



        }


        private void loadFields()
        {
            // 1. FIXED CHARGES
            fixedChargesValue.Text = Bill.Instance.billing.FixedCharges.ToString();

            // 2. ENERGY CHARGES
            energyChargesValue.Text = Bill.Instance.billing.EnergyCharges.ToString();

            // 3. WHEELING CHARGES
            wheelingChargesValue.Text = Bill.Instance.billing.WheelingCharges.ToString();

            // 4. F.A.C CHARGES
            facChargesValue.Text = Bill.Instance.billing.FAC_Charges.ToString();

            // 5. ELECTRICITY DUTY
            electricityDutyValue.Text = Bill.Instance.billing.ElectricityDuty.ToString();

            // 6. TAX ON SALE
            taxOnSaleValue.Text = Bill.Instance.billing.Tax_On_Scale.ToString();

            // 7. PREVIOUS BILL CREDIT
            previousBillCreditValue.Text = "00.00";

            // 8. CURRENT INTEREST
            currentInterestValue.Text = Bill.Instance.billing.CurrentInterest.ToString();

            // 9. OTHER CHARGES
            otherChargesValue.Text = "00.00";

            // 10. TOTAL BILL
            totalBillValue.Text = Bill.Instance.billing.TotalBill.ToString();

            // 11. DUE DATE
            dueDateValue.Text = Bill.Instance.BILL_DUE_DATE;

            // 12. BILL + DUE CHARGE
            payValue.Text = (Bill.Instance.billing.TotalBill + Bill.Instance.DUE_CHARGES).ToString();
        }

        private void BillingForm_Load(object sender, EventArgs e)
        {
            // TODO - load all fields
            loadFields();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
