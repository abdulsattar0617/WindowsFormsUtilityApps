using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_WP_RC_PR_WinForm
{
    public partial class FYDataEntryForm : Form
    {
        private string cgpaValuePlaceholder_Text = "Enter your first year CGPA";
        private string creditEarnedValuePlaceholder_Text = "Enter credit earned (/48)";
        private string totalMarksValuePlaceholder_Text = "Enter total marks (/1200)";
        private string gradePointValuePlaceholder_Text = "Enter grade points";
        private string earnedGradePointValuePlaceholdert_Text = "Enter earned grade points";
        public FYDataEntryForm()
        {
            InitializeComponent();
        }

        // validate first year data 
        public bool validateFirstYearFields()
        {
            // validate CGPA field
            if (cgpaValueTB.Text.Length == 0 || cgpaValueTB.Text == cgpaValuePlaceholder_Text) { return false; }
            // validate credit earned field
            if (creditEarnedValueTB.Text.Length == 0 || creditEarnedValueTB.Text == creditEarnedValuePlaceholder_Text) { return false; }
            // validate total marks field
            if (totalMarksValueTB.Text.Length == 0 || totalMarksValueTB.Text == totalMarksValuePlaceholder_Text) { return false; }
            // validate grade point field
            if (gradePointValueTB.Text.Length == 0 || gradePointValueTB.Text == gradePointValuePlaceholder_Text) { return false; }
            // validate earned grade point field
            if (earnedGradePointValueTB.Text.Length == 0 || earnedGradePointValueTB.Text == earnedGradePointValuePlaceholdert_Text) { return false; }

            return true;
        }
        // store first year data
        public void storeFirstYearInformation()
        {
            if (validateFirstYearFields())
            {
                // store first year cgpa
                Marksheet.Instance.firstYear.CGPA = Convert.ToDouble(cgpaValueTB.Text);

                // store credit earned
                Marksheet.Instance.firstYear.TOTAL_CREDIT_EARNED = Convert.ToByte(creditEarnedValueTB.Text);

                // store total marks
                Marksheet.Instance.firstYear.TOTAL_MARKS = Convert.ToInt16(totalMarksValueTB.Text);

                // store grade points
                Marksheet.Instance.firstYear.TOTAL_GRADE_POINT = Convert.ToByte(gradePointValueTB.Text);

                // store earned grade points
                Marksheet.Instance.firstYear.TOTAL_EARNED_GRADE_POINT = Convert.ToInt16(earnedGradePointValueTB.Text);

                // SET FIRST YEAR DATA SAVED FLAG 
                Marksheet.Instance.firstYear.YEAR_DATA_SAVED = true;

            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (validateFirstYearFields())
            {
                // store the first year data
                storeFirstYearInformation();

                // close the form
                this.Close();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // RESET ALL FIELDS
            // 1. CGPA
            cgpaValueTB.Text = string.Empty;

            // 2. CREDIT 
            creditEarnedValueTB.Text = string.Empty;

            // 3. TOTAL MARKS
            totalMarksValueTB.Text = string.Empty;

            // 4. GP
            gradePointValueTB.Text = string.Empty;

            // 5. EGP
            earnedGradePointValueTB.Text = string.Empty;
        }
    }
}
