namespace _04_WP_RC_PR_WinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            previousMarksheetCB = new ComboBox();
            nameLabel = new Label();
            nameValueTB = new TextBox();
            prnNoValueTB = new TextBox();
            prnNoLabel = new Label();
            seatNoValueTB = new TextBox();
            seatNoLabel = new Label();
            abcIdValueTB = new TextBox();
            abcIdLabel = new Label();
            enterMarksButton = new Button();
            genMarksheetButton = new Button();
            fyDetailButton = new Button();
            resetButton = new Button();
            basicInfoHeadingLabel = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // previousMarksheetCB
            // 
            previousMarksheetCB.BackColor = Color.FromArgb(239, 244, 255);
            previousMarksheetCB.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            previousMarksheetCB.ForeColor = Color.FromArgb(218, 83, 44);
            previousMarksheetCB.FormattingEnabled = true;
            previousMarksheetCB.Location = new Point(270, 12);
            previousMarksheetCB.Name = "previousMarksheetCB";
            previousMarksheetCB.Size = new Size(298, 30);
            previousMarksheetCB.TabIndex = 10;
            previousMarksheetCB.TabStop = false;
            previousMarksheetCB.Text = "  PREVIOUS MARKSHEETS";
            previousMarksheetCB.SelectedIndexChanged += previousMarksheetCB_SelectedIndexChanged;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.ForeColor = Color.FromArgb(29, 29, 29);
            nameLabel.Location = new Point(91, 125);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(70, 22);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name :";
            nameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // nameValueTB
            // 
            nameValueTB.BackColor = Color.FromArgb(239, 244, 255);
            nameValueTB.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nameValueTB.ForeColor = Color.FromArgb(29, 29, 29);
            nameValueTB.Location = new Point(180, 122);
            nameValueTB.Name = "nameValueTB";
            nameValueTB.PlaceholderText = "Enter your full name";
            nameValueTB.Size = new Size(344, 29);
            nameValueTB.TabIndex = 1;
            // 
            // prnNoValueTB
            // 
            prnNoValueTB.BackColor = Color.FromArgb(239, 244, 255);
            prnNoValueTB.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            prnNoValueTB.ForeColor = Color.FromArgb(29, 29, 29);
            prnNoValueTB.Location = new Point(180, 172);
            prnNoValueTB.Name = "prnNoValueTB";
            prnNoValueTB.PlaceholderText = "Enter your PRN number";
            prnNoValueTB.Size = new Size(344, 29);
            prnNoValueTB.TabIndex = 2;
            // 
            // prnNoLabel
            // 
            prnNoLabel.AutoSize = true;
            prnNoLabel.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            prnNoLabel.ForeColor = Color.FromArgb(29, 29, 29);
            prnNoLabel.Location = new Point(72, 175);
            prnNoLabel.Name = "prnNoLabel";
            prnNoLabel.Size = new Size(89, 22);
            prnNoLabel.TabIndex = 4;
            prnNoLabel.Text = "PRN No :";
            prnNoLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // seatNoValueTB
            // 
            seatNoValueTB.BackColor = Color.FromArgb(239, 244, 255);
            seatNoValueTB.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            seatNoValueTB.ForeColor = Color.FromArgb(29, 29, 29);
            seatNoValueTB.Location = new Point(180, 222);
            seatNoValueTB.Name = "seatNoValueTB";
            seatNoValueTB.PlaceholderText = "Enter your seat number";
            seatNoValueTB.Size = new Size(344, 29);
            seatNoValueTB.TabIndex = 3;
            // 
            // seatNoLabel
            // 
            seatNoLabel.AutoSize = true;
            seatNoLabel.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            seatNoLabel.ForeColor = Color.FromArgb(29, 29, 29);
            seatNoLabel.Location = new Point(72, 225);
            seatNoLabel.Name = "seatNoLabel";
            seatNoLabel.Size = new Size(88, 22);
            seatNoLabel.TabIndex = 6;
            seatNoLabel.Text = "Seat No :";
            seatNoLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // abcIdValueTB
            // 
            abcIdValueTB.BackColor = Color.FromArgb(239, 244, 255);
            abcIdValueTB.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            abcIdValueTB.ForeColor = Color.FromArgb(29, 29, 29);
            abcIdValueTB.Location = new Point(180, 272);
            abcIdValueTB.Name = "abcIdValueTB";
            abcIdValueTB.PlaceholderText = "Enter your ABC Id";
            abcIdValueTB.Size = new Size(344, 29);
            abcIdValueTB.TabIndex = 4;
            // 
            // abcIdLabel
            // 
            abcIdLabel.AutoSize = true;
            abcIdLabel.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            abcIdLabel.ForeColor = Color.FromArgb(29, 29, 29);
            abcIdLabel.Location = new Point(76, 275);
            abcIdLabel.Name = "abcIdLabel";
            abcIdLabel.Size = new Size(85, 22);
            abcIdLabel.TabIndex = 8;
            abcIdLabel.Text = "ABC ID :";
            abcIdLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // enterMarksButton
            // 
            enterMarksButton.BackColor = Color.FromArgb(68, 142, 228);
            enterMarksButton.FlatStyle = FlatStyle.Popup;
            enterMarksButton.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            enterMarksButton.ForeColor = Color.FromArgb(239, 244, 255);
            enterMarksButton.Location = new Point(347, 332);
            enterMarksButton.Name = "enterMarksButton";
            enterMarksButton.Size = new Size(177, 36);
            enterMarksButton.TabIndex = 6;
            enterMarksButton.Text = "Enter Marks";
            enterMarksButton.UseVisualStyleBackColor = false;
            enterMarksButton.Click += enterMarksButton_Click;
            // 
            // genMarksheetButton
            // 
            genMarksheetButton.BackColor = Color.FromArgb(45, 137, 239);
            genMarksheetButton.FlatStyle = FlatStyle.Popup;
            genMarksheetButton.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            genMarksheetButton.ForeColor = Color.FromArgb(239, 244, 255);
            genMarksheetButton.Location = new Point(104, 390);
            genMarksheetButton.Name = "genMarksheetButton";
            genMarksheetButton.Size = new Size(420, 47);
            genMarksheetButton.TabIndex = 7;
            genMarksheetButton.Text = "Generate Marksheet";
            genMarksheetButton.UseVisualStyleBackColor = false;
            genMarksheetButton.Click += genMarksheetButton_Click;
            // 
            // fyDetailButton
            // 
            fyDetailButton.BackColor = Color.FromArgb(68, 142, 228);
            fyDetailButton.FlatStyle = FlatStyle.Popup;
            fyDetailButton.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            fyDetailButton.ForeColor = Color.FromArgb(239, 244, 255);
            fyDetailButton.Location = new Point(104, 332);
            fyDetailButton.Name = "fyDetailButton";
            fyDetailButton.Size = new Size(177, 36);
            fyDetailButton.TabIndex = 5;
            fyDetailButton.Text = "FY Details";
            fyDetailButton.UseVisualStyleBackColor = false;
            fyDetailButton.Click += fyDetailButton_Click;
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.FromArgb(185, 29, 71);
            resetButton.FlatStyle = FlatStyle.Popup;
            resetButton.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            resetButton.ForeColor = Color.FromArgb(239, 244, 255);
            resetButton.Location = new Point(391, 50);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(177, 36);
            resetButton.TabIndex = 8;
            resetButton.Text = "RESET";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // basicInfoHeadingLabel
            // 
            basicInfoHeadingLabel.AutoSize = true;
            basicInfoHeadingLabel.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            basicInfoHeadingLabel.ForeColor = Color.FromArgb(45, 137, 239);
            basicInfoHeadingLabel.Location = new Point(21, 52);
            basicInfoHeadingLabel.Name = "basicInfoHeadingLabel";
            basicInfoHeadingLabel.Size = new Size(260, 34);
            basicInfoHeadingLabel.TabIndex = 0;
            basicInfoHeadingLabel.Text = "Basic Information";
            // 
            // label1
            // 
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(218, 83, 44);
            label1.Location = new Point(21, 84);
            label1.Name = "label1";
            label1.Size = new Size(348, 20);
            label1.TabIndex = 73;
            label1.Text = "_________________________________________________________";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 244, 255);
            ClientSize = new Size(626, 460);
            Controls.Add(label1);
            Controls.Add(resetButton);
            Controls.Add(genMarksheetButton);
            Controls.Add(enterMarksButton);
            Controls.Add(fyDetailButton);
            Controls.Add(abcIdValueTB);
            Controls.Add(abcIdLabel);
            Controls.Add(seatNoValueTB);
            Controls.Add(seatNoLabel);
            Controls.Add(prnNoValueTB);
            Controls.Add(prnNoLabel);
            Controls.Add(nameValueTB);
            Controls.Add(nameLabel);
            Controls.Add(previousMarksheetCB);
            Controls.Add(basicInfoHeadingLabel);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Academic Archives";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox previousMarksheetCB;
        private Label nameLabel;
        private TextBox nameValueTB;
        private TextBox prnNoValueTB;
        private Label prnNoLabel;
        private TextBox seatNoValueTB;
        private Label seatNoLabel;
        private TextBox abcIdValueTB;
        private Label abcIdLabel;
        private Button enterMarksButton;
        private Button genMarksheetButton;
        private Button fyDetailButton;
        private Button resetButton;
        private Label basicInfoHeadingLabel;
        private Label label1;
    }
}