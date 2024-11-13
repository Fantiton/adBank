namespace adBank
{
    partial class NewTransfer
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
            SourceTextBox = new TextBox();
            TargetTextBox = new TextBox();
            AmountTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // SourceTextBox
            // 
            SourceTextBox.Enabled = false;
            SourceTextBox.Location = new Point(146, 6);
            SourceTextBox.Name = "SourceTextBox";
            SourceTextBox.Size = new Size(193, 23);
            SourceTextBox.TabIndex = 0;
            // 
            // TargetTextBox
            // 
            TargetTextBox.Location = new Point(146, 35);
            TargetTextBox.Name = "TargetTextBox";
            TargetTextBox.Size = new Size(193, 23);
            TargetTextBox.TabIndex = 1;
            // 
            // AmountTextBox
            // 
            AmountTextBox.Location = new Point(146, 64);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Size = new Size(193, 23);
            AmountTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 3;
            label1.Text = "Rachunek Źródłowy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 4;
            label2.Text = "Rachunek Docelowy";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 5;
            label3.Text = "Kwota";
            // 
            // button1
            // 
            button1.Location = new Point(12, 93);
            button1.Name = "button1";
            button1.Size = new Size(327, 23);
            button1.TabIndex = 6;
            button1.Text = "Wykonaj Przelew";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // NewTransfer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 122);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AmountTextBox);
            Controls.Add(TargetTextBox);
            Controls.Add(SourceTextBox);
            Name = "NewTransfer";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SourceTextBox;
        private TextBox TargetTextBox;
        private TextBox AmountTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}