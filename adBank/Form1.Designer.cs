namespace adBank
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
            AccountDetailsGroupBox = new GroupBox();
            AccountAmountTextBox = new TextBox();
            AccountAmountLabel = new Label();
            AccountNumberTextBox = new TextBox();
            AccountNumberLabel = new Label();
            AccountNameTextBox = new TextBox();
            AccountNameLabel = new Label();
            AccountDetailsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // AccountDetailsGroupBox
            // 
            AccountDetailsGroupBox.Controls.Add(AccountAmountTextBox);
            AccountDetailsGroupBox.Controls.Add(AccountAmountLabel);
            AccountDetailsGroupBox.Controls.Add(AccountNumberTextBox);
            AccountDetailsGroupBox.Controls.Add(AccountNumberLabel);
            AccountDetailsGroupBox.Controls.Add(AccountNameTextBox);
            AccountDetailsGroupBox.Controls.Add(AccountNameLabel);
            AccountDetailsGroupBox.Enabled = false;
            AccountDetailsGroupBox.Location = new Point(12, 35);
            AccountDetailsGroupBox.Name = "AccountDetailsGroupBox";
            AccountDetailsGroupBox.Size = new Size(341, 109);
            AccountDetailsGroupBox.TabIndex = 3;
            AccountDetailsGroupBox.TabStop = false;
            AccountDetailsGroupBox.Text = "Rachunek";
            // 
            // AccountAmountTextBox
            // 
            AccountAmountTextBox.Location = new Point(109, 74);
            AccountAmountTextBox.Name = "AccountAmountTextBox";
            AccountAmountTextBox.Size = new Size(221, 23);
            AccountAmountTextBox.TabIndex = 5;
            // 
            // AccountAmountLabel
            // 
            AccountAmountLabel.AutoSize = true;
            AccountAmountLabel.Location = new Point(6, 77);
            AccountAmountLabel.Name = "AccountAmountLabel";
            AccountAmountLabel.Size = new Size(70, 15);
            AccountAmountLabel.TabIndex = 4;
            AccountAmountLabel.Text = "Stan Konta: ";
            // 
            // AccountNumberTextBox
            // 
            AccountNumberTextBox.Location = new Point(109, 16);
            AccountNumberTextBox.Name = "AccountNumberTextBox";
            AccountNumberTextBox.ReadOnly = true;
            AccountNumberTextBox.Size = new Size(221, 23);
            AccountNumberTextBox.TabIndex = 3;
            // 
            // AccountNumberLabel
            // 
            AccountNumberLabel.AutoSize = true;
            AccountNumberLabel.Location = new Point(6, 19);
            AccountNumberLabel.Name = "AccountNumberLabel";
            AccountNumberLabel.Size = new Size(100, 15);
            AccountNumberLabel.TabIndex = 2;
            AccountNumberLabel.Text = "Numer Rachunku";
            // 
            // AccountNameTextBox
            // 
            AccountNameTextBox.Location = new Point(109, 45);
            AccountNameTextBox.Name = "AccountNameTextBox";
            AccountNameTextBox.ReadOnly = true;
            AccountNameTextBox.Size = new Size(221, 23);
            AccountNameTextBox.TabIndex = 1;
            // 
            // AccountNameLabel
            // 
            AccountNameLabel.AutoSize = true;
            AccountNameLabel.Location = new Point(6, 48);
            AccountNameLabel.Name = "AccountNameLabel";
            AccountNameLabel.Size = new Size(104, 15);
            AccountNameLabel.TabIndex = 0;
            AccountNameLabel.Text = "Nazwa Rachunku: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 152);
            Controls.Add(AccountDetailsGroupBox);
            Name = "Form1";
            Text = "Form1";
            Load += OnAppLoad;
            Shown += GetAccountData;
            AccountDetailsGroupBox.ResumeLayout(false);
            AccountDetailsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox AccountDetailsGroupBox;
        private Label AccountNameLabel;
        private TextBox AccountNameTextBox;
        private TextBox AccountNumberTextBox;
        private Label AccountNumberLabel;
        private Label AccountAmountLabel;
        private TextBox AccountAmountTextBox;
    }
}
