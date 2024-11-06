namespace adBank
{
    partial class Login
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LogInButton = new Button();
            ExitButton = new Button();
            EmailTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(LogInButton, 0, 3);
            tableLayoutPanel1.Controls.Add(ExitButton, 1, 3);
            tableLayoutPanel1.Controls.Add(EmailTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(PasswordTextBox, 1, 2);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(794, 444);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 2);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(788, 111);
            label1.TabIndex = 0;
            label1.Text = "Logowanie";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Right;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(333, 111);
            label2.Name = "label2";
            label2.Size = new Size(61, 111);
            label2.TabIndex = 1;
            label2.Text = "E-mail: ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 222);
            label3.Name = "label3";
            label3.Size = new Size(391, 111);
            label3.TabIndex = 2;
            label3.Text = "Hasło: ";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LogInButton
            // 
            LogInButton.Dock = DockStyle.Fill;
            LogInButton.Location = new Point(3, 336);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(391, 105);
            LogInButton.TabIndex = 3;
            LogInButton.Text = "Zaloguj";
            LogInButton.UseVisualStyleBackColor = true;
            LogInButton.Click += button1_Click;
            // 
            // ExitButton
            // 
            ExitButton.Dock = DockStyle.Fill;
            ExitButton.Location = new Point(400, 336);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(391, 105);
            ExitButton.TabIndex = 4;
            ExitButton.Text = "Wyjdź";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Dock = DockStyle.Fill;
            EmailTextBox.Location = new Point(400, 114);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(391, 23);
            EmailTextBox.TabIndex = 5;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Dock = DockStyle.Fill;
            PasswordTextBox.Location = new Point(400, 225);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(391, 23);
            PasswordTextBox.TabIndex = 6;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 450);
            panel1.TabIndex = 1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 450);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button LogInButton;
        private Button ExitButton;
        private TextBox EmailTextBox;
        private TextBox PasswordTextBox;
    }
}