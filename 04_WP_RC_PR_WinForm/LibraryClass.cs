using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_WP_RC_PR_WinForm
{
    // interface for student
    public class StudentModel
    {
        public string Name { get; set; }
        public string PrnNo { get; set; }
        public string AbcId { get; set; }
        public string SeatNo { get; set; }

        // COLLEGE CODE
        public const byte COLLEGE_CODE = 201;

        // STUDENT DATA SAVED FLAG
        public bool STUDENT_DATA_SAVED = false; 

        // methods 
        // set METHODS

        public void set_StudentData(string name, string prnNo, string abcId, string seatNo)
        {
            this.Name = name;
            this.PrnNo = prnNo;
            this.AbcId = abcId;
            this.SeatNo = seatNo;
        }
    }

    public class SemesterModel
    {
        // theory subjects name
        public string thSubOne { get; set; }
        public string thSubTwo { get; set; }
        public string thSubThree { get; set; }
        public string elThSubFour { get; set; }
        public string oElThSubFive { get; set; }

        // practical subjects name
        public string prSubOne { get; set; }
        public string prSubTwo { get; set; }

        // CONSTANTS 
        // credits constants
        public const byte TH_SUB_CREDIT = 4;
        public const byte PR_SUB_CREDIT = 2;

        // earned credits
        public byte[] TH_SUB_CREDIT_EARNED = new byte[5];
        public byte[] PR_SUB_CREDIT_EARNED = new byte[2];

        // CA Constants
        /// <summary>
        /// Stores the minimum marks in CA section for theory subjects and not for Open Elective subjects
        /// </summary>
        public const byte CA_TH_SUB_MAX = 25;
        public const byte CA_TH_SUB_MIN = 10;
        public const byte CA_OEL_SUB_MAX = 100;
        public const byte CA_OEL_SUB_MIN = 40;

        // CA Obtained marks
        public byte[] CA_SUB_OBTAINED_MARKS = new byte[5];

        // ESE Constants
        public const byte ESE_TH_SUB_MAX = 75;
        public const byte ESE_TH_SUB_MIN = 30;
        public const byte ESE_PR_SUB_MAX = 50;
        public const byte ESE_PR_SUB_MIN = 20;

        // ESE obtained marks
        public byte[] ESE_TH_SUB_OBTAINED_MARKS = new byte[4];     // Theory subjects
        public byte[] ESE_PR_SUB_OBTAINED_MARKS = new byte[2];     // Practical subjects

        // TOTAL MARKS 
        public byte[] SUB_TOTAL_OBTAINED_MARKS = new byte[7];

        // GRADES 
        public string[] SUB_OBTAINED_GRADE = new string[7];

        // GRADE POINTS
        public byte[] SUB_OBTAINED_GRADE_POINT = new byte[7];

        // EARNED GRADE POINTS
        public byte[] SUB_OBTAINED_EARNED_GRADE_POINT = new byte[7];

        // SEMESTER DATA SAVED FLAG
        public bool SEMESTER_DATA_SAVED = false; 

        // METHODS 

        // set theory subject names
        public void setThSubjectNames(string th_sub1, string th_sub2, string th_sub3)
        {
            this.thSubOne = th_sub1;
            this.thSubTwo = th_sub2;
            this.thSubThree = th_sub3;
        }
        public void setElectiveSubjectName(string el_sub)
        {
            this.elThSubFour = el_sub;
        }
        public void setOpenElectiveSubjectName(string openEl_sub)
        {
            this.oElThSubFive = openEl_sub;
        }

        // set practical subjects name
        public void setPrSubjectNames(string pr_sub1, string pr_sub2)
        {
            this.prSubOne = pr_sub1;
            this.prSubTwo = pr_sub2;
        }

        // set ca obtained marks
        public void set_CA_SUB_ObtainedMarks(byte m1, byte m2, byte m3, byte m4, byte m5)
        {
            this.CA_SUB_OBTAINED_MARKS[0] = m1;
            this.CA_SUB_OBTAINED_MARKS[1] = m2;
            this.CA_SUB_OBTAINED_MARKS[2] = m3;
            this.CA_SUB_OBTAINED_MARKS[3] = m4;
            this.CA_SUB_OBTAINED_MARKS[4] = m5;
        }

        // set ese theory obtained marks
        public void set_ESE_TH_SUB_ObtainedMarks(byte m1, byte m2, byte m3, byte m4)
        {
            this.ESE_TH_SUB_OBTAINED_MARKS[0] = m1;
            this.ESE_TH_SUB_OBTAINED_MARKS[1] = m2;
            this.ESE_TH_SUB_OBTAINED_MARKS[2] = m3;
            this.ESE_TH_SUB_OBTAINED_MARKS[3] = m4;
        }

        // set ese practical obtained marks
        public void set_ESE_PR_SUB_ObtainedMarks(byte m1, byte m2)
        {
            this.ESE_PR_SUB_OBTAINED_MARKS[0] = m1;
            this.ESE_PR_SUB_OBTAINED_MARKS[1] = m2;
        }

        // calculate total sub marks
        private void calc_SUB_TotalObtainedMarks()
        {
            // theory subjects
            this.SUB_TOTAL_OBTAINED_MARKS[0] = Convert.ToByte(this.CA_SUB_OBTAINED_MARKS[0] + this.ESE_TH_SUB_OBTAINED_MARKS[0]);
            this.SUB_TOTAL_OBTAINED_MARKS[1] = Convert.ToByte(this.CA_SUB_OBTAINED_MARKS[1] + this.ESE_TH_SUB_OBTAINED_MARKS[1]);
            this.SUB_TOTAL_OBTAINED_MARKS[2] = Convert.ToByte(this.CA_SUB_OBTAINED_MARKS[2] + this.ESE_TH_SUB_OBTAINED_MARKS[2]);
            this.SUB_TOTAL_OBTAINED_MARKS[3] = Convert.ToByte(this.CA_SUB_OBTAINED_MARKS[3] + this.ESE_TH_SUB_OBTAINED_MARKS[3]);
            this.SUB_TOTAL_OBTAINED_MARKS[4] = Convert.ToByte(this.CA_SUB_OBTAINED_MARKS[4]);

            // practical subjects
            this.SUB_TOTAL_OBTAINED_MARKS[5] = this.ESE_PR_SUB_OBTAINED_MARKS[0];
            this.SUB_TOTAL_OBTAINED_MARKS[6] = this.ESE_PR_SUB_OBTAINED_MARKS[1];
        }

        // calculate sub grade point
        private void calc_SUB_ObtainedGradePoint()
        {
            byte sub_index = 0;
            // theory + practical subjects marks
            foreach (byte marks in this.SUB_TOTAL_OBTAINED_MARKS)
            {
                this.SUB_OBTAINED_GRADE_POINT[sub_index] = this.findGradePoint(marks, sub_index);
                sub_index++;
            }
        }

        // calculate sub grade
        private void calc_SUB_ObtainedGrade()
        {
            byte sub_index = 0;
            // theory + practical subjects grade point
            foreach (byte gradePoint in this.SUB_OBTAINED_GRADE_POINT)
            {
                this.SUB_OBTAINED_GRADE[sub_index] = this.findGrade(gradePoint);
                sub_index++;
            }
        }
        // calculate earned credit points
        private void calc_SUB_CREDIT_EARNED()
        {
            byte sub_index = 0;
            // TH subjects credits points
            for (byte i = 0; i < 5; i++)
            {
                if (this.SUB_TOTAL_OBTAINED_MARKS[sub_index] > 40)
                {
                    this.TH_SUB_CREDIT_EARNED[i] = TH_SUB_CREDIT;
                }
                else
                {
                    this.TH_SUB_CREDIT_EARNED[i] = 0;
                }
                sub_index++;
            }

            //  PR subjects credit points
            for (byte i = 0; i < 2; i++)
            {
                if (this.SUB_TOTAL_OBTAINED_MARKS[sub_index] > 20)
                {
                    this.PR_SUB_CREDIT_EARNED[i] = PR_SUB_CREDIT;
                }
                else
                {
                    this.PR_SUB_CREDIT_EARNED[i] = 0;
                }
                sub_index++;
            }
        }


        // calculate sub earned grade point
        private void calc_SUB_EarnedGradePoint()
        {
            // EGP = GP * Credit Earned
            // OPTIMIZE IT 
            // TH sub - 5
            this.SUB_OBTAINED_EARNED_GRADE_POINT[0] = Convert.ToByte(this.SUB_OBTAINED_GRADE_POINT[0] * this.TH_SUB_CREDIT_EARNED[0]);
            this.SUB_OBTAINED_EARNED_GRADE_POINT[1] = Convert.ToByte(this.SUB_OBTAINED_GRADE_POINT[1] * this.TH_SUB_CREDIT_EARNED[1]);
            this.SUB_OBTAINED_EARNED_GRADE_POINT[2] = Convert.ToByte(this.SUB_OBTAINED_GRADE_POINT[2] * this.TH_SUB_CREDIT_EARNED[2]);
            this.SUB_OBTAINED_EARNED_GRADE_POINT[3] = Convert.ToByte(this.SUB_OBTAINED_GRADE_POINT[3] * this.TH_SUB_CREDIT_EARNED[3]);
            this.SUB_OBTAINED_EARNED_GRADE_POINT[4] = Convert.ToByte(this.SUB_OBTAINED_GRADE_POINT[4] * this.TH_SUB_CREDIT_EARNED[4]);

            // PR sub - 2
            this.SUB_OBTAINED_EARNED_GRADE_POINT[5] = Convert.ToByte(this.SUB_OBTAINED_GRADE_POINT[5] * this.PR_SUB_CREDIT_EARNED[0]);
            this.SUB_OBTAINED_EARNED_GRADE_POINT[6] = Convert.ToByte(this.SUB_OBTAINED_GRADE_POINT[6] * this.PR_SUB_CREDIT_EARNED[1]);
        }


        // grade point calculator
        public byte findGradePoint(byte marks, byte subIndex) 
        {
            if (subIndex >= 0 && subIndex < 5)
            {
                // TH - theory subject 
                if (marks >= 80 && marks <= 100) { return 10; }
                if (marks >= 70 && marks < 80) { return 9; }
                if (marks >= 60 && marks < 70) { return 8; }
                if (marks >= 55 && marks < 60) { return 7; }
                if (marks >= 50 && marks < 55) { return 6; }
                if (marks >= 45 && marks < 50) { return 5; }
                if (marks >= 40 && marks < 45) { return 4; }
                if (marks < 40) { return 0; }
            }
            if (subIndex == 5 || subIndex == 6)
            {
                // PR - practical subject
                if (marks >= 40 && marks <= 50) { return 10; }
                if (marks >= 35 && marks < 40) { return 9; }
                if (marks >= 30 && marks < 35) { return 8; }
                if (marks >= 27 && marks < 30) { return 7; }
                if (marks >= 25 && marks < 27) { return 6; }
                if (marks >= 22 && marks < 25) { return 5; }
                if (marks >= 20 && marks < 22) { return 4; } 
                if (marks < 20) { return 0; } 
            }
            return 0;
        }
        // grade calculator
        private string findGrade(byte gradePoint)
        {
            // TH - theory subject grades
            if (gradePoint == 10) { return "O"; }
            if (gradePoint == 9) { return "A+"; }
            if (gradePoint == 8) { return "A"; }
            if (gradePoint == 7) { return "B+"; }
            if (gradePoint == 6) { return "B"; }
            if (gradePoint == 5) { return "C"; }
            if (gradePoint == 4) { return "P"; }
            if (gradePoint == 0) { return "F"; }
            
            return "Ab";
        }

        // METHOD : CALCULATE SEMESTER 
        public bool calculateSemester()
        {
            if ( this.SEMESTER_DATA_SAVED )
            {
                // 1. TOT calculate (Total) 
                this.calc_SUB_TotalObtainedMarks();

                // 2. CREDIT calculate for each subject
                this.calc_SUB_CREDIT_EARNED();

                // 3. GP calculate (Grade Point)
                this.calc_SUB_ObtainedGradePoint();

                // 4. G calculate (Grade)
                this.calc_SUB_ObtainedGrade();

                // 5. EGP calculate (Earned Grade Point)
                this.calc_SUB_EarnedGradePoint();

                return true;
            }

            return false; 
        }


    }

    public class LastYear
    {
        // CPGA
        public double CGPA { get; set; }

        // CREDIT EARNED TOTAL
        public byte TOTAL_CREDIT_EARNED { get; set; }

        // TOTAL MARKS OUT OF 1200
        public short TOTAL_MARKS { get; set; }
        public const short TOTAL_MARKS_MAX = 1200;

        // TOTAL GRADE POINT - GP
        public byte TOTAL_GRADE_POINT { get; set; }

        // TOTAL EARNED GRADE POINT - EGP 
        public short TOTAL_EARNED_GRADE_POINT { get; set; }

        // YEAR DATA SAVED 
        public bool YEAR_DATA_SAVED = false; 

        // Get Total Marks Max
        public short get_Total_MaxMarks()
        {
            return TOTAL_MARKS_MAX;
        }

        public void resetYear()
        {
            this.CGPA = 0;
            this.TOTAL_CREDIT_EARNED = 0;
            this.TOTAL_MARKS = 0;
            this.TOTAL_GRADE_POINT = 0;
            this.TOTAL_EARNED_GRADE_POINT = 0;

            // SET FLAG
            this.YEAR_DATA_SAVED = false; 
        }

    }

    public class YearModel : LastYear
    {
        // two semester
        public SemesterModel firstSemester = new SemesterModel();
        public SemesterModel secondSemester = new SemesterModel();

        // RESULT
        public string RESULT;


        // METHODS
        // calculate total credit earned
        private void calc_TotalCreditEarned()
        {
            this.TOTAL_CREDIT_EARNED = 0;

            // SEMESTER I & SEMESTER II 
            // TH - theory subject credit point
            for (byte i = 0; i< firstSemester.TH_SUB_CREDIT_EARNED.Length; i++)
            {
                this.TOTAL_CREDIT_EARNED += firstSemester.TH_SUB_CREDIT_EARNED[i]; 
                this.TOTAL_CREDIT_EARNED += secondSemester.TH_SUB_CREDIT_EARNED[i];  
            }
            // PR - practical subject credit point
            for (byte i = 0; i < firstSemester.PR_SUB_CREDIT_EARNED.Length; i++)
            {
                this.TOTAL_CREDIT_EARNED += firstSemester.PR_SUB_CREDIT_EARNED[i]; 
                this.TOTAL_CREDIT_EARNED += secondSemester.PR_SUB_CREDIT_EARNED[i];  
            }

        }

        // calculate total marks obtained
        private void calc_TotalObtainedMarks()
        {
            this.TOTAL_MARKS = 0; 

            for (byte i = 0; i < this.firstSemester.SUB_TOTAL_OBTAINED_MARKS.Length; i++)
            {
                this.TOTAL_MARKS += this.firstSemester.SUB_TOTAL_OBTAINED_MARKS[i];
                this.TOTAL_MARKS += this.secondSemester.SUB_TOTAL_OBTAINED_MARKS[i];
            }
        }

        // calculate total grade points
        private void calc_TotalObtainedGradePoint()
        {
            this.TOTAL_GRADE_POINT = 0; 

            for (byte i = 0; i < this.firstSemester.SUB_OBTAINED_GRADE_POINT.Length; i++)
            {
                this.TOTAL_GRADE_POINT += this.firstSemester.SUB_OBTAINED_GRADE_POINT[i];
                this.TOTAL_GRADE_POINT += this.secondSemester.SUB_OBTAINED_GRADE_POINT[i];
            }
        }

        // calculate total earned grade point
        private void calc_TotalObtainedEarnedGradePoint()
        {
            this.TOTAL_EARNED_GRADE_POINT = 0;
            for (byte i = 0; i < this.firstSemester.SUB_OBTAINED_EARNED_GRADE_POINT.Length; i++)
            {
                this.TOTAL_EARNED_GRADE_POINT += this.firstSemester.SUB_OBTAINED_EARNED_GRADE_POINT[i];
                this.TOTAL_EARNED_GRADE_POINT += this.secondSemester.SUB_OBTAINED_EARNED_GRADE_POINT[i];
            }
        }

        private void calc_CGPA()
        {
            this.CGPA = 0; 

            // CGPA = Earned Grade Point / Earned Credit Points   (rounded upto 2 decimal places)
            this.CGPA = Math.Round((double)this.TOTAL_EARNED_GRADE_POINT / this.TOTAL_CREDIT_EARNED, 2);
        }


        // TODO - calculate result 
        private void calc_Result()
        {
            bool pass = true;
            for (byte i = 0; i < firstSemester.SUB_TOTAL_OBTAINED_MARKS.Length; i++)
            {
                if (firstSemester.SUB_TOTAL_OBTAINED_MARKS[i] < 40 && i < 5)
                {
                    // fail in theory subject
                    pass = false;
                    break;
                }
                else if (firstSemester.SUB_TOTAL_OBTAINED_MARKS[i] < 20 && i >= 5)
                {
                    // fail in practical subject
                    pass = false;
                    break;
                }
            }

            if (pass)
            {
                this.RESULT = "PASS";
            }
            else
            {
                this.RESULT = "FAIL";
            }
        }

        // METHOD : CALCULATE YEAR 
        public bool calculateYear()
        {
            if (this.YEAR_DATA_SAVED) 
            {
                // 1. CALCULATE SEMESTER III
                this.firstSemester.calculateSemester();

                // 2. CALCULATE SEMESTER IV
                this.secondSemester.calculateSemester(); 


                // 1. TOTAL calculate marks 
                this.calc_TotalObtainedMarks();

                // 2. CREDIT EARNED calculate
                this.calc_TotalCreditEarned();

                // 3. GP calculate ( Grade Point )
                this.calc_TotalObtainedGradePoint();

                // 4. EGP calculate (EARNED GRADE POINT) 
                this.calc_TotalObtainedEarnedGradePoint();

                // 5. CGPA calculate 
                this.calc_CGPA();

                // 6. RESULT calculate 
                this.calc_Result();

                return true; 
            }

            return false; 
        }

    }



    public class Marksheet
    {
        // TODO - Implement me
        // Student details
        public StudentModel student = new StudentModel();

        // First Year details
        public LastYear firstYear = new LastYear();

        // Second Year Details
        public YearModel secondYear = new YearModel();

        public string serialNumber { get; set; }

        public bool MARKSHEET_CALCULATED = false;

        private string APP_NAME = "Academic Archive";
        private string APP_SYS_DIR_PATH = "C:\\Academic Archive\\System Files\\"; 

        // PREVIOUS MARKSHEET FILE NAME 
        public string PREVIOUS_MARKSHEET_FILE_PATH = "PREVIOUS_MARKSHEET.txt";
        
        // MARKSHEET FILE NAME - JUST GENERATED
        public string MARKSHEET_FILE_PATH = string.Empty;

        // STORE PREVIOUS MARKSHEET SEAT NO
        public string[] previousMarksheetSeatNo; 


        // METHOD : MARKSHEET DATA SAVED 
        public bool marksheetDataSaved()
        {
            if (this.student.STUDENT_DATA_SAVED && this.firstYear.YEAR_DATA_SAVED && this.secondYear.YEAR_DATA_SAVED)
            {
                return true; 
            }

            return false;
        }

        public bool calculateMarksheet()
        {
            if (this.marksheetDataSaved())
            {
                // IF SEM III & SEM IV & FY Data is successfully saved
                // 1. CALCULATE SEMESTER III
                // this.secondYear.firstSemester.calculateSemester();

                // 2. CALCULATE SEMESTER IV
                // this.secondYear.secondSemester.calculateSemester();

                // 3. CALCULATE YEAR 2
                this.secondYear.calculateYear();

                // 4. CALCULATE SERIAL NUMBER
                Random generator = new Random();
                string serialNo = generator.Next(0, 1000000).ToString("D7");
                serialNo = "CQ-" + serialNo;
                this.serialNumber = serialNo;

                // 5. SET MARKSHEET_CALCULATED FLAG TRUE
                this.MARKSHEET_CALCULATED = true; 
            }

            return false; 
        }

        private bool updatePreviousMarksheetFile()
        {
            //if (this.marksheetDataSaved() && this.MARKSHEET_CALCULATED)
            //{
                try
                {
                    // CREATE DIR IF NOT EXIST 
                    if (!Directory.Exists(this.APP_SYS_DIR_PATH))
                    {
                        Directory.CreateDirectory(this.APP_SYS_DIR_PATH);
                    }

                    // 1. CREAET TEXT CONNECTION FOR PREVIOUS_MARKSHEET.TEXT FILE 
                    string filePath = this.APP_SYS_DIR_PATH + this.PREVIOUS_MARKSHEET_FILE_PATH;

                    using (StreamWriter fileWriter = new StreamWriter(filePath, true))
                    {
                        string line = this.student.SeatNo.ToString(); 
                        
                        if (!lineExist(filePath, line))
                        {
                            fileWriter.WriteLine(line); 
                        }
                        
                    }

                    return true; 
                }
                catch (IOException e)
                {
                    Console.WriteLine("An error occurred: " + e.Message);
                }

            //}
            return false;
        }

        private bool lineExist(string filePath, string searchLine)
        {
            try
            {
                // Open the file for reading
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Compare the current line with the line you're searching for
                        if (line == searchLine)
                        {
                            return true; 
                            
                        }
                    }
                }
                return false; 
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
                return false; 
            }
        }

        private bool saveMarksheet()
        {
            if (this.marksheetDataSaved() && this.MARKSHEET_CALCULATED)
            {
                // DATA IS STORED 
                // DATA IS CALCULATED

                try
                {
                    // 1. SAVE MARKSHEET DATA 
                    // SET MARKSHEET FILE 
                    this.MARKSHEET_FILE_PATH = this.student.SeatNo.Trim() + ".txt";

                    string filePath = this.APP_SYS_DIR_PATH + this.MARKSHEET_FILE_PATH;

                    using (StreamWriter fileWriter = new StreamWriter(filePath))
                    {
                        string line = string.Empty;

                        // 1. STUDENT data save
                        // format line 
                        line = this.student.Name + "," + this.student.PrnNo + "," + this.student.SeatNo + "," + this.student.AbcId;

                        //  write line to file
                        fileWriter.WriteLine(line);

                        // 2. FIRST YEAR data save
                        // clear line 
                        line = string.Empty;

                        // format line 
                        line = this.firstYear.CGPA.ToString() + "," +
                                this.firstYear.TOTAL_CREDIT_EARNED.ToString() + "," +
                                this.firstYear.TOTAL_MARKS.ToString() + "," +
                                this.firstYear.TOTAL_GRADE_POINT.ToString() + "," +
                                this.firstYear.TOTAL_EARNED_GRADE_POINT.ToString();

                        // write line to file 
                        fileWriter.WriteLine(line);

                        // 3. SECOND YEAR DATA save

                        // i. SEM - III data save 

                        // CREDITS
                        // TH - theory subject credit
                        line = string.Empty;

                        for (byte i = 0; i < this.secondYear.firstSemester.TH_SUB_CREDIT_EARNED.Length; i++)
                        {
                            line += this.secondYear.firstSemester.TH_SUB_CREDIT_EARNED[i] + ",";
                        }
                        // remove head and trail commas 
                        line.Trim(',');

                        // write line to file
                        fileWriter.WriteLine(line);


                        // PR - practical subject credit
                        line = string.Empty;

                        for (byte i = 0; i < this.secondYear.firstSemester.PR_SUB_CREDIT_EARNED.Length; i++)
                        {
                            line += this.secondYear.firstSemester.PR_SUB_CREDIT_EARNED[i] + ",";
                        }
                        // remove head and trail commas 
                        line.Trim(',');

                        // write line to file
                        fileWriter.WriteLine(line);

                        // CA MARKS
                        line = string.Empty;

                        // format line 
                        for (byte i = 0; i < this.secondYear.firstSemester.CA_SUB_OBTAINED_MARKS.Length; i++)
                        {
                            line += this.secondYear.firstSemester.CA_SUB_OBTAINED_MARKS[i] + ",";
                        }
                        // remove head and trail commas
                        line.Trim(',');

                        // write line to file 
                        fileWriter.WriteLine(line);

                        // ESE MARKS
                        line = string.Empty;

                        // format line 
                        for (byte i = 0; i < this.secondYear.firstSemester.ESE_TH_SUB_OBTAINED_MARKS.Length; i++)
                        {
                            line += this.secondYear.firstSemester.ESE_TH_SUB_OBTAINED_MARKS[i] + ",";
                        }
                        // remove head and trail commas
                        line.Trim(',');

                        // write line to file 
                        fileWriter.WriteLine(line);



                        // PR MARKS

                        line = string.Empty;

                        // format line 
                        for (byte i = 0; i < this.secondYear.firstSemester.ESE_PR_SUB_OBTAINED_MARKS.Length; i++)
                        {
                            line += this.secondYear.firstSemester.ESE_PR_SUB_OBTAINED_MARKS[i] + ",";
                        }
                        // remove head and trail commas
                        line.Trim(',');

                        // write line to file 
                        fileWriter.WriteLine(line);


                        // TOT MARKS

                        line = string.Empty;

                        // format line 
                        for (byte i = 0; i < this.secondYear.firstSemester.SUB_TOTAL_OBTAINED_MARKS.Length; i++)
                        {
                            line += this.secondYear.firstSemester.SUB_TOTAL_OBTAINED_MARKS[i] + ",";
                        }
                        // remove head and trail commas
                        line.Trim(',');

                        // write line to file 
                        fileWriter.WriteLine(line);

                        // GRADE

                        line = string.Empty;

                        // format line 
                        for (byte i = 0; i < this.secondYear.firstSemester.SUB_OBTAINED_GRADE.Length; i++)
                        {
                            line += this.secondYear.firstSemester.SUB_OBTAINED_GRADE[i] + ",";
                        }
                        // remove head and trail commas
                        line.Trim(',');

                        // write line to file 
                        fileWriter.WriteLine(line);


                        // GP GRADE POINT 

                        line = string.Empty;

                        // format line 
                        for (byte i = 0; i < this.secondYear.firstSemester.SUB_OBTAINED_GRADE_POINT.Length; i++)
                        {
                            line += this.secondYear.firstSemester.SUB_OBTAINED_GRADE_POINT[i] + ",";
                        }
                        // remove head and trail commas
                        line.Trim(',');

                        // write line to file 
                        fileWriter.WriteLine(line);


                        // EGP EARNED GRADE POINT

                        line = string.Empty;

                        // format line 
                        for (byte i = 0; i < this.secondYear.firstSemester.SUB_OBTAINED_EARNED_GRADE_POINT.Length; i++)
                        {
                            line += this.secondYear.firstSemester.SUB_OBTAINED_EARNED_GRADE_POINT[i] + ",";
                        }
                        // remove head and trail commas
                        line.Trim(',');

                        // write line to file 
                        fileWriter.WriteLine(line);

                        // ii. SEM - IV data save 

                        // CREDITS
                        // TH - theory subject credit
                        line = string.Empty;

                        for (byte i = 0; i < this.secondYear.secondSemester.TH_SUB_CREDIT_EARNED.Length; i++)
                        {
                            line += this.secondYear.secondSemester.TH_SUB_CREDIT_EARNED[i] + ",";
                        }
                        // remove head and trail commas 
                        line.Trim(',');

                        // write line to file
                        fileWriter.WriteLine(line);


                        // PR - CREDIT practical subject credit
                        line = string.Empty;

                        for (byte i = 0; i < this.secondYear.secondSemester.PR_SUB_CREDIT_EARNED.Length; i++)
                        {
                            line += this.secondYear.secondSemester.PR_SUB_CREDIT_EARNED[i] + ",";
                        }
                        // remove head and trail commas 
                        line.Trim(',');

                        // write line to file
                        fileWriter.WriteLine(line);

                        // CA MARKS
                        line = string.Empty;

                        // format line 
                        for (byte i = 0; i < this.secondYear.secondSemester.CA_SUB_OBTAINED_MARKS.Length; i++)
                        {
                            line += this.secondYear.secondSemester.CA_SUB_OBTAINED_MARKS[i] + ",";
                        }
                        // remove head and trail commas
                        line.Trim(',');

                        // write line to file 
                        fileWriter.WriteLine(line);

                        // ESE MARKS
                        line = string.Empty;

                        // format line 
                        for (byte i = 0; i < this.secondYear.secondSemester.ESE_TH_SUB_OBTAINED_MARKS.Length; i++)
                        {
                            line += this.secondYear.secondSemester.ESE_TH_SUB_OBTAINED_MARKS[i] + ",";
                        }
                        // remove head and trail commas
                        line.Trim(',');

                        // write line to file 
                        fileWriter.WriteLine(line);



                        // PR MARKS

                        line = string.Empty;

                        // format line 
                        for (byte i = 0; i < this.secondYear.secondSemester.ESE_PR_SUB_OBTAINED_MARKS.Length; i++)
                        {
                            line += this.secondYear.secondSemester.ESE_PR_SUB_OBTAINED_MARKS[i] + ",";
                        }
                        // remove head and trail commas
                        line.Trim(',');

                        // write line to file 
                        fileWriter.WriteLine(line);


                        // TOT MARKS

                        line = string.Empty;

                        // format line 
                        for (byte i = 0; i < this.secondYear.secondSemester.SUB_TOTAL_OBTAINED_MARKS.Length; i++)
                        {
                            line += this.secondYear.secondSemester.SUB_TOTAL_OBTAINED_MARKS[i] + ",";
                        }
                        // remove head and trail commas
                        line.Trim(',');

                        // write line to file 
                        fileWriter.WriteLine(line);

                        // GRADE

                        line = string.Empty;

                        // format line 
                        for (byte i = 0; i < this.secondYear.secondSemester.SUB_OBTAINED_GRADE.Length; i++)
                        {
                            line += this.secondYear.secondSemester.SUB_OBTAINED_GRADE[i] + ",";
                        }
                        // remove head and trail commas
                        line.Trim(',');

                        // write line to file 
                        fileWriter.WriteLine(line);


                        // GP GRADE POINT 

                        line = string.Empty;

                        // format line 
                        for (byte i = 0; i < this.secondYear.secondSemester.SUB_OBTAINED_GRADE_POINT.Length; i++)
                        {
                            line += this.secondYear.secondSemester.SUB_OBTAINED_GRADE_POINT[i] + ",";
                        }
                        // remove head and trail commas
                        line.Trim(',');

                        // write line to file 
                        fileWriter.WriteLine(line);


                        // EGP EARNED GRADE POINT

                        line = string.Empty;

                        // format line 
                        for (byte i = 0; i < this.secondYear.secondSemester.SUB_OBTAINED_EARNED_GRADE_POINT.Length; i++)
                        {
                            line += this.secondYear.secondSemester.SUB_OBTAINED_EARNED_GRADE_POINT[i] + ",";
                        }
                        // remove head and trail commas
                        line.Trim(',');

                        // write line to file 
                        fileWriter.WriteLine(line);

                        // iii. SECOND YEAR data save
                        line = string.Empty;

                        // format line 
                        line = this.secondYear.CGPA.ToString() + "," +
                                this.secondYear.TOTAL_CREDIT_EARNED.ToString() + "," +
                                this.secondYear.TOTAL_MARKS.ToString() + "," +
                                this.secondYear.TOTAL_GRADE_POINT.ToString() + "," +
                                this.secondYear.TOTAL_EARNED_GRADE_POINT.ToString();

                        // write line to file 
                        fileWriter.WriteLine(line);

                        // iv. RESULT save 
                        line = string.Empty;

                        // format line 
                        line = this.secondYear.RESULT;

                        // write line to file
                        fileWriter.WriteLine(line);

                        // 4. SERIAL NO save
                        line = string.Empty;

                        // format line
                        line = this.serialNumber;

                        // write line to file
                        fileWriter.WriteLine(line);

                        // 5. MARK MEMO ISSUE DATE save
                    }


                }
                catch (IOException e)
                {
                    Console.WriteLine("An error occurred: " + e.Message);
                }

            }

            return false;
        }

        // METHOD : STORE MARKSHEET DATA IN TEXT FILE
        public bool  saveMarksheetDataInTextFile()
        {
            if (this.marksheetDataSaved() && this.MARKSHEET_CALCULATED) 
            {
                // DATA IS STORED 
                // DATA IS CALCULATED

                try
                {
                    // 1. SAVE SEAT NO in PREVIOUS MARKSHEET FILE 
                    this.updatePreviousMarksheetFile();


                    // 2. SAVE MARKSHEET DATA 
                    this.saveMarksheet();

                    // 3. MARK MEMO ISSUE DATE save - TODO 

                    return true;
                }
                catch (IOException e)
                {
                    Console.WriteLine("An error occurred: " + e.Message);
                }
            }

            return false; 
        }

        // METHOD : COUNT LINE IN FILE
        private int countFileLine(string filePath)
        {
            try
            {
                int lineCount = 0;

                // Open the file for reading
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (reader.ReadLine() != null)
                    {
                        lineCount++;
                    }
                }

                // Console.WriteLine("Number of lines in the file: " + lineCount);

                return lineCount; 
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
            return 0;  
        }

        // METHOD : Read PREVIOUS MARKSHEET File 
        public bool readPreviousMarksheetTextFile()
        {
            string filePath = this.APP_SYS_DIR_PATH + this.PREVIOUS_MARKSHEET_FILE_PATH; 
            if (File.Exists(filePath)) 
            {
                try
                {
                    int fileSize = this.countFileLine(filePath);
                    this.previousMarksheetSeatNo = new string[fileSize];

                    using (StreamReader fileReader = new StreamReader(filePath))
                    {
                        string line;
                        int index = 0;
                        while ((line = fileReader.ReadLine()) != null)
                        {
                            this.previousMarksheetSeatNo[index++] = line.Trim();
                        }
                    }

                    return true; 
                }
                catch (IOException e)
                {
                    Console.WriteLine("An error occurred: " + e.Message);
                }
            }
            return false;
        }

        public bool readMarksheet(string fileName)
        {
            // CHECK FILE WITH EXTENSION
            if (!fileName.EndsWith(".txt"))
            {
                fileName = fileName + ".txt"; 
            }

            string filePath = this.APP_SYS_DIR_PATH + fileName;

            if (File.Exists(filePath))
            {
                // READ MARKSHEET
                try
                {
                    using (StreamReader fileReader = new StreamReader(filePath))
                    {
                        string line = string.Empty;
                        string[] values;
                        byte index = 0;

                        
                        // 1. STUDENT DATA read
                        line = fileReader.ReadLine();
                        values = new string[4];
                        index = 0;
                        
                        // EXTRACT VALUES
                        foreach (string val in line.Split(','))
                        {
                            if (val != "")
                            {
                                values[index++] = val;
                            }
                        }

                        // SET VALUES 
                        this.student.Name = values[0].ToString();
                        this.student.PrnNo = values[1].ToString();
                        this.student.SeatNo = values[2].ToString();
                        this.student.AbcId = values[3].ToString();

                        // 2. FIRST YEAR DATA read
                        line = string.Empty;
                        line = fileReader.ReadLine();

                        values = new string[5];
                        index = 0;

                        // EXTRACT VALUES
                        foreach (string val in line.Split(','))
                        {
                            if (val != "")
                            {
                                values[index++] = val;
                            }
                        }

                        // SET VALUES
                        this.firstYear.CGPA = Convert.ToDouble(values[0]);
                        this.firstYear.TOTAL_CREDIT_EARNED = Convert.ToByte(values[1]); 
                        this.firstYear.TOTAL_MARKS = Convert.ToInt16(values[2]);
                        this.firstYear.TOTAL_GRADE_POINT = Convert.ToByte(values[3]);
                        this.firstYear.TOTAL_EARNED_GRADE_POINT = Convert.ToInt16(values[4]);

                        // 3. SECOND YEAR DATA read
                        // i. SEM III
                        // CREDIT
                        // TH - Credit 
                        line = string.Empty;
                        line = fileReader.ReadLine(); 

                        values = new string[5];
                        index = 0;

                        // EXTRACT VALUES
                        foreach (string val in line.Split(','))
                        {
                            if (val != "")
                            {
                                values[index++] = val;
                            }
                        }

                        // SET VALUES
                        for (index = 0; index<5; index++)
                        {
                            this.secondYear.firstSemester.TH_SUB_CREDIT_EARNED[index] = Convert.ToByte(values[index]);

                        }

                        // PR - Credits
                        line = string.Empty;
                        line = fileReader.ReadLine();

                        values = new string[2]; 
                        index = 0;

                        // EXTRACT VALUES
                        foreach (string val in line.Split(','))
                        {
                            if (val != "")
                            {
                                values[index++] = val;
                            }
                        }

                        // SET VALUES
                        for (index = 0; index < 2; index++)
                        {
                            this.secondYear.firstSemester.PR_SUB_CREDIT_EARNED[index] = Convert.ToByte(values[index]); 

                        }

                        // CA
                        line = string.Empty;
                        line = fileReader.ReadLine();

                        values = new string[5]; 
                        index = 0;

                        // EXTRACT VALUES
                        foreach (string val in line.Split(','))
                        {
                            if (val != "")
                            {
                                values[index++] = val;
                            }
                        }

                        // SET VALUES
                        for (index = 0; index < 5; index++)
                        {
                            this.secondYear.firstSemester.CA_SUB_OBTAINED_MARKS[index] = Convert.ToByte(values[index]);
                        }

                        // ESE
                        // TH - ESE 
                        line = string.Empty;
                        line = fileReader.ReadLine();

                        values = new string[4]; 
                        index = 0;

                        // EXTRACT VALUES
                        foreach (string val in line.Split(','))
                        {
                            if (val != "")
                            {
                                values[index++] = val;
                            }
                        }

                        // SET VALUES
                        for (index = 0; index < 4; index++)
                        {
                            this.secondYear.firstSemester.ESE_TH_SUB_OBTAINED_MARKS[index] = Convert.ToByte(values[index]); 
                        }

                        // PR 
                        line = string.Empty;
                        line = fileReader.ReadLine();

                        values = new string[2]; 
                        index = 0;

                        // EXTRACT VALUES
                        foreach (string val in line.Split(','))
                        {
                            if (val != "")
                            {
                                values[index++] = val;
                            }
                        }

                        // SET VALUES
                        for (index = 0; index < 2; index++)
                        {
                            this.secondYear.firstSemester.ESE_PR_SUB_OBTAINED_MARKS[index] = Convert.ToByte(values[index]); 
                        }

                        // TOT
                        line = string.Empty;
                        line = fileReader.ReadLine();

                        values = new string[7];
                        index = 0;

                        // EXTRACT VALUES
                        foreach (string val in line.Split(','))
                        {
                            if (val != "")
                            {
                                values[index++] = val;
                            }
                        }

                        // SET VALUES
                        for (index = 0; index < 7; index++)
                        {
                            this.secondYear.firstSemester.SUB_TOTAL_OBTAINED_MARKS[index] = Convert.ToByte(values[index]); 
                        }


                        // GRADE
                        line = string.Empty;
                        line = fileReader.ReadLine();

                        values = new string[7];
                        index = 0;

                        // EXTRACT VALUES
                        foreach (string val in line.Split(','))
                        {
                            if (val != "")
                            {
                                values[index++] = val;
                            }
                        }

                        // SET VALUES
                        for (index = 0; index < 7; index++)
                        {
                            this.secondYear.firstSemester.SUB_OBTAINED_GRADE[index] = values[index].Trim();  
                        }


                        // GP
                        line = string.Empty;
                        line = fileReader.ReadLine();

                        values = new string[7];
                        index = 0;

                        // EXTRACT VALUES
                        foreach (string val in line.Split(','))
                        {
                            if (val != "")
                            {
                                values[index++] = val;
                            }
                        }

                        // SET VALUES
                        for (index = 0; index < 7; index++)
                        {
                            this.secondYear.firstSemester.SUB_OBTAINED_GRADE_POINT[index] = Convert.ToByte(values[index]);
                        }


                        // EGP
                        line = string.Empty;
                        line = fileReader.ReadLine();

                        values = new string[7];
                        index = 0;

                        // EXTRACT VALUES
                        foreach (string val in line.Split(','))
                        {
                            if (val != "")
                            {
                                values[index++] = val;
                            }
                        }

                        // SET VALUES
                        for (index = 0; index < 7; index++)
                        {
                            this.secondYear.firstSemester.SUB_OBTAINED_EARNED_GRADE_POINT[index] = Convert.ToByte(values[index]); 
                        }


                        // ii. SEM IV
                        // CREDIT
                        // TH - Credits
                        line = string.Empty;
                        line = fileReader.ReadLine();

                        values = new string[5];
                        index = 0;

                        // EXTRACT VALUES
                        foreach (string val in line.Split(','))
                        {
                            if (val != "")
                            {
                                values[index++] = val;
                            }
                        }

                        // SET VALUES
                        for (index = 0; index < 5; index++)
                        {
                            this.secondYear.secondSemester.TH_SUB_CREDIT_EARNED[index] = Convert.ToByte(values[index]);

                        }

                        // PR - Credits
                        line = string.Empty;
                        line = fileReader.ReadLine();

                        values = new string[2];
                        index = 0;

                        // EXTRACT VALUES
                        foreach (string val in line.Split(','))
                        {
                            if (val != "")
                            {
                                values[index++] = val;
                            }
                        }

                        // SET VALUES
                        for (index = 0; index < 2; index++)
                        {
                            this.secondYear.secondSemester.PR_SUB_CREDIT_EARNED[index] = Convert.ToByte(values[index]);

                        }

                        // CA
                        line = string.Empty;
                        line = fileReader.ReadLine();

                        values = new string[5];
                        index = 0;

                        // EXTRACT VALUES
                        foreach (string val in line.Split(','))
                        {
                            if (val != "")
                            {
                                values[index++] = val;
                            }
                        }

                        // SET VALUES
                        for (index = 0; index < 5; index++)
                        {
                            this.secondYear.secondSemester.CA_SUB_OBTAINED_MARKS[index] = Convert.ToByte(values[index]);
                        }

                        // ESE
                        // TH - ESE 
                        line = string.Empty;
                        line = fileReader.ReadLine();

                        values = new string[4];
                        index = 0;

                        // EXTRACT VALUES
                        foreach (string val in line.Split(','))
                        {
                            if (val != "")
                            {
                                values[index++] = val;
                            }
                        }

                        // SET VALUES
                        for (index = 0; index < 4; index++)
                        {
                            this.secondYear.secondSemester.ESE_TH_SUB_OBTAINED_MARKS[index] = Convert.ToByte(values[index]);
                        }

                        // PR 
                        line = string.Empty;
                        line = fileReader.ReadLine();

                        values = new string[2];
                        index = 0;

                        // EXTRACT VALUES
                        foreach (string val in line.Split(','))
                        {
                            if (val != "")
                            {
                                values[index++] = val;
                            }
                        }

                        // SET VALUES
                        for (index = 0; index < 2; index++)
                        {
                            this.secondYear.secondSemester.ESE_PR_SUB_OBTAINED_MARKS[index] = Convert.ToByte(values[index]);
                        }

                        // TOT
                        line = string.Empty;
                        line = fileReader.ReadLine();

                        values = new string[7];
                        index = 0;

                        // EXTRACT VALUES
                        foreach (string val in line.Split(','))
                        {
                            if (val != "")
                            {
                                values[index++] = val;
                            }
                        }

                        // SET VALUES
                        for (index = 0; index < 7; index++)
                        {
                            this.secondYear.secondSemester.SUB_TOTAL_OBTAINED_MARKS[index] = Convert.ToByte(values[index]);
                        }


                        // GRADE
                        line = string.Empty;
                        line = fileReader.ReadLine();

                        values = new string[7];
                        index = 0;

                        // EXTRACT VALUES
                        foreach (string val in line.Split(','))
                        {
                            if (val != "")
                            {
                                values[index++] = val;
                            }
                        }

                        // SET VALUES
                        for (index = 0; index < 7; index++)
                        {
                            this.secondYear.secondSemester.SUB_OBTAINED_GRADE[index] = values[index].Trim();
                        }


                        // GP
                        line = string.Empty;
                        line = fileReader.ReadLine();

                        values = new string[7];
                        index = 0;

                        // EXTRACT VALUES
                        foreach (string val in line.Split(','))
                        {
                            if (val != "")
                            {
                                values[index++] = val;
                            }
                        }

                        // SET VALUES
                        for (index = 0; index < 7; index++)
                        {
                            this.secondYear.secondSemester.SUB_OBTAINED_GRADE_POINT[index] = Convert.ToByte(values[index]);
                        }


                        // EGP
                        line = string.Empty;
                        line = fileReader.ReadLine();

                        values = new string[7];
                        index = 0;

                        // EXTRACT VALUES
                        foreach (string val in line.Split(','))
                        {
                            if (val != "")
                            {
                                values[index++] = val;
                            }
                        }

                        // SET VALUES
                        for (index = 0; index < 7; index++)
                        {
                            this.secondYear.secondSemester.SUB_OBTAINED_EARNED_GRADE_POINT[index] = Convert.ToByte(values[index]);
                        }

                        // iii. YEAR 
                        line = string.Empty;
                        line = fileReader.ReadLine();

                        values = new string[5];
                        index = 0;

                        // EXTRACT VALUES
                        foreach (string val in line.Split(','))
                        {
                            if (val != "")
                            {
                                values[index++] = val;
                            }
                        }

                        // SET VALUES
                        this.secondYear.CGPA = Convert.ToDouble(values[0]);
                        this.secondYear.TOTAL_CREDIT_EARNED = Convert.ToByte(values[1]);
                        this.secondYear.TOTAL_MARKS = Convert.ToInt16(values[2]);
                        this.secondYear.TOTAL_GRADE_POINT = Convert.ToByte(values[3]);
                        this.secondYear.TOTAL_EARNED_GRADE_POINT = Convert.ToInt16(values[4]);

                        // iv. RESULT 
                        line = string.Empty;
                        line = fileReader.ReadLine();

                        // RESULT IS A SINGLE VALUE
                        // SET VALUE
                        this.secondYear.RESULT = line.Trim();

                        // 4. SERIAL NUMBER
                        line = string.Empty;
                        line = fileReader.ReadLine();

                        // SERIAL NUMBER IS SINGLE VALUE
                        // SET VALUE
                        this.serialNumber = line.Trim();

                        // 5. MARK MEMO ISSUE DATE 


                        return true; 
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine("An error occurred: " + e.Message);
                }
            }
            return false; 
        }







        // ------------------------------------
        private static Marksheet instance;
        
        private Marksheet() { }
        
        public static Marksheet Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Marksheet();
                }
                return instance;
            }
        }
        // -------------------------------------
    }
}
