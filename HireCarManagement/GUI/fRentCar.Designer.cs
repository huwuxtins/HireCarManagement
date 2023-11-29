namespace DoubleT.GUI
{
    partial class fRentCar
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
            labelCustomer = new Label();
            comboBoxCostomer = new ComboBox();
            panel1 = new Panel();
            buttonXem = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dgvSchedule = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            SuspendLayout();
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Location = new Point(24, 26);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(93, 20);
            labelCustomer.TabIndex = 25;
            labelCustomer.Text = "Khách hàng :";
            // 
            // comboBoxCostomer
            // 
            comboBoxCostomer.FormattingEnabled = true;
            comboBoxCostomer.Location = new Point(24, 59);
            comboBoxCostomer.Name = "comboBoxCostomer";
            comboBoxCostomer.Size = new Size(233, 28);
            comboBoxCostomer.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonXem);
            panel1.Controls.Add(labelCustomer);
            panel1.Controls.Add(comboBoxCostomer);
            panel1.Location = new Point(31, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 566);
            panel1.TabIndex = 28;
            // 
            // buttonXem
            // 
            buttonXem.Location = new Point(222, 524);
            buttonXem.Name = "buttonXem";
            buttonXem.Size = new Size(94, 29);
            buttonXem.TabIndex = 26;
            buttonXem.Text = "Xem";
            buttonXem.UseVisualStyleBackColor = true;
            // 
            // dgvSchedule
            // 
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Location = new Point(369, 56);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.RowHeadersWidth = 51;
            dgvSchedule.RowTemplate.Height = 29;
            dgvSchedule.Size = new Size(742, 566);
            dgvSchedule.TabIndex = 29;
            // 
            // fRentCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 678);
            Controls.Add(panel1);
            Controls.Add(dgvSchedule);
            Name = "fRentCar";
            Text = "RentCar";
            Load += load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelCustomer;
        private ComboBox comboBoxCostomer;
        private Panel panel1;
        private Button buttonXem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dgvSchedule;
    }
}