namespace DoubleT.GUI
{
    partial class BillsForm
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
            lbSearch = new Label();
            panel1 = new Panel();
            tbSearch = new TextBox();
            btnExport = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dgvBills = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBills).BeginInit();
            SuspendLayout();
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new Point(24, 26);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(147, 20);
            lbSearch.TabIndex = 25;
            lbSearch.Text = "Search by Customer: ";
            // 
            // panel1
            // 
            panel1.Controls.Add(tbSearch);
            panel1.Controls.Add(btnExport);
            panel1.Controls.Add(lbSearch);
            panel1.Location = new Point(27, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 566);
            panel1.TabIndex = 26;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(24, 49);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(250, 27);
            tbSearch.TabIndex = 27;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.Black;
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(163, 512);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(122, 51);
            btnExport.TabIndex = 26;
            btnExport.Text = "Export Excel";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // dgvBills
            // 
            dgvBills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBills.Location = new Point(321, 48);
            dgvBills.Name = "dgvBills";
            dgvBills.RowHeadersWidth = 51;
            dgvBills.RowTemplate.Height = 29;
            dgvBills.Size = new Size(786, 566);
            dgvBills.TabIndex = 27;
            // 
            // BillsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 678);
            Controls.Add(dgvBills);
            Controls.Add(panel1);
            Name = "BillsForm";
            Text = "Bills Form";
            Load += load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBills).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbSearch;
        private Panel panel1;
        private Button btnExport;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dgvBills;
        private TextBox tbSearch;
    }
}