namespace _04_WP_RC_PR_WinForm
{
    partial class FYDataEntryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FYDataEntryForm));
            firstYearDetailHeadingLabel = new Label();
            cgpaLabel = new Label();
            cgpaValueTB = new TextBox();
            creditEarnedValueTB = new TextBox();
            creditEarnedLabel = new Label();
            totalMarksValueTB = new TextBox();
            totalMarksLabel = new Label();
            gradePointValueTB = new TextBox();
            gradePointLabel = new Label();
            earnedGradePointValueTB = new TextBox();
            earnedGradePointLabel = new Label();
            saveButton = new Button();
            horizontalLineLabel = new Label();
            resetButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // firstYearDetailHeadingLabel
            // 
            firstYearDetailHeadingLabel.AutoSize = true;
            firstYearDetailHeadingLabel.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point);
            firstYearDetailHeadingLabel.ForeColor = Color.FromArgb(45, 137, 239);
            firstYearDetailHeadingLabel.Location = new Point(12, 70);
            firstYearDetailHeadingLabel.Name = "firstYearDetailHeadingLabel";
            firstYearDetailHeadingLabel.Size = new Size(291, 38);
            firstYearDetailHeadingLabel.TabIndex = 0;
            firstYearDetailHeadingLabel.Text = "First Year Details";
            // 
            // cgpaLabel
            // 
            cgpaLabel.AutoSize = true;
            cgpaLabel.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cgpaLabel.Location = new Point(54, 152);
            cgpaLabel.Name = "cgpaLabel";
            cgpaLabel.Size = new Size(218, 23);
            cgpaLabel.TabIndex = 1;
            cgpaLabel.Text = "CGPA                     :";
            cgpaLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cgpaValueTB
            // 
            cgpaValueTB.BackColor = Color.FromArgb(239, 244, 255);
            cgpaValueTB.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cgpaValueTB.Location = new Point(286, 152);
            cgpaValueTB.Name = "cgpaValueTB";
            cgpaValueTB.PlaceholderText = "Enter your first year CGPA";
            cgpaValueTB.Size = new Size(273, 31);
            cgpaValueTB.TabIndex = 1;
            // 
            // creditEarnedValueTB
            // 
            creditEarnedValueTB.BackColor = Color.FromArgb(239, 244, 255);
            creditEarnedValueTB.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            creditEarnedValueTB.Location = new Point(286, 189);
            creditEarnedValueTB.Name = "creditEarnedValueTB";
            creditEarnedValueTB.PlaceholderText = "Enter credit earned (/48)";
            creditEarnedValueTB.Size = new Size(273, 31);
            creditEarnedValueTB.TabIndex = 2;
            // 
            // creditEarnedLabel
            // 
            creditEarnedLabel.AutoSize = true;
            creditEarnedLabel.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            creditEarnedLabel.Location = new Point(54, 192);
            creditEarnedLabel.Name = "creditEarnedLabel";
            creditEarnedLabel.Size = new Size(219, 23);
            creditEarnedLabel.TabIndex = 3;
            creditEarnedLabel.Text = "Credit Earned          :";
            creditEarnedLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // totalMarksValueTB
            // 
            totalMarksValueTB.BackColor = Color.FromArgb(239, 244, 255);
            totalMarksValueTB.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            totalMarksValueTB.Location = new Point(286, 226);
            totalMarksValueTB.Name = "totalMarksValueTB";
            totalMarksValueTB.PlaceholderText = "Enter total marks (/1200)";
            totalMarksValueTB.Size = new Size(273, 31);
            totalMarksValueTB.TabIndex = 3;
            // 
            // totalMarksLabel
            // 
            totalMarksLabel.AutoSize = true;
            totalMarksLabel.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            totalMarksLabel.Location = new Point(54, 226);
            totalMarksLabel.Name = "totalMarksLabel";
            totalMarksLabel.Size = new Size(226, 23);
            totalMarksLabel.TabIndex = 5;
            totalMarksLabel.Text = "Total Marks             : ";
            totalMarksLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gradePointValueTB
            // 
            gradePointValueTB.BackColor = Color.FromArgb(239, 244, 255);
            gradePointValueTB.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            gradePointValueTB.Location = new Point(286, 263);
            gradePointValueTB.Name = "gradePointValueTB";
            gradePointValueTB.PlaceholderText = "Enter grade points";
            gradePointValueTB.Size = new Size(273, 31);
            gradePointValueTB.TabIndex = 4;
            // 
            // gradePointLabel
            // 
            gradePointLabel.AutoSize = true;
            gradePointLabel.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            gradePointLabel.Location = new Point(57, 266);
            gradePointLabel.Name = "gradePointLabel";
            gradePointLabel.Size = new Size(215, 23);
            gradePointLabel.TabIndex = 7;
            gradePointLabel.Text = "Grade Point            :";
            gradePointLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // earnedGradePointValueTB
            // 
            earnedGradePointValueTB.BackColor = Color.FromArgb(239, 244, 255);
            earnedGradePointValueTB.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            earnedGradePointValueTB.Location = new Point(286, 300);
            earnedGradePointValueTB.Name = "earnedGradePointValueTB";
            earnedGradePointValueTB.PlaceholderText = "Enter earned grade points";
            earnedGradePointValueTB.Size = new Size(273, 31);
            earnedGradePointValueTB.TabIndex = 5;
            // 
            // earnedGradePointLabel
            // 
            earnedGradePointLabel.AutoSize = true;
            earnedGradePointLabel.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            earnedGradePointLabel.Location = new Point(54, 303);
            earnedGradePointLabel.Name = "earnedGradePointLabel";
            earnedGradePointLabel.Size = new Size(218, 23);
            earnedGradePointLabel.TabIndex = 9;
            earnedGradePointLabel.Text = "Earned Grade Point  :";
            earnedGradePointLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(45, 137, 239);
            saveButton.FlatStyle = FlatStyle.Popup;
            saveButton.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            saveButton.ForeColor = Color.FromArgb(239, 244, 255);
            saveButton.Location = new Point(12, 12);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(110, 43);
            saveButton.TabIndex = 5;
            saveButton.Text = "Done";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // horizontalLineLabel
            // 
            horizontalLineLabel.AutoSize = true;
            horizontalLineLabel.FlatStyle = FlatStyle.Flat;
            horizontalLineLabel.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            horizontalLineLabel.Location = new Point(12, 108);
            horizontalLineLabel.Name = "horizontalLineLabel";
            horizontalLineLabel.Size = new Size(318, 23);
            horizontalLineLabel.TabIndex = 67;
            horizontalLineLabel.Text = "______________________";
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.FromArgb(185, 29, 71);
            resetButton.FlatStyle = FlatStyle.Popup;
            resetButton.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            resetButton.ForeColor = Color.FromArgb(239, 244, 255);
            resetButton.Location = new Point(514, 12);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(108, 43);
            resetButton.TabIndex = 7;
            resetButton.Text = "RESET";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // label1
            // 
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(218, 83, 44);
            label1.Location = new Point(12, 114);
            label1.Name = "label1";
            label1.Size = new Size(348, 20);
            label1.TabIndex = 72;
            label1.Text = "_________________________________________________________";
            // 
            // FYDataEntryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 244, 255);
            ClientSize = new Size(634, 381);
            Controls.Add(label1);
            Controls.Add(resetButton);
            Controls.Add(horizontalLineLabel);
            Controls.Add(saveButton);
            Controls.Add(earnedGradePointValueTB);
            Controls.Add(earnedGradePointLabel);
            Controls.Add(gradePointValueTB);
            Controls.Add(gradePointLabel);
            Controls.Add(totalMarksValueTB);
            Controls.Add(totalMarksLabel);
            Controls.Add(creditEarnedValueTB);
            Controls.Add(creditEarnedLabel);
            Controls.Add(cgpaValueTB);
            Controls.Add(cgpaLabel);
            Controls.Add(firstYearDetailHeadingLabel);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FYDataEntryForm";
            Text = "Academic Archives";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstYearDetailHeadingLabel;
        private Label cgpaLabel;
        private TextBox cgpaValueTB;
        private TextBox creditEarnedValueTB;
        private Label creditEarnedLabel;
        private TextBox totalMarksValueTB;
        private Label totalMarksLabel;
        private TextBox gradePointValueTB;
        private Label gradePointLabel;
        private TextBox earnedGradePointValueTB;
        private Label earnedGradePointLabel;
        private Button saveButton;
        private Label horizontalLineLabel;
        private Button resetButton;
        private Label label1;
    }
}