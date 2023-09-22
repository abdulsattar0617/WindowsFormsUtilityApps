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
    public partial class SYDataEntryForm : Form
    {
        private string subMarksValuePlaceholder_Text = "Marks";
        public SYDataEntryForm()
        {
            InitializeComponent();
        }

        private void SYDataEntryForm_Load(object sender, EventArgs e)
        {

        }

        private void semThreeSubFourCAMarksTB_TextChanged(object sender, EventArgs e)
        {
        }

        private void semThreeSubOneCAMarkTB_TextChanged(object sender, EventArgs e)
        {
        }

        private void semThreeSubThreeCAMarkTB_TextChanged(object sender, EventArgs e)
        {
        }

        private void semThreeSubTwoCAMarkTB_TextChanged(object sender, EventArgs e)
        {
        }

        private void semThreeSubFourCAMarkTB_TextChanged(object sender, EventArgs e)
        {
        }

        private bool validateSemThreeFields()
        {
            // validate semester three marks fields
            // validate sem III CA marks 
            // subject one marks
            if (semThreeSubOneCAMarkTB.Text.Length == 0 || semThreeSubOneCAMarkTB.Text == subMarksValuePlaceholder_Text) { return false; }
            // subject two marks
            if (semThreeSubTwoCAMarkTB.Text.Length == 0 || semThreeSubTwoCAMarkTB.Text == subMarksValuePlaceholder_Text) { return false; }
            // subject three marks
            if (semThreeSubThreeCAMarkTB.Text.Length == 0 || semThreeSubThreeCAMarkTB.Text == subMarksValuePlaceholder_Text) { return false; }
            // subject four marks
            if (semThreeSubFourCAMarksTB.Text.Length == 0 || semThreeSubFourCAMarksTB.Text == subMarksValuePlaceholder_Text) { return false; }
            // subject five marks
            if (semThreeSubFiveCAMarksTB.Text.Length == 0 || semThreeSubFiveCAMarksTB.Text == subMarksValuePlaceholder_Text) { return false; }

            // validate sem III ESE marks
            // subject one marks
            if (semThreeSubOneESEMarkTB.Text.Length == 0 || semThreeSubOneESEMarkTB.Text == subMarksValuePlaceholder_Text) { return false; }
            // subject two marks
            if (semThreeSubTwoESEMarkTB.Text.Length == 0 || semThreeSubTwoESEMarkTB.Text == subMarksValuePlaceholder_Text) { return false; }
            // subject three marks
            if (semThreeSubThreeESEMarkTB.Text.Length == 0 || semThreeSubThreeESEMarkTB.Text == subMarksValuePlaceholder_Text) { return false; }
            // subject four marks
            if (semThreeSubFourESEMarkTB.Text.Length == 0 || semThreeSubFourESEMarkTB.Text == subMarksValuePlaceholder_Text) { return false; }

            // validate sem III practical marks
            // practical subject one
            if (semThreeLabOneSubMarksTB.Text.Length == 0 || semThreeLabOneSubMarksTB.Text == subMarksValuePlaceholder_Text) { return false; }
            // practical subject two
            if (semThreeLabTwoSubMarksTB.Text.Length == 0 || semThreeLabTwoSubMarksTB.Text == subMarksValuePlaceholder_Text) { return false; }

            return true;
        }

        private bool validateSemFourFields()
        {
            // validate semester four subject marks

            // validate sem IV CA Marks
            if (semFourSubOneCAMarkTB.Text.Length == 0 || semFourSubOneCAMarkTB.Text == subMarksValuePlaceholder_Text) { return false; }
            // subject two marks
            if (semFourSubTwoCAMarkTB.Text.Length == 0 || semFourSubTwoCAMarkTB.Text == subMarksValuePlaceholder_Text) { return false; }
            // subject three marks
            if (semFourSubThreeCAMarkTB.Text.Length == 0 || semFourSubThreeCAMarkTB.Text == subMarksValuePlaceholder_Text) { return false; }
            // subject four marks
            if (semFourSubFourCAMarkTB.Text.Length == 0 || semFourSubFourCAMarkTB.Text == subMarksValuePlaceholder_Text) { return false; }
            // subject five marks
            if (semFourSubFiveCAMarkTB.Text.Length == 0 || semFourSubFiveCAMarkTB.Text == subMarksValuePlaceholder_Text) { return false; }


            // validate sem IV ESE Marks
            // subject one marks
            if (semFourSubOneESEMarkTB.Text.Length == 0 || semFourSubOneESEMarkTB.Text == subMarksValuePlaceholder_Text) { return false; }
            // subject two marks
            if (semFourSubTwoESEMarkTB.Text.Length == 0 || semFourSubTwoESEMarkTB.Text == subMarksValuePlaceholder_Text) { return false; }
            // subject three marks
            if (semFourSubThreeESEMarkTB.Text.Length == 0 || semFourSubThreeESEMarkTB.Text == subMarksValuePlaceholder_Text) { return false; }
            // subject four marks
            if (semFourSubFourESEMarkTB.Text.Length == 0 || semFourSubFourESEMarkTB.Text == subMarksValuePlaceholder_Text) { return false; }


            // validate sem IV Pratical Marks
            // practical subject one
            if (semFourLabOneSubMarksTB.Text.Length == 0 || semFourLabOneSubMarksTB.Text == subMarksValuePlaceholder_Text) { return false; }
            // practical subject two
            if (semFourLabTwoSubMarksTB.Text.Length == 0 || semFourLabTwoSubMarksTB.Text == subMarksValuePlaceholder_Text) { return false; }

            return true;
        }

        private void storeSemThreeInformation()
        {
            if (validateSemThreeFields())
            {
                // store CA Marks
                // store subject one
                Marksheet.Instance.secondYear.firstSemester.CA_SUB_OBTAINED_MARKS[0] = Convert.ToByte(semThreeSubOneCAMarkTB.Text);
                // store subject two
                Marksheet.Instance.secondYear.firstSemester.CA_SUB_OBTAINED_MARKS[1] = Convert.ToByte(semThreeSubTwoCAMarkTB.Text);
                // store subject three
                Marksheet.Instance.secondYear.firstSemester.CA_SUB_OBTAINED_MARKS[2] = Convert.ToByte(semThreeSubThreeCAMarkTB.Text);
                // store subject Four
                Marksheet.Instance.secondYear.firstSemester.CA_SUB_OBTAINED_MARKS[3] = Convert.ToByte(semThreeSubFourCAMarksTB.Text);
                // store subject Five
                Marksheet.Instance.secondYear.firstSemester.CA_SUB_OBTAINED_MARKS[4] = Convert.ToByte(semThreeSubFiveCAMarksTB.Text);

                // store ESE Marks
                Marksheet.Instance.secondYear.firstSemester.ESE_TH_SUB_OBTAINED_MARKS[0] = Convert.ToByte(semThreeSubOneESEMarkTB.Text);
                Marksheet.Instance.secondYear.firstSemester.ESE_TH_SUB_OBTAINED_MARKS[1] = Convert.ToByte(semThreeSubTwoESEMarkTB.Text);
                Marksheet.Instance.secondYear.firstSemester.ESE_TH_SUB_OBTAINED_MARKS[2] = Convert.ToByte(semThreeSubThreeESEMarkTB.Text);
                Marksheet.Instance.secondYear.firstSemester.ESE_TH_SUB_OBTAINED_MARKS[3] = Convert.ToByte(semThreeSubFourESEMarkTB.Text);

                // store practical marks
                Marksheet.Instance.secondYear.firstSemester.ESE_PR_SUB_OBTAINED_MARKS[0] = Convert.ToByte(semThreeLabOneSubMarksTB.Text);
                Marksheet.Instance.secondYear.firstSemester.ESE_PR_SUB_OBTAINED_MARKS[1] = Convert.ToByte(semThreeLabTwoSubMarksTB.Text);

                // SET SEMESTER DATA SAVED FLAG 
                Marksheet.Instance.secondYear.firstSemester.SEMESTER_DATA_SAVED = true;


                // NOTE: You can add a flag in the marksheet class and use it to indicate which part of data user entered or not. (think it)
            }
        }

        private void storeSemFourInformation()
        {
            if (validateSemFourFields())
            {

                // store CA Marks
                // store subject one
                Marksheet.Instance.secondYear.secondSemester.CA_SUB_OBTAINED_MARKS[0] = Convert.ToByte(semFourSubOneCAMarkTB.Text);
                // store subject two        
                Marksheet.Instance.secondYear.secondSemester.CA_SUB_OBTAINED_MARKS[1] = Convert.ToByte(semFourSubTwoCAMarkTB.Text);
                // store subject three      
                Marksheet.Instance.secondYear.secondSemester.CA_SUB_OBTAINED_MARKS[2] = Convert.ToByte(semFourSubThreeCAMarkTB.Text);
                // store subject Four       
                Marksheet.Instance.secondYear.secondSemester.CA_SUB_OBTAINED_MARKS[3] = Convert.ToByte(semFourSubFourCAMarkTB.Text);
                // store subject Five       
                Marksheet.Instance.secondYear.secondSemester.CA_SUB_OBTAINED_MARKS[4] = Convert.ToByte(semFourSubFiveCAMarkTB.Text);

                // store ESE Marks
                Marksheet.Instance.secondYear.secondSemester.ESE_TH_SUB_OBTAINED_MARKS[0] = Convert.ToByte(semFourSubOneESEMarkTB.Text);
                Marksheet.Instance.secondYear.secondSemester.ESE_TH_SUB_OBTAINED_MARKS[1] = Convert.ToByte(semFourSubTwoESEMarkTB.Text);
                Marksheet.Instance.secondYear.secondSemester.ESE_TH_SUB_OBTAINED_MARKS[2] = Convert.ToByte(semFourSubThreeESEMarkTB.Text);
                Marksheet.Instance.secondYear.secondSemester.ESE_TH_SUB_OBTAINED_MARKS[3] = Convert.ToByte(semFourSubFourESEMarkTB.Text);

                // store practical marks
                Marksheet.Instance.secondYear.secondSemester.ESE_PR_SUB_OBTAINED_MARKS[0] = Convert.ToByte(semFourLabOneSubMarksTB.Text);
                Marksheet.Instance.secondYear.secondSemester.ESE_PR_SUB_OBTAINED_MARKS[1] = Convert.ToByte(semFourLabTwoSubMarksTB.Text);

                // SET SEMESTER DATA SAVED FLAG
                Marksheet.Instance.secondYear.secondSemester.SEMESTER_DATA_SAVED = true;

                // NOTE: You can add a flag in the marksheet class and use it to indicate which part of data user entered or not. (think it)
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // validate all fields
            if (validateSemThreeFields() && validateSemFourFields())
            {
                // store second year marks data
                // store sem III marks 
                storeSemThreeInformation();

                // store sem IV marks
                storeSemFourInformation();

                // ENSURE THAT SEM III & SEM IV DATA SAVED  
                if (Marksheet.Instance.secondYear.firstSemester.SEMESTER_DATA_SAVED && Marksheet.Instance.secondYear.secondSemester.SEMESTER_DATA_SAVED)
                {
                    // MARK YEAR DATA SAVED FLAG TRUE
                    Marksheet.Instance.secondYear.YEAR_DATA_SAVED = true;
                }

                // close the form
                this.Close();
            }

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // RESET ALL FIELDS
            // SEM-III
            // CA MARKS
            semThreeSubOneCAMarkTB.Text = string.Empty;
            semThreeSubTwoCAMarkTB.Text = string.Empty;
            semThreeSubThreeCAMarkTB.Text = string.Empty;
            semThreeSubFourCAMarksTB.Text = string.Empty;
            semThreeSubFiveCAMarksTB.Text = string.Empty;

            // ESE MARKS
            semThreeSubOneESEMarkTB.Text = string.Empty;
            semThreeSubTwoESEMarkTB.Text = string.Empty;
            semThreeSubThreeESEMarkTB.Text = string.Empty;
            semThreeSubFourESEMarkTB.Text = string.Empty;

            // PR MARKS
            semThreeLabOneSubMarksTB.Text = string.Empty;
            semThreeLabTwoSubMarksTB.Text = string.Empty;

            // SEM-IV
            // CA MARKS
            semFourSubOneCAMarkTB.Text = string.Empty;
            semFourSubTwoCAMarkTB.Text = string.Empty;
            semFourSubThreeCAMarkTB.Text = string.Empty;
            semFourSubFourCAMarkTB.Text = string.Empty;
            semFourSubFiveCAMarkTB.Text = string.Empty;

            // ESE MARKS
            semFourSubOneESEMarkTB.Text = string.Empty;
            semFourSubTwoESEMarkTB.Text = string.Empty;
            semFourSubThreeESEMarkTB.Text = string.Empty;
            semFourSubFourESEMarkTB.Text = string.Empty;

            // PR MARKS
            semFourLabOneSubMarksTB.Text = string.Empty;
            semFourLabTwoSubMarksTB.Text = string.Empty;
        }
    }
}
