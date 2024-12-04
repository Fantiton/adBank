namespace adBank
{
    partial class TransferHistory
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
            components = new System.ComponentModel.Container();
            transfersHistoryGridView = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            TransferHistorySource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)transfersHistoryGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TransferHistorySource).BeginInit();
            SuspendLayout();
            // 
            // transfersHistoryGridView
            // 
            transfersHistoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            transfersHistoryGridView.Location = new Point(12, 12);
            transfersHistoryGridView.Name = "transfersHistoryGridView";
            transfersHistoryGridView.Size = new Size(776, 426);
            transfersHistoryGridView.TabIndex = 0;
            // 
            // TransferHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(transfersHistoryGridView);
            Name = "TransferHistory";
            Text = "TransferHistory";
            Load += TransferHistory_Load;
            ((System.ComponentModel.ISupportInitialize)transfersHistoryGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)TransferHistorySource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView transfersHistoryGridView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private BindingSource TransferHistorySource;
    }
}