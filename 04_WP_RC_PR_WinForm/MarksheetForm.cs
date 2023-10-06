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
    public partial class MarksheetForm : Form
    {
        public MarksheetForm()
        {
            InitializeComponent();
        }

        private void loadBasicInformation()
        {
            // 1. name
            nameValueTB.Text = Marksheet.Instance.student.Name;

            // 2. seat no
            seatNoValueTB.Text = Marksheet.Instance.student.SeatNo;

            // 3. prn no
            prnNoValueTB.Text = Marksheet.Instance.student.PrnNo;

            // 4. abc id 
            abcIdValueTB.Text = Marksheet.Instance.student.AbcId;

            // make all fields read only
            nameValueTB.ReadOnly = true;
            seatNoValueTB.ReadOnly = true;
            prnNoValueTB.ReadOnly = true;
            abcIdValueTB.ReadOnly = true;

        }

        private void loadSemesterOne()
        {
            // 1. load all subjects CREDITS
            // laod Theory subject credit
            semThreeSubOneCreditValue.Text = Marksheet.Instance.secondYear.firstSemester.TH_SUB_CREDIT_EARNED[0].ToString();
            semThreeSubTwoCreditValue.Text = Marksheet.Instance.secondYear.firstSemester.TH_SUB_CREDIT_EARNED[1].ToString();
            semThreeSubThreeCreditValue.Text = Marksheet.Instance.secondYear.firstSemester.TH_SUB_CREDIT_EARNED[2].ToString();
            semThreeSubFourCreditValue.Text = Marksheet.Instance.secondYear.firstSemester.TH_SUB_CREDIT_EARNED[3].ToString();
            semThreeSubFiveCreditValue.Text = Marksheet.Instance.secondYear.firstSemester.TH_SUB_CREDIT_EARNED[4].ToString();

            // load practical subject credit
            semThreePrSubOneCreditValue.Text = Marksheet.Instance.secondYear.firstSemester.PR_SUB_CREDIT_EARNED[0].ToString();
            semThreePrSubTwoCreditValue.Text = Marksheet.Instance.secondYear.firstSemester.PR_SUB_CREDIT_EARNED[1].ToString();

            // 2. load subjects CA marks
            semThreeSubOneCAMarksValueTB.Text = Marksheet.Instance.secondYear.firstSemester.CA_SUB_OBTAINED_MARKS[0].ToString();
            semThreeSubTwoCAMarksValueTB.Text = Marksheet.Instance.secondYear.firstSemester.CA_SUB_OBTAINED_MARKS[1].ToString();
            semThreeSubThreeCAMarksValueTB.Text = Marksheet.Instance.secondYear.firstSemester.CA_SUB_OBTAINED_MARKS[2].ToString();
            semThreeSubFourCAMarksValueTB.Text = Marksheet.Instance.secondYear.firstSemester.CA_SUB_OBTAINED_MARKS[3].ToString();
            semThreeSubFiveCAMarksValueTB.Text = Marksheet.Instance.secondYear.firstSemester.CA_SUB_OBTAINED_MARKS[4].ToString();

            // 3. load subjects ESE marks
            // load ESE Theory subjects
            semThreeSubOneESEMarksValueTB.Text = Marksheet.Instance.secondYear.firstSemester.ESE_TH_SUB_OBTAINED_MARKS[0].ToString();
            semThreeSubTwoESEMarksValueTB.Text = Marksheet.Instance.secondYear.firstSemester.ESE_TH_SUB_OBTAINED_MARKS[1].ToString();
            semThreeSubThreeESEMarksValueTB.Text = Marksheet.Instance.secondYear.firstSemester.ESE_TH_SUB_OBTAINED_MARKS[2].ToString();
            semThreeSubFourESEMarksValueTB.Text = Marksheet.Instance.secondYear.firstSemester.ESE_TH_SUB_OBTAINED_MARKS[3].ToString();

            // load ESE Practical subjects
            semThreePrSubOneMarksValueTB.Text = Marksheet.Instance.secondYear.firstSemester.ESE_PR_SUB_OBTAINED_MARKS[0].ToString();
            semThreePrSubTwoMarksValueTB.Text = Marksheet.Instance.secondYear.firstSemester.ESE_PR_SUB_OBTAINED_MARKS[1].ToString();

            // 4. load subject total marks TOT
            // looad theory subject total marks
            semThreeSubOneTotalMarksValue.Text = Marksheet.Instance.secondYear.firstSemester.SUB_TOTAL_OBTAINED_MARKS[0].ToString();
            semThreeSubTwoTotalMarksValue.Text = Marksheet.Instance.secondYear.firstSemester.SUB_TOTAL_OBTAINED_MARKS[1].ToString();
            semThreeSubThreeTotalMarksValue.Text = Marksheet.Instance.secondYear.firstSemester.SUB_TOTAL_OBTAINED_MARKS[2].ToString();
            semThreeSubFourTotalMarksValue.Text = Marksheet.Instance.secondYear.firstSemester.SUB_TOTAL_OBTAINED_MARKS[3].ToString();
            semThreeSubFiveTotalMarksValue.Text = Marksheet.Instance.secondYear.firstSemester.SUB_TOTAL_OBTAINED_MARKS[4].ToString();

            // load  practical subject total marks
            semThreePrSubOneTotalMarksValue.Text = Marksheet.Instance.secondYear.firstSemester.SUB_TOTAL_OBTAINED_MARKS[5].ToString();
            semThreePrSubTwoTotalMarksValue.Text = Marksheet.Instance.secondYear.firstSemester.SUB_TOTAL_OBTAINED_MARKS[6].ToString();

            // 5. load subject GRADE
            // TH - Theroy subject grades
            semThreeSubOneGradeValue.Text = Marksheet.Instance.secondYear.firstSemester.SUB_OBTAINED_GRADE[0];
            semThreeSubTwoGradeValue.Text = Marksheet.Instance.secondYear.firstSemester.SUB_OBTAINED_GRADE[1];
            semThreeSubThreeGradeValue.Text = Marksheet.Instance.secondYear.firstSemester.SUB_OBTAINED_GRADE[2];
            semThreeSubFourGradeValue.Text = Marksheet.Instance.secondYear.firstSemester.SUB_OBTAINED_GRADE[3];
            semThreeSubFiveGradeValue.Text = Marksheet.Instance.secondYear.firstSemester.SUB_OBTAINED_GRADE[4];
            // PR - Practical Subjects grade
            semThreePrSubOneGradeValue.Text = Marksheet.Instance.secondYear.firstSemester.SUB_OBTAINED_GRADE[5];
            semThreePrSubTwoGradeValue.Text = Marksheet.Instance.secondYear.firstSemester.SUB_OBTAINED_GRADE[6];

            // 6. GP - Grade Point 
            // TH - Theory subject grade point
            semThreeSubOneGradePointValue.Text = Marksheet.Instance.secondYear.firstSemester.SUB_OBTAINED_GRADE_POINT[0].ToString();
            semThreeSubTwoGradePointValue.Text = Marksheet.Instance.secondYear.firstSemester.SUB_OBTAINED_GRADE_POINT[1].ToString();
            semThreeSubThreeGradePointValue.Text = Marksheet.Instance.secondYear.firstSemester.SUB_OBTAINED_GRADE_POINT[2].ToString();
            semThreeSubFourGradePointValue.Text = Marksheet.Instance.secondYear.firstSemester.SUB_OBTAINED_GRADE_POINT[3].ToString();
            semThreeSubFiveGradePointValue.Text = Marksheet.Instance.secondYear.firstSemester.SUB_OBTAINED_GRADE_POINT[4].ToString();
            // PR - Practical subject grade point
            semThreePrSubOneGradePointValue.Text = Marksheet.Instance.secondYear.firstSemester.SUB_OBTAINED_GRADE_POINT[5].ToString();
            semThreePrSubTwoGradePointValue.Text = Marksheet.Instance.secondYear.firstSemester.SUB_OBTAINED_GRADE_POINT[6].ToString();

            // 7. EGP - Earned Grade Point
            // TH - Theory subject earned grade point
            semThreeSubOneEarnedGPValue.Text = Marksheet.Instance.secondYear.firstSemester.SUB_OBTAINED_EARNED_GRADE_POINT[0].ToString();
            semThreeSubTwoEarnedGPValue.Text = Marksheet.Instance.secondYear.firstSemester.SUB_OBTAINED_EARNED_GRADE_POINT[1].ToString();
            semThreeSubThreeEarnedGPValue.Text = Marksheet.Instance.secondYear.firstSemester.SUB_OBTAINED_EARNED_GRADE_POINT[2].ToString();
            semThreeSubFourEarnedGPValue.Text = Marksheet.Instance.secondYear.firstSemester.SUB_OBTAINED_EARNED_GRADE_POINT[3].ToString();
            semThreeSubFiveEarnedGPValue.Text = Marksheet.Instance.secondYear.firstSemester.SUB_OBTAINED_EARNED_GRADE_POINT[4].ToString();
            // PR - Practical subject earned grade point
            semThreePrSubOneEarnedGPValue.Text = Marksheet.Instance.secondYear.firstSemester.SUB_OBTAINED_EARNED_GRADE_POINT[5].ToString();
            semThreePrSubTwoEarnedGPValue.Text = Marksheet.Instance.secondYear.firstSemester.SUB_OBTAINED_EARNED_GRADE_POINT[6].ToString();
        }
        private void loadSemesterTwo()
        {
            // 1. CREDITS load
            // TH - Theory subject credits
            semFourSubOneCreditValue.Text = Marksheet.Instance.secondYear.secondSemester.TH_SUB_CREDIT_EARNED[0].ToString();
            semFourSubTwoCreditValue.Text = Marksheet.Instance.secondYear.secondSemester.TH_SUB_CREDIT_EARNED[1].ToString();
            semFourSubThreeCreditValue.Text = Marksheet.Instance.secondYear.secondSemester.TH_SUB_CREDIT_EARNED[2].ToString();
            semFourSubFourCreditValue.Text = Marksheet.Instance.secondYear.secondSemester.TH_SUB_CREDIT_EARNED[3].ToString();
            semFourSubFiveCreditValue.Text = Marksheet.Instance.secondYear.secondSemester.TH_SUB_CREDIT_EARNED[4].ToString();
            // PR - Practical subject credits
            semFourPrSubOneCreditValue.Text = Marksheet.Instance.secondYear.secondSemester.PR_SUB_CREDIT_EARNED[0].ToString();
            semFourPrSubTwoCreditValue.Text = Marksheet.Instance.secondYear.secondSemester.PR_SUB_CREDIT_EARNED[1].ToString();

            // 2. CA marks load
            semFourSubOneCAMarksValueTB.Text = Marksheet.Instance.secondYear.secondSemester.CA_SUB_OBTAINED_MARKS[0].ToString();
            semFourSubTwoCAMarksValueTB.Text = Marksheet.Instance.secondYear.secondSemester.CA_SUB_OBTAINED_MARKS[1].ToString();
            semFourSubThreeCAMarksValueTB.Text = Marksheet.Instance.secondYear.secondSemester.CA_SUB_OBTAINED_MARKS[2].ToString();
            semFourSubFourCAMarksValueTB.Text = Marksheet.Instance.secondYear.secondSemester.CA_SUB_OBTAINED_MARKS[3].ToString();
            semFourSubFiveCAMarksValueTB.Text = Marksheet.Instance.secondYear.secondSemester.CA_SUB_OBTAINED_MARKS[4].ToString();

            // 3. ESE marks load
            // TH - theory marks
            semFourSubOneESEMarksValueTB.Text = Marksheet.Instance.secondYear.secondSemester.ESE_TH_SUB_OBTAINED_MARKS[0].ToString();
            semFourSubTwoESEMarksValueTB.Text = Marksheet.Instance.secondYear.secondSemester.ESE_TH_SUB_OBTAINED_MARKS[1].ToString();
            semFourSubThreeESEMarksValueTB.Text = Marksheet.Instance.secondYear.secondSemester.ESE_TH_SUB_OBTAINED_MARKS[2].ToString();
            semFourSubFourESEMarksValueTB.Text = Marksheet.Instance.secondYear.secondSemester.ESE_TH_SUB_OBTAINED_MARKS[3].ToString();
            // PR - practical marks
            semFourPrSubOneMarksValueTB.Text = Marksheet.Instance.secondYear.secondSemester.ESE_PR_SUB_OBTAINED_MARKS[0].ToString();
            semFourPrSubTwoMarksValueTB.Text = Marksheet.Instance.secondYear.secondSemester.ESE_PR_SUB_OBTAINED_MARKS[1].ToString();

            // 4. TOT - subject total marks 
            // TH - Theory marks
            semFourSubOneTotalMarksValue.Text = Marksheet.Instance.secondYear.secondSemester.SUB_TOTAL_OBTAINED_MARKS[0].ToString();
            semFourSubTwoTotalMarksValue.Text = Marksheet.Instance.secondYear.secondSemester.SUB_TOTAL_OBTAINED_MARKS[1].ToString();
            semFourSubThreeTotalMarksValue.Text = Marksheet.Instance.secondYear.secondSemester.SUB_TOTAL_OBTAINED_MARKS[2].ToString();
            semFourSubFourTotalMarksValue.Text = Marksheet.Instance.secondYear.secondSemester.SUB_TOTAL_OBTAINED_MARKS[3].ToString();
            semFourSubFiveTotalMarksValue.Text = Marksheet.Instance.secondYear.secondSemester.SUB_TOTAL_OBTAINED_MARKS[4].ToString();
            // PR - practical marks
            semFourPrSubOneTotalMarksValue.Text = Marksheet.Instance.secondYear.secondSemester.SUB_TOTAL_OBTAINED_MARKS[5].ToString();
            semFourPrSubTwoTotalMarksValue.Text = Marksheet.Instance.secondYear.secondSemester.SUB_TOTAL_OBTAINED_MARKS[6].ToString();


            // 5. GRADE - load subject grade
            // TH - Theroy subject grades
            semFourSubOneGradeValue.Text = Marksheet.Instance.secondYear.secondSemester.SUB_OBTAINED_GRADE[0];
            semFourSubTwoGradeValue.Text = Marksheet.Instance.secondYear.secondSemester.SUB_OBTAINED_GRADE[1];
            semFourSubThreeGradeValue.Text = Marksheet.Instance.secondYear.secondSemester.SUB_OBTAINED_GRADE[2];
            semFourSubFourGradeValue.Text = Marksheet.Instance.secondYear.secondSemester.SUB_OBTAINED_GRADE[3];
            semFourSubFiveGradeValue.Text = Marksheet.Instance.secondYear.secondSemester.SUB_OBTAINED_GRADE[4];
            // PR - Practical Subjects grade
            semFourPrSubOneGradeValue.Text = Marksheet.Instance.secondYear.secondSemester.SUB_OBTAINED_GRADE[5];
            semFourPrSubTwoGradeValue.Text = Marksheet.Instance.secondYear.secondSemester.SUB_OBTAINED_GRADE[6];

            // 6. GP - Grade Point 
            // TH - Theory subject grade point
            semFourSubOneGradePointValue.Text = Marksheet.Instance.secondYear.secondSemester.SUB_OBTAINED_GRADE_POINT[0].ToString();
            semFourSubTwoGradePointValue.Text = Marksheet.Instance.secondYear.secondSemester.SUB_OBTAINED_GRADE_POINT[1].ToString();
            semFourSubThreeGradePointValue.Text = Marksheet.Instance.secondYear.secondSemester.SUB_OBTAINED_GRADE_POINT[2].ToString();
            semFourSubFourGradePointValue.Text = Marksheet.Instance.secondYear.secondSemester.SUB_OBTAINED_GRADE_POINT[3].ToString();
            semFourSubFiveGradePointValue.Text = Marksheet.Instance.secondYear.secondSemester.SUB_OBTAINED_GRADE_POINT[4].ToString();
            // PR - Practical subject grade point
            semFourPrSubOneGradePointValue.Text = Marksheet.Instance.secondYear.secondSemester.SUB_OBTAINED_GRADE_POINT[5].ToString();
            semFourPrSubTwoGradePointValue.Text = Marksheet.Instance.secondYear.secondSemester.SUB_OBTAINED_GRADE_POINT[6].ToString();

            // 7. EGP - Earned Grade Point
            // TH - Theory subject earned grade point
            semFourSubOneEarnedGPValue.Text = Marksheet.Instance.secondYear.secondSemester.SUB_OBTAINED_EARNED_GRADE_POINT[0].ToString();
            semFourSubTwoEarnedGPValue.Text = Marksheet.Instance.secondYear.secondSemester.SUB_OBTAINED_EARNED_GRADE_POINT[1].ToString();
            semFourSubThreeEarnedGPValue.Text = Marksheet.Instance.secondYear.secondSemester.SUB_OBTAINED_EARNED_GRADE_POINT[2].ToString();
            semFourSubFourEarnedGPValue.Text = Marksheet.Instance.secondYear.secondSemester.SUB_OBTAINED_EARNED_GRADE_POINT[3].ToString();
            semFourSubFiveEarnedGPValue.Text = Marksheet.Instance.secondYear.secondSemester.SUB_OBTAINED_EARNED_GRADE_POINT[4].ToString();
            // PR - Practical subject earned grade point
            semFourPrSubOneEarnedGPValue.Text = Marksheet.Instance.secondYear.secondSemester.SUB_OBTAINED_EARNED_GRADE_POINT[5].ToString();
            semFourPrSubTwoEarnedGPValue.Text = Marksheet.Instance.secondYear.secondSemester.SUB_OBTAINED_EARNED_GRADE_POINT[6].ToString();
        }

        private void loadYearResult()
        {
            // 1. CGPA load 
            cgpaValue.Text = Marksheet.Instance.secondYear.CGPA.ToString();

            // 2. CREDIT EARNED load 
            creditEarnedValue.Text = Marksheet.Instance.secondYear.TOTAL_CREDIT_EARNED.ToString();

            // 3. TOTAL MARKS load
            totalValue.Text = Marksheet.Instance.secondYear.TOTAL_MARKS.ToString();

            // 4. GP load
            GPValue.Text = Marksheet.Instance.secondYear.TOTAL_GRADE_POINT.ToString();

            // 5. EGP load
            EGPValue.Text = Marksheet.Instance.secondYear.TOTAL_EARNED_GRADE_POINT.ToString();

            // 6. RESULT load
            resultValue.Text = Marksheet.Instance.secondYear.RESULT;
        }
        private void loadFirstYearResult()
        {
            // 1. CGPA load 
            fYCgpaValue.Text = Marksheet.Instance.firstYear.CGPA.ToString();

            // 2. CREDIT EARNED load 
            fYCreditEarnedValue.Text = Marksheet.Instance.firstYear.TOTAL_CREDIT_EARNED.ToString();

            // 3. TOTAL MARKS load
            fYTotalValue.Text = Marksheet.Instance.firstYear.TOTAL_MARKS.ToString();

            // 4. GP load
            fyGPValue.Text = Marksheet.Instance.firstYear.TOTAL_GRADE_POINT.ToString();

            // 5. EGP load
            fyEGPValue.Text = Marksheet.Instance.firstYear.TOTAL_EARNED_GRADE_POINT.ToString();
        }
        private void MarksheetForm_Load(object sender, EventArgs e)
        {
            // load serial no 
            srNoValueTB.Text = Marksheet.Instance.serialNumber;
            srNoValueTB.ReadOnly = true;

            // load basic information
            loadBasicInformation();

            // load semester one
            loadSemesterOne();

            // load semester two 
            loadSemesterTwo();

            // load year result
            loadYearResult();

            // load first year result
            loadFirstYearResult();




            // load result issue date and mark memo issue date
        }

       
    }
}
