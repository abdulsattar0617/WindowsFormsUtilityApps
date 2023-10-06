namespace _04_WP_RC_PR_WinForm
{
    partial class SynapsyPointForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SynapsyPointForm));
            fullDetailButton = new Button();
            shortDetailButton = new Button();
            infoHeadingLabel = new RichTextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // fullDetailButton
            // 
            fullDetailButton.BackColor = Color.FromArgb(45, 137, 239);
            fullDetailButton.FlatStyle = FlatStyle.Flat;
            fullDetailButton.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            fullDetailButton.ForeColor = Color.FromArgb(239, 244, 255);
            fullDetailButton.Location = new Point(45, 137);
            fullDetailButton.Name = "fullDetailButton";
            fullDetailButton.Size = new Size(204, 45);
            fullDetailButton.TabIndex = 8;
            fullDetailButton.Text = "Enter Full Details";
            fullDetailButton.UseVisualStyleBackColor = false;
            fullDetailButton.Click += fullDetailButton_Click;
            // 
            // shortDetailButton
            // 
            shortDetailButton.BackColor = Color.FromArgb(45, 137, 239);
            shortDetailButton.FlatStyle = FlatStyle.Flat;
            shortDetailButton.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            shortDetailButton.ForeColor = Color.FromArgb(239, 244, 255);
            shortDetailButton.Location = new Point(268, 137);
            shortDetailButton.Name = "shortDetailButton";
            shortDetailButton.Size = new Size(204, 45);
            shortDetailButton.TabIndex = 9;
            shortDetailButton.Text = "Enter Short Details";
            shortDetailButton.UseVisualStyleBackColor = false;
            shortDetailButton.Click += shortDetailButton_Click;
            // 
            // infoHeadingLabel
            // 
            infoHeadingLabel.BackColor = Color.FromArgb(239, 244, 255);
            infoHeadingLabel.BorderStyle = BorderStyle.None;
            infoHeadingLabel.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            infoHeadingLabel.Location = new Point(68, 20);
            infoHeadingLabel.Name = "infoHeadingLabel";
            infoHeadingLabel.ReadOnly = true;
            infoHeadingLabel.Size = new Size(418, 111);
            infoHeadingLabel.TabIndex = 10;
            infoHeadingLabel.TabStop = false;
            infoHeadingLabel.Text = "Please choose an option below to provide your First Year Marks information";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.check_box_image;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(10, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 37);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // SynapsyPointForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 244, 255);
            ClientSize = new Size(514, 215);
            Controls.Add(infoHeadingLabel);
            Controls.Add(pictureBox1);
            Controls.Add(shortDetailButton);
            Controls.Add(fullDetailButton);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "SynapsyPointForm";
            Text = "First Year Details";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button fullDetailButton;
        private Button shortDetailButton;
        private RichTextBox infoHeadingLabel;
        private PictureBox pictureBox1;
    }
}