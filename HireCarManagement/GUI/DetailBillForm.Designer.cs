namespace HireCarManagement.GUI
{
    partial class DetailBillForm
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
            label1 = new Label();
            label2 = new Label();
            lbID = new Label();
            label3 = new Label();
            lbName = new Label();
            lbCarName = new Label();
            label5 = new Label();
            dtpHiredAt = new DateTimePicker();
            label4 = new Label();
            label6 = new Label();
            dtpReturnedAt = new DateTimePicker();
            label7 = new Label();
            lbPrice = new Label();
            btnExportPdf = new Button();
            lbCCCD = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(260, 9);
            label1.Name = "label1";
            label1.Size = new Size(268, 46);
            label1.TabIndex = 0;
            label1.Text = "Deatil Bill Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 72);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "Bill's ID: ";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(117, 72);
            lbID.Name = "lbID";
            lbID.Size = new Size(50, 20);
            lbID.TabIndex = 2;
            lbID.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 114);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 3;
            label3.Text = "Name: ";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(117, 114);
            lbName.Name = "lbName";
            lbName.Size = new Size(50, 20);
            lbName.TabIndex = 4;
            lbName.Text = "label4";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(140, 198);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(50, 20);
            lbCarName.TabIndex = 6;
            lbCarName.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 198);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 5;
            label5.Text = "Car's name: ";
            // 
            // dtpHiredAt
            // 
            dtpHiredAt.Location = new Point(140, 235);
            dtpHiredAt.Name = "dtpHiredAt";
            dtpHiredAt.Size = new Size(250, 27);
            dtpHiredAt.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 240);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 8;
            label4.Text = "Hired Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 282);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 10;
            label6.Text = "Returned Date";
            // 
            // dtpReturnedAt
            // 
            dtpReturnedAt.Location = new Point(157, 275);
            dtpReturnedAt.Name = "dtpReturnedAt";
            dtpReturnedAt.Size = new Size(250, 27);
            dtpReturnedAt.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 328);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 11;
            label7.Text = "Price: ";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(100, 328);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(50, 20);
            lbPrice.TabIndex = 12;
            lbPrice.Text = "label8";
            // 
            // btnExportPdf
            // 
            btnExportPdf.Location = new Point(613, 372);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(163, 53);
            btnExportPdf.TabIndex = 13;
            btnExportPdf.Text = "Pay and Export Bill";
            btnExportPdf.UseVisualStyleBackColor = true;
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // lbCCCD
            // 
            lbCCCD.AutoSize = true;
            lbCCCD.Location = new Point(117, 156);
            lbCCCD.Name = "lbCCCD";
            lbCCCD.Size = new Size(50, 20);
            lbCCCD.TabIndex = 15;
            lbCCCD.Text = "label4";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(46, 156);
            label9.Name = "label9";
            label9.Size = new Size(54, 20);
            label9.TabIndex = 14;
            label9.Text = "CCCD: ";
            // 
            // DetailBillForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbCCCD);
            Controls.Add(label9);
            Controls.Add(btnExportPdf);
            Controls.Add(lbPrice);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dtpReturnedAt);
            Controls.Add(label4);
            Controls.Add(dtpHiredAt);
            Controls.Add(lbCarName);
            Controls.Add(label5);
            Controls.Add(lbName);
            Controls.Add(label3);
            Controls.Add(lbID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DetailBillForm";
            Text = "DetailBill Form";
            Load += load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbID;
        private Label label3;
        private Label lbName;
        private Label lbCarName;
        private Label label5;
        private DateTimePicker dtpHiredAt;
        private Label label4;
        private Label label6;
        private DateTimePicker dtpReturnedAt;
        private Label label7;
        private Label lbPrice;
        private Button btnExportPdf;
        private Label lbCCCD;
        private Label label9;
    }
}