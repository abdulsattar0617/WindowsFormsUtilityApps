using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace _04_WP_RC_PR_WinForm
{
    public partial class SynapsyPointForm : Form
    {
        public SynapsyPointForm()
        {
            InitializeComponent();
        }

        private void fullDetailButton_Click(object sender, EventArgs e)
        {
            FY2DataEntryForm firstYearForm = new FY2DataEntryForm();

            // Launch FY Data Entry Form window 
            firstYearForm.ShowDialog();

            // Close Window
            this.Close();
        }

        private void shortDetailButton_Click(object sender, EventArgs e)
        {
            FYDataEntryForm firstYearForm = new FYDataEntryForm();

            // Launch FY2 Data Entry Form window 
            firstYearForm.ShowDialog();

            // Close window
            this.Close();
        }
    }
}
