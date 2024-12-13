namespace adBank
{
    partial class AccountList
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
            AccountListSearchButton = new Button();
            AccountListTextBox = new TextBox();
            AccountListGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)AccountListGridView).BeginInit();
            SuspendLayout();
            // 
            // AccountListSearchButton
            // 
            AccountListSearchButton.Location = new Point(354, 12);
            AccountListSearchButton.Name = "AccountListSearchButton";
            AccountListSearchButton.Size = new Size(75, 23);
            AccountListSearchButton.TabIndex = 0;
            AccountListSearchButton.Text = "Wyszukaj";
            AccountListSearchButton.UseVisualStyleBackColor = true;
            AccountListSearchButton.Click += AccountListSearchButton_Click;
            // 
            // AccountListTextBox
            // 
            AccountListTextBox.Location = new Point(12, 12);
            AccountListTextBox.Name = "AccountListTextBox";
            AccountListTextBox.Size = new Size(336, 23);
            AccountListTextBox.TabIndex = 1;
            // 
            // AccountListGridView
            // 
            AccountListGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AccountListGridView.Location = new Point(12, 41);
            AccountListGridView.Name = "AccountListGridView";
            AccountListGridView.Size = new Size(417, 397);
            AccountListGridView.TabIndex = 2;
            // 
            // AccountList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 450);
            Controls.Add(AccountListGridView);
            Controls.Add(AccountListTextBox);
            Controls.Add(AccountListSearchButton);
            Name = "AccountList";
            Text = "AccountList";
            ((System.ComponentModel.ISupportInitialize)AccountListGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AccountListSearchButton;
        private TextBox AccountListTextBox;
        private DataGridView AccountListGridView;
    }
}