namespace DoubleT.GUI
{
    partial class fEditCustomer
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
            buttonEdit = new Button();
            textBoxCustomerAddress = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            labelCustomerAddress = new Label();
            labelCustomerCCCD = new Label();
            labelCusyomerPhone = new Label();
            labelCustomerName = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonEdit);
            panel1.Controls.Add(textBoxCustomerAddress);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(labelCustomerAddress);
            panel1.Controls.Add(labelCustomerCCCD);
            panel1.Controls.Add(labelCusyomerPhone);
            panel1.Controls.Add(labelCustomerName);
            panel1.Location = new Point(249, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 500);
            panel1.TabIndex = 1;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(517, 449);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(94, 29);
            buttonEdit.TabIndex = 26;
            buttonEdit.Text = "Lưu";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // textBoxCustomerAddress
            // 
            textBoxCustomerAddress.Location = new Point(108, 368);
            textBoxCustomerAddress.Name = "textBoxCustomerAddress";
            textBoxCustomerAddress.Size = new Size(255, 27);
            textBoxCustomerAddress.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(108, 255);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(145, 27);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(108, 166);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(145, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 27);
            textBox1.TabIndex = 4;
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
            // fEditCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 678);
            Controls.Add(panel1);
            Name = "fEditCustomer";
            Text = "fEditCustomer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonEdit;
        private TextBox textBoxCustomerAddress;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label labelCustomerAddress;
        private Label labelCustomerCCCD;
        private Label labelCusyomerPhone;
        private Label labelCustomerName;
    }
}