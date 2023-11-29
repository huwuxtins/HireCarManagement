namespace DoubleT.GUI
{
    partial class fPayment
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
            dgvSchedule = new DataGridView();
            labelCustomer = new Label();
            tbCCCD = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            SuspendLayout();
            // 
            // dgvSchedule
            // 
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Location = new Point(497, 110);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.RowHeadersWidth = 51;
            dgvSchedule.RowTemplate.Height = 29;
            dgvSchedule.Size = new Size(595, 479);
            dgvSchedule.TabIndex = 22;
            dgvSchedule.CellClick += DGV_CellClick;
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Location = new Point(50, 110);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(130, 20);
            labelCustomer.TabIndex = 23;
            labelCustomer.Text = "Customer's CCCD: ";
            // 
            // tbCCCD
            // 
            tbCCCD.Location = new Point(50, 133);
            tbCCCD.Name = "tbCCCD";
            tbCCCD.Size = new Size(333, 27);
            tbCCCD.TabIndex = 26;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(389, 133);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 27;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // fPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 678);
            Controls.Add(btnSearch);
            Controls.Add(tbCCCD);
            Controls.Add(labelCustomer);
            Controls.Add(dgvSchedule);
            Name = "fPayment";
            Text = "fPayment";
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvSchedule;
        private Label labelCustomer;
        private TextBox tbCCCD;
        private Button btnSearch;
    }
}