namespace DoubleT.GUI
{
    partial class fAddCustomercs
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
            panel1 = new Panel();
            btnAdd = new Button();
            tbAddress = new TextBox();
            tbCCCD = new TextBox();
            tbPhoneNumber = new TextBox();
            tbName = new TextBox();
            labelCustomerAddress = new Label();
            labelCustomerCCCD = new Label();
            labelCusyomerPhone = new Label();
            labelCustomerName = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(tbAddress);
            panel1.Controls.Add(tbCCCD);
            panel1.Controls.Add(tbPhoneNumber);
            panel1.Controls.Add(tbName);
            panel1.Controls.Add(labelCustomerAddress);
            panel1.Controls.Add(labelCustomerCCCD);
            panel1.Controls.Add(labelCusyomerPhone);
            panel1.Controls.Add(labelCustomerName);
            panel1.Location = new Point(203, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 500);
            panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(517, 449);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 26;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(108, 368);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(255, 27);
            tbAddress.TabIndex = 7;
            // 
            // tbCCCD
            // 
            tbCCCD.Location = new Point(108, 255);
            tbCCCD.Name = "tbCCCD";
            tbCCCD.Size = new Size(145, 27);
            tbCCCD.TabIndex = 6;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Location = new Point(108, 166);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(145, 27);
            tbPhoneNumber.TabIndex = 5;
            // 
            // tbName
            // 
            tbName.Location = new Point(108, 77);
            tbName.Name = "tbName";
            tbName.Size = new Size(196, 27);
            tbName.TabIndex = 4;
            // 
            // labelCustomerAddress
            // 
            labelCustomerAddress.AutoSize = true;
            labelCustomerAddress.Location = new Point(108, 324);
            labelCustomerAddress.Name = "labelCustomerAddress";
            labelCustomerAddress.Size = new Size(62, 20);
            labelCustomerAddress.TabIndex = 3;
            labelCustomerAddress.Text = "Địa chỉ :";
            // 
            // labelCustomerCCCD
            // 
            labelCustomerCCCD.AutoSize = true;
            labelCustomerCCCD.Location = new Point(108, 217);
            labelCustomerCCCD.Name = "labelCustomerCCCD";
            labelCustomerCCCD.Size = new Size(104, 20);
            labelCustomerCCCD.TabIndex = 2;
            labelCustomerCCCD.Text = "CCCD/CMND :";
            // 
            // labelCusyomerPhone
            // 
            labelCusyomerPhone.AutoSize = true;
            labelCusyomerPhone.Location = new Point(108, 128);
            labelCusyomerPhone.Name = "labelCusyomerPhone";
            labelCusyomerPhone.Size = new Size(43, 20);
            labelCusyomerPhone.TabIndex = 1;
            labelCusyomerPhone.Text = "SĐT :";
            // 
            // labelCustomerName
            // 
            labelCustomerName.AutoSize = true;
            labelCustomerName.Location = new Point(108, 45);
            labelCustomerName.Name = "labelCustomerName";
            labelCustomerName.Size = new Size(39, 20);
            labelCustomerName.TabIndex = 0;
            labelCustomerName.Text = "Tên :";
            // 
            // fAddCustomercs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 678);
            Controls.Add(panel1);
            Name = "fAddCustomercs";
            Text = "fAddCustomercs";
            Load += fAddCustomercs_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox tbAddress;
        private TextBox tbCCCD;
        private TextBox tbPhoneNumber;
        private TextBox tbName;
        private Label labelCustomerAddress;
        private Label labelCustomerCCCD;
        private Label labelCusyomerPhone;
        private Label labelCustomerName;
        private Button btnAdd;
    }
}