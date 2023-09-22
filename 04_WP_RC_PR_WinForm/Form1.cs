using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace _04_WP_RC_PR_WinForm
{


    public partial class Form1 : Form
    {
        private string nameValuePlaceholder_Text = "Enter your full name";
        private string prnNoValuePlaceholder_Text = "Enter your PRN number";
        private string seatNoValuePlaceholder_Text = "Enter your seat number";
        private string abcIdValuePlaceholder_Text = "Enter your ABC Id";
        public Form1()
        {
            InitializeComponent();

            // LOAD PREVIOUS MARKSHEETS
            loadPreviousMarksheet();

        }

        public void loadPreviousMarksheet()
        {
            // CLEAR ALL ITEMS FIRST
            previousMarksheetCB.Items.Clear();

            // READ TEXT FILE

            Marksheet.Instance.readPreviousMarksheetTextFile();

            // ADD ALL SEAT NO 
            for (int i = 0; i < Marksheet.Instance.previousMarksheetSeatNo.Length; i++)
            {
                previousMarksheetCB.Items.Add(Marksheet.Instance.previousMarksheetSeatNo[i]);
            }
        }


        // TODO - implement method to validate basic information fields
        public bool validateBasicInformationFields()
        {
            // validate name field
            if (nameValueTB.Text.Length == 0 || nameValueTB.Text == nameValuePlaceholder_Text) { return false; }
            // validate prn no field
            if (prnNoValueTB.Text.Length == 0 || prnNoValueTB.Text == prnNoValuePlaceholder_Text) { return false; }
            // validate seat no field
            if (seatNoValueTB.Text.Length == 0 || seatNoValueTB.Text == seatNoValuePlaceholder_Text) { return false; }
            // validate abc id field
            if (abcIdValueTB.Text.Length == 0 || abcIdValueTB.Text == abcIdValuePlaceholder_Text) { return false; }

            return true;
        }

        // TODO - implement method to store basic information 
        public void storeBasicInformation()
        {
            if (validateBasicInformationFields())
            {
                // store name 
                Marksheet.Instance.student.Name = nameValueTB.Text.Trim().ToUpper();
                // store prn no
                Marksheet.Instance.student.PrnNo = prnNoValueTB.Text.Trim();
                // store abc id
                Marksheet.Instance.student.AbcId = abcIdValueTB.Text.Trim();
                // store seat no
                Marksheet.Instance.student.SeatNo = seatNoValueTB.Text.Trim();

                // SET STUDENT DATA SAVED FLAG
                Marksheet.Instance.student.STUDENT_DATA_SAVED = true;
            }
        }


        private void genMarksheetButton_Click(object sender, EventArgs e)
        {
            // validate all fields
            if (validateBasicInformationFields())
            {
                // store basic information
                storeBasicInformation();

                if (Marksheet.Instance.marksheetDataSaved())
                {
                    // 1. calculate marksheet
                    Marksheet.Instance.calculateMarksheet();

                    // 2. STORE MARKSHEET DATA IN TEXT FILE 
                    Marksheet.Instance.saveMarksheetDataInTextFile();

                    // 3. PREVIOUS MARKSHEET box update
                    this.loadPreviousMarksheet();

                    // 4. launch the marksheet form  
                    // create an instance of marksheetForm
                    MarksheetForm MarkMemo = new MarksheetForm();

                    // show markmemo as modal dialog
                    MarkMemo.ShowDialog();
                }
            }
        }

        private void fyDetailButton_Click(object sender, EventArgs e)
        {
            // Create an instance of Form2
            FYDataEntryForm FYDEF = new FYDataEntryForm();

            // Show Form2 as a modal dialog
            FYDEF.ShowDialog();
        }

        private void enterMarksButton_Click(object sender, EventArgs e)
        {
            SYDataEntryForm SYDEF = new SYDataEntryForm();

            // launch the form SY data entry form
            SYDEF.ShowDialog();
        }

        private void previousMarksheetCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fileName = previousMarksheetCB.SelectedItem.ToString().Trim();

            bool marksheetReady = Marksheet.Instance.readMarksheet(fileName);
            // Marksheet.Instance.readMarksheet(fileName);

            if (marksheetReady)
            {
                // 1. launch the marksheet form  
                // create an instance of marksheetForm
                MarksheetForm MarkMemo = new MarksheetForm();

                // show markmemo as modal dialog
                MarkMemo.ShowDialog();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // RESET FIELDS
            // 1. NAME
            nameValueTB.Text = string.Empty;

            // 2. PRN NO
            prnNoValueTB.Text = string.Empty;

            // 3. SEAT NO
            seatNoValueTB.Text = string.Empty;

            // 4. ABC ID
            abcIdValueTB.Text = string.Empty;

        }
    }



}