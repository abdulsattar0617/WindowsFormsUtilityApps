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
    public partial class FY2DataEntryForm : Form
    {
        private string subMarksValuePlaceholder_Text = "Marks";
        private byte TH_SUB_CREDIT = 4;
        public FY2DataEntryForm()
        {
            InitializeComponent();
        }

        private void horizontalLineLabel_Click(object sender, EventArgs e)
        {

        }



        private void saveButton_Click(object sender, EventArgs e)
        {
            if (validateSemOneFields() && validateSemTwoFields())
            {
                calculateTotal();


                // close window
                this.Close();
            }
        }

        private bool validateSemOneFields()
        {
            // validate semester three marks fields
            // validate sem III CA marks 
            // subject marks
            if (semOneSubOneCAMarkTB.Text.Length == 0 || semOneSubOneCAMarkTB.Text == subMarksValuePlaceholder_Text) { return false; }
            if (semOneSubTwoCAMarkTB.Text.Length == 0 || semOneSubTwoCAMarkTB.Text == subMarksValuePlaceholder_Text) { return false; }
            if (semOneSubThreeCAMarkTB.Text.Length == 0 || semOneSubThreeCAMarkTB.Text == subMarksValuePlaceholder_Text) { return false; }
            if (semOneSubFourCAMarksTB.Text.Length == 0 || semOneSubFourCAMarksTB.Text == subMarksValuePlaceholder_Text) { return false; }
            if (semOneSubFiveCAMarksTB.Text.Length == 0 || semOneSubFiveCAMarksTB.Text == subMarksValuePlaceholder_Text) { return false; }

            // validate sem III ESE marks
            // subject marks
            if (semOneSubOneESEMarkTB.Text.Length == 0 || semOneSubOneESEMarkTB.Text == subMarksValuePlaceholder_Text) { return false; }
            if (semOneSubTwoESEMarkTB.Text.Length == 0 || semOneSubTwoESEMarkTB.Text == subMarksValuePlaceholder_Text) { return false; }
            if (semOneSubThreeESEMarkTB.Text.Length == 0 || semOneSubThreeESEMarkTB.Text == subMarksValuePlaceholder_Text) { return false; }
            if (semOneSubFourESEMarkTB.Text.Length == 0 || semOneSubFourESEMarkTB.Text == subMarksValuePlaceholder_Text) { return false; }

            // validate sem III practical marks
            // pracal subject  
            if (semOneLabOneSubMarksTB.Text.Length == 0 || semOneLabOneSubMarksTB.Text == subMarksValuePlaceholder_Text) { return false; }

            if (semOneLabTwoSubMarksTB.Text.Length == 0 || semOneLabTwoSubMarksTB.Text == subMarksValuePlaceholder_Text) { return false; }

            return true;
        }

        private bool validateSemTwoFields()
        {
            // validate semester four subject marks

            // validate sem IV CA Marks
            if (semTwoSubOneCAMarkTB.Text.Length == 0 || semTwoSubOneCAMarkTB.Text == subMarksValuePlaceholder_Text) { return false; }

            if (semTwoSubTwoCAMarkTB.Text.Length == 0 || semTwoSubTwoCAMarkTB.Text == subMarksValuePlaceholder_Text) { return false; }

            if (semTwoSubThreeCAMarkTB.Text.Length == 0 || semTwoSubThreeCAMarkTB.Text == subMarksValuePlaceholder_Text) { return false; }

            if (semTwoSubFourCAMarkTB.Text.Length == 0 || semTwoSubFourCAMarkTB.Text == subMarksValuePlaceholder_Text) { return false; }

            if (semTwoSubFiveCAMarkTB.Text.Length == 0 || semTwoSubFiveCAMarkTB.Text == subMarksValuePlaceholder_Text) { return false; }


            // validate sem IV ESE Marks
            // subject marks
            if (semTwoSubOneESEMarkTB.Text.Length == 0 || semTwoSubOneESEMarkTB.Text == subMarksValuePlaceholder_Text) { return false; }

            if (semTwoSubTwoESEMarkTB.Text.Length == 0 || semTwoSubTwoESEMarkTB.Text == subMarksValuePlaceholder_Text) { return false; }

            if (semTwoSubThreeESEMarkTB.Text.Length == 0 || semTwoSubThreeESEMarkTB.Text == subMarksValuePlaceholder_Text) { return false; }

            if (semTwoSubFourESEMarkTB.Text.Length == 0 || semTwoSubFourESEMarkTB.Text == subMarksValuePlaceholder_Text) { return false; }


            // validate sem IV Pratical Marks
            // practical subject  
            if (semTwoLabOneSubMarksTB.Text.Length == 0 || semTwoLabOneSubMarksTB.Text == subMarksValuePlaceholder_Text) { return false; }

            if (semTwoLabTwoSubMarksTB.Text.Length == 0 || semTwoLabTwoSubMarksTB.Text == subMarksValuePlaceholder_Text) { return false; }

            return true;
        }

        private byte calc_SubjectCredit(byte marks)
        {
            if (marks > 40)
            {
                return TH_SUB_CREDIT;
            }
            else
            {
                return 0;
            }
        }

        private void updateResult(byte marks, byte credit, byte gp, short egp)
        {
            Marksheet.Instance.firstYear.TOTAL_MARKS += marks;
            Marksheet.Instance.firstYear.TOTAL_CREDIT_EARNED += credit;
            Marksheet.Instance.firstYear.TOTAL_GRADE_POINT += gp;
            Marksheet.Instance.firstYear.TOTAL_EARNED_GRADE_POINT += egp;
        }

        private void calculateTotal()
        {
            // reset year data
            Marksheet.Instance.firstYear.resetYear();

            byte credit = 0;
            byte marks = 0;
            byte gradePoint = 0;
            short earnedGradePoint = 0;


            // Sem I
            // TH 1
            marks = Convert.ToByte(Convert.ToByte(semOneSubOneCAMarkTB.Text.Trim()) + Convert.ToByte(semOneSubOneESEMarkTB.Text.Trim()));
            credit = calc_SubjectCredit(marks);
            gradePoint = Marksheet.Instance.secondYear.firstSemester.findGradePoint(marks, 0);

            // EGP = GP * Credit Earned
            earnedGradePoint = Convert.ToInt16(gradePoint * credit);

            // ADD result 
            updateResult(marks, credit, gradePoint, earnedGradePoint);

            // TH 2
            marks = Convert.ToByte(Convert.ToByte(semOneSubTwoCAMarkTB.Text.Trim()) + Convert.ToByte(semOneSubTwoESEMarkTB.Text.Trim()));
            credit = calc_SubjectCredit(marks);
            gradePoint = Marksheet.Instance.secondYear.firstSemester.findGradePoint(marks, 1);

            // EGP = GP * Credit Earned
            earnedGradePoint = Convert.ToInt16(gradePoint * credit);

            // ADD result 
            updateResult(marks, credit, gradePoint, earnedGradePoint);

            // TH 3
            marks = Convert.ToByte(Convert.ToByte(semOneSubThreeCAMarkTB.Text.Trim()) + Convert.ToByte(semOneSubThreeESEMarkTB.Text.Trim()));
            credit = calc_SubjectCredit(marks);
            gradePoint = Marksheet.Instance.secondYear.firstSemester.findGradePoint(marks, 2);

            // EGP = GP * Credit Earned
            earnedGradePoint = Convert.ToInt16(gradePoint * credit);

            // ADD result 
            updateResult(marks, credit, gradePoint, earnedGradePoint);

            // TH 4
            marks = Convert.ToByte(Convert.ToByte(semOneSubFourCAMarksTB.Text.Trim()) + Convert.ToByte(semOneSubFourESEMarkTB.Text.Trim()));
            credit = calc_SubjectCredit(marks);
            gradePoint = Marksheet.Instance.secondYear.firstSemester.findGradePoint(marks, 3);

            // EGP = GP * Credit Earned
            earnedGradePoint = Convert.ToInt16(gradePoint * credit);

            // ADD result 
            updateResult(marks, credit, gradePoint, earnedGradePoint);


            // TH 5 
            marks = Convert.ToByte(semOneSubFiveCAMarksTB.Text.Trim());
            credit = calc_SubjectCredit(marks);
            gradePoint = Marksheet.Instance.secondYear.firstSemester.findGradePoint(marks, 4);

            // EGP = GP * Credit Earned
            earnedGradePoint = Convert.ToInt16(gradePoint * credit);

            // ADD result 
            updateResult(marks, credit, gradePoint, earnedGradePoint);

            // PR 1 
            marks = Convert.ToByte(semOneLabOneSubMarksTB.Text.Trim());
            credit = calc_SubjectCredit(marks);
            gradePoint = Marksheet.Instance.secondYear.firstSemester.findGradePoint(marks, 5);

            // EGP = GP * Credit Earned
            earnedGradePoint = Convert.ToInt16(gradePoint * credit);

            // ADD result 
            updateResult(marks, credit, gradePoint, earnedGradePoint);

            // PR 2
            marks = Convert.ToByte(semOneLabTwoSubMarksTB.Text.Trim());
            credit = calc_SubjectCredit(marks);
            gradePoint = Marksheet.Instance.secondYear.firstSemester.findGradePoint(marks, 6);

            // EGP = GP * Credit Earned
            earnedGradePoint = Convert.ToInt16(gradePoint * credit);

            // ADD result 
            updateResult(marks, credit, gradePoint, earnedGradePoint);


            // SEM II
            // TH 1
            marks = Convert.ToByte(Convert.ToByte(semTwoSubOneCAMarkTB.Text.Trim()) + Convert.ToByte(semTwoSubOneESEMarkTB.Text.Trim()));
            credit = calc_SubjectCredit(marks);
            gradePoint = Marksheet.Instance.secondYear.firstSemester.findGradePoint(marks, 0);

            // EGP = GP * Credit Earned
            earnedGradePoint = Convert.ToInt16(gradePoint * credit);

            // ADD result 
            updateResult(marks, credit, gradePoint, earnedGradePoint);

            // TH 2
            marks = Convert.ToByte(Convert.ToByte(semTwoSubTwoCAMarkTB.Text.Trim()) + Convert.ToByte(semTwoSubTwoESEMarkTB.Text.Trim()));
            credit = calc_SubjectCredit(marks);
            gradePoint = Marksheet.Instance.secondYear.firstSemester.findGradePoint(marks, 1);

            // EGP = GP * Credit Earned
            earnedGradePoint = Convert.ToInt16(gradePoint * credit);

            // ADD result 
            updateResult(marks, credit, gradePoint, earnedGradePoint);

            // TH 3
            marks = Convert.ToByte(Convert.ToByte(semTwoSubThreeCAMarkTB.Text.Trim()) + Convert.ToByte(semTwoSubThreeESEMarkTB.Text.Trim()));
            credit = calc_SubjectCredit(marks);
            gradePoint = Marksheet.Instance.secondYear.firstSemester.findGradePoint(marks, 2);

            // EGP = GP * Credit Earned
            earnedGradePoint = Convert.ToInt16(gradePoint * credit);

            // ADD result 
            updateResult(marks, credit, gradePoint, earnedGradePoint);


            // TH 4
            marks = Convert.ToByte(Convert.ToByte(semTwoSubFourCAMarkTB.Text.Trim()) + Convert.ToByte(semTwoSubFourESEMarkTB.Text.Trim()));
            credit = calc_SubjectCredit(marks);
            gradePoint = Marksheet.Instance.secondYear.firstSemester.findGradePoint(marks, 3);

            // EGP = GP * Credit Earned
            earnedGradePoint = Convert.ToInt16(gradePoint * credit);

            // ADD result 
            updateResult(marks, credit, gradePoint, earnedGradePoint);

            // TH 5
            marks = Convert.ToByte(semTwoSubFiveCAMarkTB.Text.Trim());
            credit = calc_SubjectCredit(marks);
            gradePoint = Marksheet.Instance.secondYear.firstSemester.findGradePoint(marks, 4);

            // EGP = GP * Credit Earned
            earnedGradePoint = Convert.ToInt16(gradePoint * credit);

            // ADD result 
            updateResult(marks, credit, gradePoint, earnedGradePoint);

            // PR 1 
            marks = Convert.ToByte(semTwoLabOneSubMarksTB.Text.Trim());
            credit = calc_SubjectCredit(marks);
            gradePoint = Marksheet.Instance.secondYear.firstSemester.findGradePoint(marks, 5);

            // EGP = GP * Credit Earned
            earnedGradePoint = Convert.ToInt16(gradePoint * credit);

            // ADD result 
            updateResult(marks, credit, gradePoint, earnedGradePoint);

            // PR 2 
            marks = Convert.ToByte(semTwoLabTwoSubMarksTB.Text.Trim());
            credit = calc_SubjectCredit(marks);
            gradePoint = Marksheet.Instance.secondYear.firstSemester.findGradePoint(marks, 6);

            // EGP = GP * Credit Earned
            earnedGradePoint = Convert.ToInt16(gradePoint * credit);

            // ADD result 
            updateResult(marks, credit, gradePoint, earnedGradePoint);


            // CGPA CALCULATION
            calculateCGPA();
        }

        private void calculateCGPA()
        {
            // CGPA = Earned Grade Point / Earned Credit Points   (rounded upto 2 decimal places)
            Marksheet.Instance.firstYear.CGPA = Math.Round((double)Marksheet.Instance.firstYear.TOTAL_EARNED_GRADE_POINT / Marksheet.Instance.firstYear.TOTAL_CREDIT_EARNED, 2);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // RESET ALL FIELDS
            // SEM-I
            // CA MARKS
            semOneSubOneCAMarkTB.Text = string.Empty;
            semOneSubTwoCAMarkTB.Text = string.Empty;
            semOneSubThreeCAMarkTB.Text = string.Empty;
            semOneSubFourCAMarksTB.Text = string.Empty;
            semOneSubFiveCAMarksTB.Text = string.Empty;

            // ESE MARKS
            semOneSubOneESEMarkTB.Text = string.Empty;
            semOneSubTwoESEMarkTB.Text = string.Empty;
            semOneSubThreeESEMarkTB.Text = string.Empty;
            semOneSubFourESEMarkTB.Text = string.Empty;

            // PR MARKS
            semOneLabOneSubMarksTB.Text = string.Empty;
            semOneLabTwoSubMarksTB.Text = string.Empty;

            // SEM-II 
            // CA MARKS
            semTwoSubOneCAMarkTB.Text = string.Empty;
            semTwoSubTwoCAMarkTB.Text = string.Empty;
            semTwoSubThreeCAMarkTB.Text = string.Empty;
            semTwoSubFourCAMarkTB.Text = string.Empty;
            semTwoSubFiveCAMarkTB.Text = string.Empty;

            // ESE MARKS
            semTwoSubOneESEMarkTB.Text = string.Empty;
            semTwoSubTwoESEMarkTB.Text = string.Empty;
            semTwoSubThreeESEMarkTB.Text = string.Empty;
            semTwoSubFourESEMarkTB.Text = string.Empty;

            // PR MARKS
            semTwoLabOneSubMarksTB.Text = string.Empty;
            semTwoLabTwoSubMarksTB.Text = string.Empty;
        }
    }
}
