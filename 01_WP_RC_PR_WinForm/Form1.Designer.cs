namespace _01_WP_RC_PR_WinForm
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
            headingLabel = new Label();
            expressionTextBox = new TextBox();
            inputTextBox = new TextBox();
            moduloButton = new Button();
            ceButton = new Button();
            removeButton = new Button();
            cButton = new Button();
            xSquareRootButton = new Button();
            divideButton = new Button();
            xSquareButton = new Button();
            oneByXButton = new Button();
            sixButton = new Button();
            minusButton = new Button();
            fiveButton = new Button();
            fourButton = new Button();
            nineButton = new Button();
            multiplyButton = new Button();
            eightButton = new Button();
            sevenButton = new Button();
            dotButton = new Button();
            equalButton = new Button();
            zeroButton = new Button();
            signChangeButton = new Button();
            threeButton = new Button();
            plusButton = new Button();
            twoButton = new Button();
            oneButton = new Button();
            SuspendLayout();
            // 
            // headingLabel
            // 
            headingLabel.AutoSize = true;
            headingLabel.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            headingLabel.ForeColor = Color.White;
            headingLabel.Location = new Point(12, 9);
            headingLabel.Name = "headingLabel";
            headingLabel.Size = new Size(121, 29);
            headingLabel.TabIndex = 0;
            headingLabel.Text = "Standard";
            headingLabel.Click += label1_Click;
            // 
            // expressionTextBox
            // 
            expressionTextBox.BackColor = Color.FromArgb(32, 32, 32);
            expressionTextBox.BorderStyle = BorderStyle.None;
            expressionTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            expressionTextBox.ForeColor = Color.FromArgb(136, 136, 136);
            expressionTextBox.Location = new Point(12, 42);
            expressionTextBox.Name = "expressionTextBox";
            expressionTextBox.ReadOnly = true;
            expressionTextBox.RightToLeft = RightToLeft.Yes;
            expressionTextBox.Size = new Size(279, 19);
            expressionTextBox.TabIndex = 2;
            expressionTextBox.TabStop = false;
            // 
            // inputTextBox
            // 
            inputTextBox.BackColor = Color.FromArgb(32, 32, 32);
            inputTextBox.BorderStyle = BorderStyle.None;
            inputTextBox.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            inputTextBox.ForeColor = Color.White;
            inputTextBox.Location = new Point(3, 75);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.PlaceholderText = "0";
            inputTextBox.RightToLeft = RightToLeft.Yes;
            inputTextBox.Size = new Size(288, 56);
            inputTextBox.TabIndex = 1;
            inputTextBox.TabStop = false;
            inputTextBox.KeyDown += inputTextBox_KeyDown;
            inputTextBox.KeyPress += inputTextBox_KeyPress;
            // 
            // moduloButton
            // 
            moduloButton.BackColor = Color.FromArgb(48, 48, 48);
            moduloButton.Cursor = Cursors.No;
            moduloButton.FlatStyle = FlatStyle.Popup;
            moduloButton.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            moduloButton.ForeColor = Color.White;
            moduloButton.Location = new Point(3, 179);
            moduloButton.Name = "moduloButton";
            moduloButton.Size = new Size(77, 49);
            moduloButton.TabIndex = 3;
            moduloButton.TabStop = false;
            moduloButton.Text = "%";
            moduloButton.UseVisualStyleBackColor = false;
            moduloButton.Click += moduloButton_Click;
            // 
            // ceButton
            // 
            ceButton.BackColor = Color.FromArgb(48, 48, 48);
            ceButton.Cursor = Cursors.No;
            ceButton.FlatStyle = FlatStyle.Popup;
            ceButton.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ceButton.ForeColor = Color.White;
            ceButton.Location = new Point(80, 179);
            ceButton.Name = "ceButton";
            ceButton.Size = new Size(77, 49);
            ceButton.TabIndex = 4;
            ceButton.TabStop = false;
            ceButton.Text = "CE";
            ceButton.UseVisualStyleBackColor = false;
            ceButton.Click += ceButton_Click;
            // 
            // removeButton
            // 
            removeButton.BackColor = Color.FromArgb(48, 48, 48);
            removeButton.Cursor = Cursors.No;
            removeButton.FlatStyle = FlatStyle.Popup;
            removeButton.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            removeButton.ForeColor = Color.White;
            removeButton.Location = new Point(234, 179);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(77, 49);
            removeButton.TabIndex = 5;
            removeButton.TabStop = false;
            removeButton.Text = "⌫";
            removeButton.UseVisualStyleBackColor = false;
            removeButton.Click += removeButton_Click;
            // 
            // cButton
            // 
            cButton.BackColor = Color.FromArgb(48, 48, 48);
            cButton.Cursor = Cursors.No;
            cButton.FlatStyle = FlatStyle.Popup;
            cButton.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cButton.ForeColor = Color.White;
            cButton.Location = new Point(157, 179);
            cButton.Name = "cButton";
            cButton.Size = new Size(77, 49);
            cButton.TabIndex = 6;
            cButton.TabStop = false;
            cButton.Text = "C";
            cButton.UseVisualStyleBackColor = false;
            cButton.Click += cButton_Click;
            // 
            // xSquareRootButton
            // 
            xSquareRootButton.BackColor = Color.FromArgb(48, 48, 48);
            xSquareRootButton.Cursor = Cursors.No;
            xSquareRootButton.FlatStyle = FlatStyle.Popup;
            xSquareRootButton.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            xSquareRootButton.ForeColor = Color.White;
            xSquareRootButton.Location = new Point(157, 228);
            xSquareRootButton.Name = "xSquareRootButton";
            xSquareRootButton.Size = new Size(77, 49);
            xSquareRootButton.TabIndex = 10;
            xSquareRootButton.TabStop = false;
            xSquareRootButton.Text = "√x";
            xSquareRootButton.UseVisualStyleBackColor = false;
            xSquareRootButton.Click += xSquareRootButton_Click;
            // 
            // divideButton
            // 
            divideButton.BackColor = Color.FromArgb(48, 48, 48);
            divideButton.Cursor = Cursors.No;
            divideButton.FlatStyle = FlatStyle.Popup;
            divideButton.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            divideButton.ForeColor = Color.White;
            divideButton.Location = new Point(234, 228);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(77, 49);
            divideButton.TabIndex = 9;
            divideButton.TabStop = false;
            divideButton.Text = "÷";
            divideButton.UseVisualStyleBackColor = false;
            divideButton.Click += divideButton_Click;
            // 
            // xSquareButton
            // 
            xSquareButton.BackColor = Color.FromArgb(48, 48, 48);
            xSquareButton.Cursor = Cursors.No;
            xSquareButton.FlatStyle = FlatStyle.Popup;
            xSquareButton.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            xSquareButton.ForeColor = Color.White;
            xSquareButton.Location = new Point(80, 228);
            xSquareButton.Name = "xSquareButton";
            xSquareButton.Size = new Size(77, 49);
            xSquareButton.TabIndex = 8;
            xSquareButton.TabStop = false;
            xSquareButton.Text = "x²";
            xSquareButton.UseVisualStyleBackColor = false;
            xSquareButton.Click += xSquareButton_Click;
            // 
            // oneByXButton
            // 
            oneByXButton.BackColor = Color.FromArgb(48, 48, 48);
            oneByXButton.Cursor = Cursors.No;
            oneByXButton.FlatStyle = FlatStyle.Popup;
            oneByXButton.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            oneByXButton.ForeColor = Color.White;
            oneByXButton.Location = new Point(3, 228);
            oneByXButton.Name = "oneByXButton";
            oneByXButton.Size = new Size(77, 49);
            oneByXButton.TabIndex = 7;
            oneByXButton.TabStop = false;
            oneByXButton.Text = "1/x";
            oneByXButton.UseVisualStyleBackColor = false;
            oneByXButton.Click += oneByXButton_Click;
            // 
            // sixButton
            // 
            sixButton.BackColor = Color.FromArgb(64, 64, 64);
            sixButton.Cursor = Cursors.No;
            sixButton.FlatStyle = FlatStyle.Popup;
            sixButton.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            sixButton.ForeColor = Color.White;
            sixButton.Location = new Point(157, 326);
            sixButton.Name = "sixButton";
            sixButton.Size = new Size(77, 49);
            sixButton.TabIndex = 18;
            sixButton.TabStop = false;
            sixButton.Text = "6";
            sixButton.UseVisualStyleBackColor = false;
            sixButton.Click += sixButton_Click;
            // 
            // minusButton
            // 
            minusButton.BackColor = Color.FromArgb(48, 48, 48);
            minusButton.Cursor = Cursors.No;
            minusButton.FlatStyle = FlatStyle.Popup;
            minusButton.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            minusButton.ForeColor = Color.White;
            minusButton.Location = new Point(234, 326);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(77, 49);
            minusButton.TabIndex = 17;
            minusButton.TabStop = false;
            minusButton.Text = "-";
            minusButton.UseVisualStyleBackColor = false;
            minusButton.Click += minusButton_Click;
            // 
            // fiveButton
            // 
            fiveButton.BackColor = Color.FromArgb(64, 64, 64);
            fiveButton.Cursor = Cursors.No;
            fiveButton.FlatStyle = FlatStyle.Popup;
            fiveButton.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            fiveButton.ForeColor = Color.White;
            fiveButton.Location = new Point(80, 326);
            fiveButton.Name = "fiveButton";
            fiveButton.Size = new Size(77, 49);
            fiveButton.TabIndex = 16;
            fiveButton.TabStop = false;
            fiveButton.Text = "5";
            fiveButton.UseVisualStyleBackColor = false;
            fiveButton.Click += fiveButton_Click;
            // 
            // fourButton
            // 
            fourButton.BackColor = Color.FromArgb(64, 64, 64);
            fourButton.Cursor = Cursors.No;
            fourButton.FlatStyle = FlatStyle.Popup;
            fourButton.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            fourButton.ForeColor = Color.White;
            fourButton.Location = new Point(3, 326);
            fourButton.Name = "fourButton";
            fourButton.Size = new Size(77, 49);
            fourButton.TabIndex = 15;
            fourButton.TabStop = false;
            fourButton.Text = "4";
            fourButton.UseVisualStyleBackColor = false;
            fourButton.Click += fourButton_Click;
            // 
            // nineButton
            // 
            nineButton.BackColor = Color.FromArgb(64, 64, 64);
            nineButton.Cursor = Cursors.No;
            nineButton.FlatStyle = FlatStyle.Popup;
            nineButton.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nineButton.ForeColor = Color.White;
            nineButton.Location = new Point(157, 277);
            nineButton.Name = "nineButton";
            nineButton.Size = new Size(77, 49);
            nineButton.TabIndex = 14;
            nineButton.TabStop = false;
            nineButton.Text = "9";
            nineButton.UseVisualStyleBackColor = false;
            nineButton.Click += nineButton_Click;
            // 
            // multiplyButton
            // 
            multiplyButton.BackColor = Color.FromArgb(48, 48, 48);
            multiplyButton.Cursor = Cursors.No;
            multiplyButton.FlatStyle = FlatStyle.Popup;
            multiplyButton.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            multiplyButton.ForeColor = Color.White;
            multiplyButton.Location = new Point(234, 277);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(77, 49);
            multiplyButton.TabIndex = 13;
            multiplyButton.TabStop = false;
            multiplyButton.Text = "×";
            multiplyButton.UseVisualStyleBackColor = false;
            multiplyButton.Click += multiplyButton_Click;
            // 
            // eightButton
            // 
            eightButton.BackColor = Color.FromArgb(64, 64, 64);
            eightButton.Cursor = Cursors.No;
            eightButton.FlatStyle = FlatStyle.Popup;
            eightButton.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            eightButton.ForeColor = Color.White;
            eightButton.Location = new Point(80, 277);
            eightButton.Name = "eightButton";
            eightButton.Size = new Size(77, 49);
            eightButton.TabIndex = 12;
            eightButton.TabStop = false;
            eightButton.Text = "8";
            eightButton.UseVisualStyleBackColor = false;
            eightButton.Click += eightButton_Click;
            // 
            // sevenButton
            // 
            sevenButton.BackColor = Color.FromArgb(64, 64, 64);
            sevenButton.Cursor = Cursors.No;
            sevenButton.FlatStyle = FlatStyle.Popup;
            sevenButton.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            sevenButton.ForeColor = Color.White;
            sevenButton.Location = new Point(3, 277);
            sevenButton.Name = "sevenButton";
            sevenButton.Size = new Size(77, 49);
            sevenButton.TabIndex = 11;
            sevenButton.TabStop = false;
            sevenButton.Text = "7";
            sevenButton.UseVisualStyleBackColor = false;
            sevenButton.Click += sevenButton_Click;
            // 
            // dotButton
            // 
            dotButton.BackColor = Color.FromArgb(64, 64, 64);
            dotButton.Cursor = Cursors.No;
            dotButton.FlatStyle = FlatStyle.Popup;
            dotButton.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dotButton.ForeColor = Color.White;
            dotButton.Location = new Point(157, 424);
            dotButton.Name = "dotButton";
            dotButton.Size = new Size(77, 49);
            dotButton.TabIndex = 26;
            dotButton.TabStop = false;
            dotButton.Text = ".";
            dotButton.UseVisualStyleBackColor = false;
            dotButton.Click += dotButton_Click;
            // 
            // equalButton
            // 
            equalButton.BackColor = Color.FromArgb(102, 179, 255);
            equalButton.FlatStyle = FlatStyle.Popup;
            equalButton.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            equalButton.ForeColor = Color.FromArgb(32, 32, 32);
            equalButton.Location = new Point(234, 424);
            equalButton.Name = "equalButton";
            equalButton.Size = new Size(77, 49);
            equalButton.TabIndex = 1;
            equalButton.Text = "=";
            equalButton.UseVisualStyleBackColor = false;
            equalButton.Click += equalButton_Click;
            // 
            // zeroButton
            // 
            zeroButton.BackColor = Color.FromArgb(64, 64, 64);
            zeroButton.Cursor = Cursors.No;
            zeroButton.FlatStyle = FlatStyle.Popup;
            zeroButton.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            zeroButton.ForeColor = Color.White;
            zeroButton.Location = new Point(80, 424);
            zeroButton.Name = "zeroButton";
            zeroButton.Size = new Size(77, 49);
            zeroButton.TabIndex = 24;
            zeroButton.TabStop = false;
            zeroButton.Text = "0";
            zeroButton.UseVisualStyleBackColor = false;
            zeroButton.Click += zeroButton_Click;
            // 
            // signChangeButton
            // 
            signChangeButton.BackColor = Color.FromArgb(64, 64, 64);
            signChangeButton.Cursor = Cursors.No;
            signChangeButton.FlatStyle = FlatStyle.Popup;
            signChangeButton.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            signChangeButton.ForeColor = Color.White;
            signChangeButton.Location = new Point(3, 424);
            signChangeButton.Name = "signChangeButton";
            signChangeButton.Size = new Size(77, 49);
            signChangeButton.TabIndex = 23;
            signChangeButton.TabStop = false;
            signChangeButton.Text = "+/-";
            signChangeButton.UseVisualStyleBackColor = false;
            signChangeButton.Click += signChangeButton_Click;
            // 
            // threeButton
            // 
            threeButton.BackColor = Color.FromArgb(64, 64, 64);
            threeButton.Cursor = Cursors.No;
            threeButton.FlatStyle = FlatStyle.Popup;
            threeButton.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            threeButton.ForeColor = Color.White;
            threeButton.Location = new Point(157, 375);
            threeButton.Name = "threeButton";
            threeButton.Size = new Size(77, 49);
            threeButton.TabIndex = 22;
            threeButton.TabStop = false;
            threeButton.Text = "3";
            threeButton.UseVisualStyleBackColor = false;
            threeButton.Click += threeButton_Click;
            // 
            // plusButton
            // 
            plusButton.BackColor = Color.FromArgb(48, 48, 48);
            plusButton.Cursor = Cursors.No;
            plusButton.FlatStyle = FlatStyle.Popup;
            plusButton.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            plusButton.ForeColor = Color.White;
            plusButton.Location = new Point(234, 375);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(77, 49);
            plusButton.TabIndex = 21;
            plusButton.TabStop = false;
            plusButton.Text = "+";
            plusButton.UseVisualStyleBackColor = false;
            plusButton.Click += plusButton_Click;
            // 
            // twoButton
            // 
            twoButton.BackColor = Color.FromArgb(64, 64, 64);
            twoButton.Cursor = Cursors.No;
            twoButton.FlatStyle = FlatStyle.Popup;
            twoButton.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            twoButton.ForeColor = Color.White;
            twoButton.Location = new Point(80, 375);
            twoButton.Name = "twoButton";
            twoButton.Size = new Size(77, 49);
            twoButton.TabIndex = 20;
            twoButton.TabStop = false;
            twoButton.Text = "2";
            twoButton.UseVisualStyleBackColor = false;
            twoButton.Click += twoButton_Click;
            // 
            // oneButton
            // 
            oneButton.BackColor = Color.FromArgb(64, 64, 64);
            oneButton.Cursor = Cursors.No;
            oneButton.FlatStyle = FlatStyle.Popup;
            oneButton.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            oneButton.ForeColor = Color.White;
            oneButton.Location = new Point(3, 375);
            oneButton.Name = "oneButton";
            oneButton.Size = new Size(77, 49);
            oneButton.TabIndex = 19;
            oneButton.TabStop = false;
            oneButton.Text = "1";
            oneButton.UseVisualStyleBackColor = false;
            oneButton.Click += oneButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(314, 476);
            Controls.Add(dotButton);
            Controls.Add(equalButton);
            Controls.Add(zeroButton);
            Controls.Add(signChangeButton);
            Controls.Add(threeButton);
            Controls.Add(plusButton);
            Controls.Add(twoButton);
            Controls.Add(oneButton);
            Controls.Add(sixButton);
            Controls.Add(minusButton);
            Controls.Add(fiveButton);
            Controls.Add(fourButton);
            Controls.Add(nineButton);
            Controls.Add(multiplyButton);
            Controls.Add(eightButton);
            Controls.Add(sevenButton);
            Controls.Add(xSquareRootButton);
            Controls.Add(divideButton);
            Controls.Add(xSquareButton);
            Controls.Add(oneByXButton);
            Controls.Add(cButton);
            Controls.Add(removeButton);
            Controls.Add(ceButton);
            Controls.Add(moduloButton);
            Controls.Add(inputTextBox);
            Controls.Add(expressionTextBox);
            Controls.Add(headingLabel);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyPress += Form1_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headingLabel;
        private TextBox expressionTextBox;
        private TextBox inputTextBox;
        private Button moduloButton;
        private Button ceButton;
        private Button removeButton;
        private Button cButton;
        private Button xSquareRootButton;
        private Button divideButton;
        private Button xSquareButton;
        private Button oneByXButton;
        private Button sixButton;
        private Button minusButton;
        private Button fiveButton;
        private Button fourButton;
        private Button nineButton;
        private Button multiplyButton;
        private Button eightButton;
        private Button sevenButton;
        private Button dotButton;
        private Button equalButton;
        private Button zeroButton;
        private Button signChangeButton;
        private Button threeButton;
        private Button plusButton;
        private Button twoButton;
        private Button oneButton;
    }
}