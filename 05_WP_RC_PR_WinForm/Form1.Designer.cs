namespace _05_WP_RC_PR_WinForm
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
            nameLabel = new Label();
            nameValueTB = new TextBox();
            emailValueTB = new TextBox();
            emailLabel = new Label();
            runningReadingValueTB = new TextBox();
            runningReadingLabel = new Label();
            consumedUnitValueTB = new TextBox();
            consumedUnitLabel = new Label();
            resetButton = new Button();
            calculateBillButton = new Button();
            billButton = new Button();
            billingButton = new Button();
            previousBillCB = new ComboBox();
            addressLabel = new Label();
            addressValueTB = new RichTextBox();
            phoneNumberValueTB = new TextBox();
            phoneNumberLabel = new Label();
            rightPictureBox = new PictureBox();
            appLogoPictureBox = new PictureBox();
            msebHeadingLabel = new Label();
            label17 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)appLogoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(56, 112);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(160, 22);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name                   :";
            // 
            // nameValueTB
            // 
            nameValueTB.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameValueTB.Location = new Point(228, 112);
            nameValueTB.Name = "nameValueTB";
            nameValueTB.Size = new Size(267, 26);
            nameValueTB.TabIndex = 1;
            // 
            // emailValueTB
            // 
            emailValueTB.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailValueTB.Location = new Point(228, 200);
            emailValueTB.Name = "emailValueTB";
            emailValueTB.Size = new Size(267, 26);
            emailValueTB.TabIndex = 5;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.Location = new Point(55, 200);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(162, 22);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email                    :";
            // 
            // runningReadingValueTB
            // 
            runningReadingValueTB.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            runningReadingValueTB.Location = new Point(228, 242);
            runningReadingValueTB.Name = "runningReadingValueTB";
            runningReadingValueTB.Size = new Size(267, 26);
            runningReadingValueTB.TabIndex = 7;
            // 
            // runningReadingLabel
            // 
            runningReadingLabel.AutoSize = true;
            runningReadingLabel.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            runningReadingLabel.Location = new Point(52, 242);
            runningReadingLabel.Name = "runningReadingLabel";
            runningReadingLabel.Size = new Size(165, 22);
            runningReadingLabel.TabIndex = 6;
            runningReadingLabel.Text = "Running Reading :";
            // 
            // consumedUnitValueTB
            // 
            consumedUnitValueTB.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            consumedUnitValueTB.Location = new Point(228, 286);
            consumedUnitValueTB.Name = "consumedUnitValueTB";
            consumedUnitValueTB.Size = new Size(267, 26);
            consumedUnitValueTB.TabIndex = 9;
            // 
            // consumedUnitLabel
            // 
            consumedUnitLabel.AutoSize = true;
            consumedUnitLabel.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            consumedUnitLabel.Location = new Point(52, 286);
            consumedUnitLabel.Name = "consumedUnitLabel";
            consumedUnitLabel.Size = new Size(165, 22);
            consumedUnitLabel.TabIndex = 8;
            consumedUnitLabel.Text = "Consumed Units  :";
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.FromArgb(255, 80, 80);
            resetButton.FlatStyle = FlatStyle.Popup;
            resetButton.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            resetButton.ForeColor = SystemColors.ControlLightLight;
            resetButton.Location = new Point(420, 63);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(120, 30);
            resetButton.TabIndex = 10;
            resetButton.Text = "RESET";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // calculateBillButton
            // 
            calculateBillButton.BackColor = Color.FromArgb(255, 153, 204);
            calculateBillButton.FlatStyle = FlatStyle.Popup;
            calculateBillButton.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            calculateBillButton.ForeColor = Color.LavenderBlush;
            calculateBillButton.Location = new Point(560, 305);
            calculateBillButton.Name = "calculateBillButton";
            calculateBillButton.Size = new Size(272, 44);
            calculateBillButton.TabIndex = 11;
            calculateBillButton.Text = "CALCULATE BILL";
            calculateBillButton.UseVisualStyleBackColor = false;
            calculateBillButton.Click += calculateBillButton_Click;
            // 
            // billButton
            // 
            billButton.BackColor = Color.FromArgb(0, 204, 0);
            billButton.FlatStyle = FlatStyle.Flat;
            billButton.Location = new Point(560, 202);
            billButton.Name = "billButton";
            billButton.Size = new Size(272, 40);
            billButton.TabIndex = 12;
            billButton.Text = "VIEW BILL";
            billButton.UseVisualStyleBackColor = false;
            billButton.Visible = false;
            billButton.Click += billButton_Click;
            // 
            // billingButton
            // 
            billingButton.BackColor = Color.FromArgb(0, 204, 0);
            billingButton.FlatStyle = FlatStyle.Flat;
            billingButton.ForeColor = SystemColors.ActiveCaptionText;
            billingButton.Location = new Point(560, 149);
            billingButton.Name = "billingButton";
            billingButton.Size = new Size(272, 40);
            billingButton.TabIndex = 13;
            billingButton.Text = "VIEW BILLING";
            billingButton.UseVisualStyleBackColor = false;
            billingButton.Visible = false;
            billingButton.Click += billingButton_Click;
            // 
            // previousBillCB
            // 
            previousBillCB.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            previousBillCB.ForeColor = Color.FromArgb(255, 102, 102);
            previousBillCB.FormattingEnabled = true;
            previousBillCB.Location = new Point(315, 12);
            previousBillCB.Name = "previousBillCB";
            previousBillCB.Size = new Size(226, 30);
            previousBillCB.TabIndex = 14;
            previousBillCB.Tag = "";
            previousBillCB.Text = "  PREVIOUS BILL";
            previousBillCB.SelectedIndexChanged += previousBillCB_SelectedIndexChanged;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            addressLabel.Location = new Point(55, 327);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(162, 22);
            addressLabel.TabIndex = 15;
            addressLabel.Text = "Address               :";
            // 
            // addressValueTB
            // 
            addressValueTB.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addressValueTB.Location = new Point(228, 330);
            addressValueTB.Name = "addressValueTB";
            addressValueTB.Size = new Size(267, 90);
            addressValueTB.TabIndex = 16;
            addressValueTB.Text = "";
            // 
            // phoneNumberValueTB
            // 
            phoneNumberValueTB.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phoneNumberValueTB.Location = new Point(228, 157);
            phoneNumberValueTB.Name = "phoneNumberValueTB";
            phoneNumberValueTB.Size = new Size(267, 26);
            phoneNumberValueTB.TabIndex = 18;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            phoneNumberLabel.Location = new Point(55, 156);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(162, 22);
            phoneNumberLabel.TabIndex = 17;
            phoneNumberLabel.Text = "Phone Number    :";
            // 
            // rightPictureBox
            // 
            rightPictureBox.BackgroundImage = Properties.Resources.Front_RIght_page;
            rightPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            rightPictureBox.Location = new Point(547, 0);
            rightPictureBox.Name = "rightPictureBox";
            rightPictureBox.Size = new Size(300, 468);
            rightPictureBox.TabIndex = 19;
            rightPictureBox.TabStop = false;
            // 
            // appLogoPictureBox
            // 
            appLogoPictureBox.BackgroundImage = Properties.Resources.MSEB_logo_;
            appLogoPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            appLogoPictureBox.Location = new Point(12, 12);
            appLogoPictureBox.Name = "appLogoPictureBox";
            appLogoPictureBox.Size = new Size(73, 37);
            appLogoPictureBox.TabIndex = 20;
            appLogoPictureBox.TabStop = false;
            // 
            // msebHeadingLabel
            // 
            msebHeadingLabel.AutoSize = true;
            msebHeadingLabel.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point);
            msebHeadingLabel.Location = new Point(91, 12);
            msebHeadingLabel.Name = "msebHeadingLabel";
            msebHeadingLabel.Size = new Size(108, 38);
            msebHeadingLabel.TabIndex = 41;
            msebHeadingLabel.Text = "MSEB";
            // 
            // label17
            // 
            label17.BackColor = Color.Transparent;
            label17.ForeColor = Color.Tomato;
            label17.Location = new Point(5, 71);
            label17.Name = "label17";
            label17.Size = new Size(252, 18);
            label17.TabIndex = 42;
            label17.Text = "__________________________________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(8, 52);
            label1.Name = "label1";
            label1.Size = new Size(186, 23);
            label1.TabIndex = 43;
            label1.Text = "M A H A  VITARAN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(847, 480);
            Controls.Add(label1);
            Controls.Add(label17);
            Controls.Add(msebHeadingLabel);
            Controls.Add(appLogoPictureBox);
            Controls.Add(phoneNumberValueTB);
            Controls.Add(phoneNumberLabel);
            Controls.Add(addressValueTB);
            Controls.Add(addressLabel);
            Controls.Add(previousBillCB);
            Controls.Add(billingButton);
            Controls.Add(billButton);
            Controls.Add(calculateBillButton);
            Controls.Add(resetButton);
            Controls.Add(consumedUnitValueTB);
            Controls.Add(consumedUnitLabel);
            Controls.Add(runningReadingValueTB);
            Controls.Add(runningReadingLabel);
            Controls.Add(emailValueTB);
            Controls.Add(emailLabel);
            Controls.Add(nameValueTB);
            Controls.Add(nameLabel);
            Controls.Add(rightPictureBox);
            Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "MSEB MAHA VITRAN";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)rightPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)appLogoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameValueTB;
        private TextBox emailValueTB;
        private Label emailLabel;
        private TextBox runningReadingValueTB;
        private Label runningReadingLabel;
        private TextBox consumedUnitValueTB;
        private Label consumedUnitLabel;
        private Button resetButton;
        private Button calculateBillButton;
        private Button billButton;
        private Button billingButton;
        private ComboBox previousBillCB;
        private Label addressLabel;
        private RichTextBox addressValueTB;
        private TextBox phoneNumberValueTB;
        private Label phoneNumberLabel;
        private PictureBox rightPictureBox;
        private PictureBox appLogoPictureBox;
        private Label msebHeadingLabel;
        private Label label17;
        private Label label1;
    }
}