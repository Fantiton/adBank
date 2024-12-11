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
            AccountListSearchTextBox = new TextBox();
            AccountListSearchButton = new Button();
            AccountListGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)AccountListGridView).BeginInit();
            SuspendLayout();
            // 
            // AccountListSearchTextBox
            // 
            AccountListSearchTextBox.Location = new Point(12, 11);
            AccountListSearchTextBox.Name = "AccountListSearchTextBox";
            AccountListSearchTextBox.Size = new Size(322, 23);
            AccountListSearchTextBox.TabIndex = 0;
            // 
            // AccountListSearchButton
            // 
            AccountListSearchButton.Location = new Point(340, 11);
            AccountListSearchButton.Name = "AccountListSearchButton";
            AccountListSearchButton.Size = new Size(88, 24);
            AccountListSearchButton.TabIndex = 1;
            AccountListSearchButton.Text = "Szukaj";
            AccountListSearchButton.UseVisualStyleBackColor = true;
            AccountListSearchButton.Click += AccountListSearchButton_Click;
            // 
            // AccountListGridView
            // 
            AccountListGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AccountListGridView.Location = new Point(12, 41);
            AccountListGridView.Name = "AccountListGridView";
            AccountListGridView.Size = new Size(416, 397);
            AccountListGridView.TabIndex = 2;
            // 
            // AccountList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 450);
            Controls.Add(AccountListGridView);
            Controls.Add(AccountListSearchButton);
            Controls.Add(AccountListSearchTextBox);
            Name = "AccountList";
            Text = "AccountList";
            ((System.ComponentModel.ISupportInitialize)AccountListGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AccountListSearchTextBox;
        private Button AccountListSearchButton;
        private DataGridView AccountListGridView;
    }
}