namespace _03_WP_RC_PR_WinForm
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
            modeMenuComboBox = new ComboBox();
            numberLabel = new Label();
            numberValue = new TextBox();
            calculateButton = new Button();
            evenOddLabel = new Label();
            armsLabel = new Label();
            primeCompLabel = new Label();
            numFactorialLabel = new Label();
            headingLabel = new Label();
            bottomLineLabel = new Label();
            topLineLabel = new Label();
            resetButton = new Button();
            analysisHeadingLabel = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // modeMenuComboBox
            // 
            modeMenuComboBox.BackColor = Color.FromArgb(29, 29, 29);
            modeMenuComboBox.FlatStyle = FlatStyle.Flat;
            modeMenuComboBox.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            modeMenuComboBox.ForeColor = Color.FromArgb(239, 244, 255);
            modeMenuComboBox.FormattingEnabled = true;
            modeMenuComboBox.Items.AddRange(new object[] { "All ", "Even or Odd Number", "Armstrong Number", "Prime or Composite Number", "Number Factorial " });
            modeMenuComboBox.Location = new Point(30, 60);
            modeMenuComboBox.Name = "modeMenuComboBox";
            modeMenuComboBox.Size = new Size(344, 35);
            modeMenuComboBox.TabIndex = 10;
            modeMenuComboBox.TabStop = false;
            modeMenuComboBox.SelectedIndexChanged += modeMenuComboBox_SelectedIndexChanged;
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            numberLabel.ForeColor = Color.FromArgb(239, 244, 255);
            numberLabel.Location = new Point(40, 164);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(87, 27);
            numberLabel.TabIndex = 2;
            numberLabel.Text = "Integer";
            numberLabel.Click += numberLabel_Click;
            // 
            // numberValue
            // 
            numberValue.BackColor = Color.FromArgb(29, 29, 29);
            numberValue.BorderStyle = BorderStyle.FixedSingle;
            numberValue.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            numberValue.ForeColor = Color.FromArgb(239, 244, 255);
            numberValue.Location = new Point(185, 161);
            numberValue.Name = "numberValue";
            numberValue.Size = new Size(126, 35);
            numberValue.TabIndex = 1;
            numberValue.Text = "2";
            numberValue.TextAlign = HorizontalAlignment.Center;
            numberValue.TextChanged += numberValue_TextChanged;
            numberValue.KeyPress += numberValue_KeyPress;
            // 
            // calculateButton
            // 
            calculateButton.BackColor = Color.FromArgb(45, 137, 239);
            calculateButton.FlatStyle = FlatStyle.Popup;
            calculateButton.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            calculateButton.ForeColor = Color.FromArgb(239, 244, 255);
            calculateButton.Location = new Point(155, 228);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(181, 37);
            calculateButton.TabIndex = 2;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // evenOddLabel
            // 
            evenOddLabel.AutoSize = true;
            evenOddLabel.BorderStyle = BorderStyle.FixedSingle;
            evenOddLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            evenOddLabel.ForeColor = Color.FromArgb(239, 244, 255);
            evenOddLabel.Location = new Point(54, 353);
            evenOddLabel.Name = "evenOddLabel";
            evenOddLabel.Size = new Size(141, 29);
            evenOddLabel.TabIndex = 5;
            evenOddLabel.Text = "even or odd";
            evenOddLabel.Visible = false;
            // 
            // armsLabel
            // 
            armsLabel.AutoSize = true;
            armsLabel.BorderStyle = BorderStyle.FixedSingle;
            armsLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            armsLabel.ForeColor = Color.FromArgb(239, 244, 255);
            armsLabel.Location = new Point(54, 387);
            armsLabel.Name = "armsLabel";
            armsLabel.Size = new Size(194, 29);
            armsLabel.TabIndex = 6;
            armsLabel.Text = "Armstrong or not";
            armsLabel.Visible = false;
            // 
            // primeCompLabel
            // 
            primeCompLabel.AutoSize = true;
            primeCompLabel.BorderStyle = BorderStyle.FixedSingle;
            primeCompLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            primeCompLabel.ForeColor = Color.FromArgb(239, 244, 255);
            primeCompLabel.Location = new Point(54, 422);
            primeCompLabel.Name = "primeCompLabel";
            primeCompLabel.Size = new Size(225, 29);
            primeCompLabel.TabIndex = 7;
            primeCompLabel.Text = "Prime or Composite";
            primeCompLabel.Visible = false;
            // 
            // numFactorialLabel
            // 
            numFactorialLabel.AutoSize = true;
            numFactorialLabel.BorderStyle = BorderStyle.FixedSingle;
            numFactorialLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            numFactorialLabel.ForeColor = Color.FromArgb(239, 244, 255);
            numFactorialLabel.Location = new Point(54, 457);
            numFactorialLabel.Name = "numFactorialLabel";
            numFactorialLabel.Size = new Size(244, 29);
            numFactorialLabel.TabIndex = 8;
            numFactorialLabel.Text = "Number Factorial (n!)";
            numFactorialLabel.Visible = false;
            // 
            // headingLabel
            // 
            headingLabel.AutoSize = true;
            headingLabel.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            headingLabel.ForeColor = Color.FromArgb(218, 83, 44);
            headingLabel.Location = new Point(30, 9);
            headingLabel.Name = "headingLabel";
            headingLabel.Size = new Size(236, 33);
            headingLabel.TabIndex = 0;
            headingLabel.Text = "Number Analyzer";
            headingLabel.Click += headingLabel_Click;
            // 
            // bottomLineLabel
            // 
            bottomLineLabel.AutoSize = true;
            bottomLineLabel.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            bottomLineLabel.ForeColor = Color.Black;
            bottomLineLabel.Location = new Point(12, 488);
            bottomLineLabel.Name = "bottomLineLabel";
            bottomLineLabel.Size = new Size(463, 33);
            bottomLineLabel.TabIndex = 9;
            bottomLineLabel.Text = "____________________________";
            bottomLineLabel.Click += bottomLineLabel_Click;
            // 
            // topLineLabel
            // 
            topLineLabel.AutoSize = true;
            topLineLabel.BackColor = Color.Transparent;
            topLineLabel.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            topLineLabel.Location = new Point(12, 106);
            topLineLabel.Name = "topLineLabel";
            topLineLabel.Size = new Size(463, 33);
            topLineLabel.TabIndex = 10;
            topLineLabel.Text = "____________________________";
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.FromArgb(185, 29, 71);
            resetButton.FlatStyle = FlatStyle.Popup;
            resetButton.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            resetButton.ForeColor = Color.FromArgb(239, 244, 255);
            resetButton.Location = new Point(360, 228);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(77, 37);
            resetButton.TabIndex = 3;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // analysisHeadingLabel
            // 
            analysisHeadingLabel.AutoSize = true;
            analysisHeadingLabel.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            analysisHeadingLabel.ForeColor = Color.FromArgb(0, 163, 0);
            analysisHeadingLabel.Location = new Point(30, 308);
            analysisHeadingLabel.Name = "analysisHeadingLabel";
            analysisHeadingLabel.Size = new Size(132, 32);
            analysisHeadingLabel.TabIndex = 12;
            analysisHeadingLabel.Text = "Analysis :";
            analysisHeadingLabel.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 270);
            label2.Name = "label2";
            label2.Size = new Size(463, 33);
            label2.TabIndex = 13;
            label2.Text = "____________________________";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 29, 29);
            ClientSize = new Size(499, 528);
            Controls.Add(label2);
            Controls.Add(analysisHeadingLabel);
            Controls.Add(resetButton);
            Controls.Add(topLineLabel);
            Controls.Add(bottomLineLabel);
            Controls.Add(numFactorialLabel);
            Controls.Add(primeCompLabel);
            Controls.Add(armsLabel);
            Controls.Add(evenOddLabel);
            Controls.Add(calculateButton);
            Controls.Add(numberValue);
            Controls.Add(numberLabel);
            Controls.Add(modeMenuComboBox);
            Controls.Add(headingLabel);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Number Analyzer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox modeMenuComboBox;
        private Label numberLabel;
        private TextBox numberValue;
        private Button calculateButton;
        private Label evenOddLabel;
        private Label armsLabel;
        private Label primeCompLabel;
        private Label numFactorialLabel;
        private Label headingLabel;
        private Label bottomLineLabel;
        private Label topLineLabel;
        private Button resetButton;
        private Label analysisHeadingLabel;
        private Label label2;
    }
}