namespace HireCarManagement.GUI
{
    partial class AddEmployee
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
            btnSave = new Button();
            cbbROLE = new ComboBox();
            btnAdd = new Button();
            tbPassword = new TextBox();
            tbEmail = new TextBox();
            tbName = new TextBox();
            labelCustomerAddress = new Label();
            labelCustomerCCCD = new Label();
            labelCusyomerPhone = new Label();
            labelCustomerName = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(cbbROLE);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(tbEmail);
            panel1.Controls.Add(tbName);
            panel1.Controls.Add(labelCustomerAddress);
            panel1.Controls.Add(labelCustomerCCCD);
            panel1.Controls.Add(labelCusyomerPhone);
            panel1.Controls.Add(labelCustomerName);
            panel1.Location = new Point(169, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 500);
            panel1.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(517, 449);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 28;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Visible = false;
            btnSave.Click += button1_Click;
            // 
            // cbbROLE
            // 
            cbbROLE.FormattingEnabled = true;
            cbbROLE.Items.AddRange(new object[] { "ROLE_ADMIN", "ROLE_EMP" });
            cbbROLE.Location = new Point(108, 369);
            cbbROLE.Name = "cbbROLE";
            cbbROLE.Size = new Size(151, 28);
            cbbROLE.TabIndex = 27;
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
            // tbPassword
            // 
            tbPassword.Location = new Point(108, 255);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(145, 27);
            tbPassword.TabIndex = 6;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(108, 166);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(145, 27);
            tbEmail.TabIndex = 5;
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
            labelCustomerAddress.Size = new Size(44, 20);
            labelCustomerAddress.TabIndex = 3;
            labelCustomerAddress.Text = "ROLE";
            // 
            // labelCustomerCCCD
            // 
            labelCustomerCCCD.AutoSize = true;
            labelCustomerCCCD.Location = new Point(108, 217);
            labelCustomerCCCD.Name = "labelCustomerCCCD";
            labelCustomerCCCD.Size = new Size(70, 20);
            labelCustomerCCCD.TabIndex = 2;
            labelCustomerCCCD.Text = "Password";
            // 
            // labelCusyomerPhone
            // 
            labelCusyomerPhone.AutoSize = true;
            labelCusyomerPhone.Location = new Point(108, 128);
            labelCusyomerPhone.Name = "labelCusyomerPhone";
            labelCusyomerPhone.Size = new Size(46, 20);
            labelCusyomerPhone.TabIndex = 1;
            labelCusyomerPhone.Text = "Email";
            // 
            // labelCustomerName
            // 
            labelCustomerName.AutoSize = true;
            labelCustomerName.Location = new Point(108, 45);
            labelCustomerName.Name = "labelCustomerName";
            labelCustomerName.Size = new Size(49, 20);
            labelCustomerName.TabIndex = 0;
            labelCustomerName.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(277, 9);
            label1.Name = "label1";
            label1.Size = new Size(381, 46);
            label1.TabIndex = 27;
            label1.Text = "ADD EMPLOYEE FORM";
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 582);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "AddEmployee";
            Text = "AddEmployee";
            this.Load += this.FormLoad;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnAdd;
        private TextBox tbPassword;
        private TextBox tbEmail;
        private TextBox tbName;
        private Label labelCustomerAddress;
        private Label labelCustomerCCCD;
        private Label labelCusyomerPhone;
        private Label labelCustomerName;
        private Label label1;
        private ComboBox cbbROLE;
        private Button btnSave;
    }
}