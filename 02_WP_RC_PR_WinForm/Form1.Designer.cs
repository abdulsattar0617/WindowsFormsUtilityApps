namespace _02_WP_RC_PR_WinForm
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
            mainHeadingLabel = new Label();
            modeMenuComboBox = new ComboBox();
            modeHeadingLabel = new Label();
            noteLabel = new Label();
            exampleInputLabel = new Label();
            inputTextBox = new RichTextBox();
            calculateButton = new Button();
            resetButton = new Button();
            calculationLabel = new Label();
            minLabel = new Label();
            minValue = new TextBox();
            maxValue = new TextBox();
            maxLabel = new Label();
            SuspendLayout();
            // 
            // mainHeadingLabel
            // 
            mainHeadingLabel.AutoSize = true;
            mainHeadingLabel.FlatStyle = FlatStyle.Flat;
            mainHeadingLabel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            mainHeadingLabel.ForeColor = Color.Tomato;
            mainHeadingLabel.Location = new Point(12, 5);
            mainHeadingLabel.Name = "mainHeadingLabel";
            mainHeadingLabel.Size = new Size(216, 29);
            mainHeadingLabel.TabIndex = 10;
            mainHeadingLabel.Text = "Boundary Tracker";
            // 
            // modeMenuComboBox
            // 
            modeMenuComboBox.BackColor = Color.FromArgb(29, 29, 29);
            modeMenuComboBox.FlatStyle = FlatStyle.Flat;
            modeMenuComboBox.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            modeMenuComboBox.ForeColor = Color.FromArgb(239, 244, 255);
            modeMenuComboBox.FormattingEnabled = true;
            modeMenuComboBox.Items.AddRange(new object[] { "Min", "Max", "Both" });
            modeMenuComboBox.Location = new Point(35, 52);
            modeMenuComboBox.Name = "modeMenuComboBox";
            modeMenuComboBox.RightToLeft = RightToLeft.No;
            modeMenuComboBox.Size = new Size(121, 32);
            modeMenuComboBox.TabIndex = 5;
            modeMenuComboBox.TabStop = false;
            modeMenuComboBox.SelectedIndexChanged += modeMenuComboBox_SelectedIndexChanged;
            // 
            // modeHeadingLabel
            // 
            modeHeadingLabel.AutoSize = true;
            modeHeadingLabel.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            modeHeadingLabel.ForeColor = Color.FromArgb(239, 244, 255);
            modeHeadingLabel.Location = new Point(29, 101);
            modeHeadingLabel.Name = "modeHeadingLabel";
            modeHeadingLabel.Size = new Size(222, 36);
            modeHeadingLabel.TabIndex = 10;
            modeHeadingLabel.Text = "mode_heading";
            modeHeadingLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.FlatStyle = FlatStyle.Flat;
            noteLabel.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            noteLabel.ForeColor = Color.FromArgb(239, 244, 255);
            noteLabel.Location = new Point(35, 155);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new Size(453, 16);
            noteLabel.TabIndex = 3;
            noteLabel.Text = "For calculation, please enter numerical data separated with comma or space.";
            // 
            // exampleInputLabel
            // 
            exampleInputLabel.AutoSize = true;
            exampleInputLabel.FlatStyle = FlatStyle.Flat;
            exampleInputLabel.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            exampleInputLabel.ForeColor = Color.FromArgb(45, 137, 239);
            exampleInputLabel.Location = new Point(35, 178);
            exampleInputLabel.Name = "exampleInputLabel";
            exampleInputLabel.Size = new Size(236, 16);
            exampleInputLabel.TabIndex = 4;
            exampleInputLabel.Text = "For example: 1, 2, 3, 4, 5  OR 1 2 3 4 5";
            exampleInputLabel.Click += label1_Click;
            // 
            // inputTextBox
            // 
            inputTextBox.BackColor = Color.FromArgb(29, 29, 29);
            inputTextBox.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            inputTextBox.ForeColor = Color.FromArgb(239, 244, 255);
            inputTextBox.Location = new Point(35, 209);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(453, 90);
            inputTextBox.TabIndex = 1;
            inputTextBox.Text = "Click Reset and enter number data set separated by space or comma";
            inputTextBox.KeyPress += inputTextBox_KeyPress;
            // 
            // calculateButton
            // 
            calculateButton.BackColor = Color.FromArgb(45, 137, 239);
            calculateButton.FlatStyle = FlatStyle.Popup;
            calculateButton.ForeColor = Color.FromArgb(239, 244, 255);
            calculateButton.Location = new Point(35, 325);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(107, 34);
            calculateButton.TabIndex = 2;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.FromArgb(45, 137, 239);
            resetButton.FlatStyle = FlatStyle.Popup;
            resetButton.ForeColor = Color.FromArgb(239, 244, 255);
            resetButton.Location = new Point(165, 325);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(70, 34);
            resetButton.TabIndex = 3;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // calculationLabel
            // 
            calculationLabel.AutoSize = true;
            calculationLabel.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            calculationLabel.ForeColor = Color.FromArgb(239, 244, 255);
            calculationLabel.Location = new Point(35, 383);
            calculationLabel.Name = "calculationLabel";
            calculationLabel.Size = new Size(160, 33);
            calculationLabel.TabIndex = 7;
            calculationLabel.Text = "Calculation";
            calculationLabel.Visible = false;
            // 
            // minLabel
            // 
            minLabel.AutoSize = true;
            minLabel.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            minLabel.ForeColor = Color.FromArgb(239, 244, 255);
            minLabel.Location = new Point(61, 425);
            minLabel.Name = "minLabel";
            minLabel.Size = new Size(95, 22);
            minLabel.TabIndex = 8;
            minLabel.Text = "Minimum :";
            minLabel.TextAlign = ContentAlignment.TopRight;
            minLabel.Visible = false;
            minLabel.Click += label1_Click_1;
            // 
            // minValue
            // 
            minValue.BackColor = Color.FromArgb(29, 29, 29);
            minValue.BorderStyle = BorderStyle.None;
            minValue.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            minValue.ForeColor = Color.FromArgb(239, 244, 255);
            minValue.Location = new Point(162, 426);
            minValue.Name = "minValue";
            minValue.ReadOnly = true;
            minValue.Size = new Size(137, 22);
            minValue.TabIndex = 9;
            minValue.TabStop = false;
            minValue.Text = "min_value";
            minValue.Visible = false;
            // 
            // maxValue
            // 
            maxValue.BackColor = Color.FromArgb(29, 29, 29);
            maxValue.BorderStyle = BorderStyle.None;
            maxValue.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            maxValue.ForeColor = Color.FromArgb(239, 244, 255);
            maxValue.Location = new Point(162, 461);
            maxValue.Name = "maxValue";
            maxValue.ReadOnly = true;
            maxValue.Size = new Size(137, 22);
            maxValue.TabIndex = 11;
            maxValue.TabStop = false;
            maxValue.Text = "min_value";
            maxValue.Visible = false;
            maxValue.TextChanged += maxValue_TextChanged;
            // 
            // maxLabel
            // 
            maxLabel.AutoSize = true;
            maxLabel.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            maxLabel.ForeColor = Color.FromArgb(239, 244, 255);
            maxLabel.Location = new Point(56, 460);
            maxLabel.Name = "maxLabel";
            maxLabel.Size = new Size(100, 22);
            maxLabel.TabIndex = 10;
            maxLabel.Text = "Maximum :";
            maxLabel.TextAlign = ContentAlignment.TopRight;
            maxLabel.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 29, 29);
            ClientSize = new Size(524, 511);
            Controls.Add(maxValue);
            Controls.Add(maxLabel);
            Controls.Add(minValue);
            Controls.Add(minLabel);
            Controls.Add(calculationLabel);
            Controls.Add(resetButton);
            Controls.Add(calculateButton);
            Controls.Add(inputTextBox);
            Controls.Add(exampleInputLabel);
            Controls.Add(noteLabel);
            Controls.Add(modeHeadingLabel);
            Controls.Add(modeMenuComboBox);
            Controls.Add(mainHeadingLabel);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Boundary Tracker";
            KeyDown += Form1_KeyDown;
            KeyPress += Form1_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainHeadingLabel;
        private ComboBox modeMenuComboBox;
        private Label modeHeadingLabel;
        private Label noteLabel;
        private Label exampleInputLabel;
        private RichTextBox inputTextBox;
        private Button calculateButton;
        private Button resetButton;
        private Label calculationLabel;
        private Label minLabel;
        private TextBox minValue;
        private TextBox maxValue;
        private Label maxLabel;
    }
}