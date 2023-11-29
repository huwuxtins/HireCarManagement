namespace DoubleT.GUI
{
    partial class AddBillForm
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
            dataGridViewBill = new DataGridView();
            panel1 = new Panel();
            button1 = new Button();
            tbCCCD = new TextBox();
            lbNameCar = new Label();
            label2 = new Label();
            tbTypeCar = new TextBox();
            tbMoney = new TextBox();
            label1 = new Label();
            dtpRentDate = new DateTimePicker();
            labelTime = new Label();
            buttonCreateBill = new Button();
            labelNumberDay = new Label();
            labelCustomerName = new Label();
            rentDate = new NumericUpDown();
            tbNameCar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBill).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rentDate).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewBill
            // 
            dataGridViewBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBill.Location = new Point(502, 64);
            dataGridViewBill.Name = "dataGridViewBill";
            dataGridViewBill.RowHeadersWidth = 51;
            dataGridViewBill.RowTemplate.Height = 29;
            dataGridViewBill.Size = new Size(628, 564);
            dataGridViewBill.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(tbCCCD);
            panel1.Controls.Add(lbNameCar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbTypeCar);
            panel1.Controls.Add(tbMoney);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dtpRentDate);
            panel1.Controls.Add(labelTime);
            panel1.Controls.Add(buttonCreateBill);
            panel1.Controls.Add(labelNumberDay);
            panel1.Controls.Add(labelCustomerName);
            panel1.Controls.Add(rentDate);
            panel1.Controls.Add(tbNameCar);
            panel1.Location = new Point(27, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(451, 569);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(264, 120);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 21;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += search;
            // 
            // tbCCCD
            // 
            tbCCCD.Location = new Point(16, 122);
            tbCCCD.Name = "tbCCCD";
            tbCCCD.Size = new Size(220, 27);
            tbCCCD.TabIndex = 20;
            // 
            // lbNameCar
            // 
            lbNameCar.AutoSize = true;
            lbNameCar.Location = new Point(16, 18);
            lbNameCar.Name = "lbNameCar";
            lbNameCar.Size = new Size(88, 20);
            lbNameCar.TabIndex = 19;
            lbNameCar.Text = "Car's name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 182);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 18;
            label2.Text = "Car's type :";
            // 
            // tbTypeCar
            // 
            tbTypeCar.Location = new Point(16, 205);
            tbTypeCar.Name = "tbTypeCar";
            tbTypeCar.Size = new Size(220, 27);
            tbTypeCar.TabIndex = 17;
            // 
            // tbMoney
            // 
            tbMoney.Location = new Point(16, 432);
            tbMoney.Name = "tbMoney";
            tbMoney.Size = new Size(250, 27);
            tbMoney.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 409);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 15;
            label1.Text = "Total money :";
            // 
            // dtpRentDate
            // 
            dtpRentDate.Location = new Point(16, 354);
            dtpRentDate.Name = "dtpRentDate";
            dtpRentDate.Size = new Size(250, 27);
            dtpRentDate.TabIndex = 14;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(16, 331);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(80, 20);
            labelTime.TabIndex = 13;
            labelTime.Text = "Rent date :";
            // 
            // buttonCreateBill
            // 
            buttonCreateBill.Location = new Point(330, 502);
            buttonCreateBill.Name = "buttonCreateBill";
            buttonCreateBill.Size = new Size(103, 48);
            buttonCreateBill.TabIndex = 12;
            buttonCreateBill.Text = "Tạo đơn";
            buttonCreateBill.UseVisualStyleBackColor = true;
            buttonCreateBill.Click += buttonCreateBill_Click;
            // 
            // labelNumberDay
            // 
            labelNumberDay.AutoSize = true;
            labelNumberDay.Location = new Point(16, 259);
            labelNumberDay.Name = "labelNumberDay";
            labelNumberDay.Size = new Size(177, 20);
            labelNumberDay.TabIndex = 11;
            labelNumberDay.Text = "The amount of rent date :";
            // 
            // labelCustomerName
            // 
            labelCustomerName.AutoSize = true;
            labelCustomerName.Location = new Point(16, 99);
            labelCustomerName.Name = "labelCustomerName";
            labelCustomerName.Size = new Size(122, 20);
            labelCustomerName.TabIndex = 10;
            labelCustomerName.Text = "Customer's cccd :";
            // 
            // rentDate
            // 
            rentDate.Location = new Point(16, 282);
            rentDate.Name = "rentDate";
            rentDate.Size = new Size(75, 27);
            rentDate.TabIndex = 8;
            rentDate.TextAlign = HorizontalAlignment.Center;
            rentDate.Value = new decimal(new int[] { 1, 0, 0, 0 });
            rentDate.ValueChanged += rentDate_ValueChanged;
            // 
            // tbNameCar
            // 
            tbNameCar.Location = new Point(16, 41);
            tbNameCar.Name = "tbNameCar";
            tbNameCar.Size = new Size(220, 27);
            tbNameCar.TabIndex = 7;
            // 
            // fBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 678);
            Controls.Add(panel1);
            Controls.Add(dataGridViewBill);
            Name = "fBill";
            Text = "fBill";
            Load += fBill_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBill).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rentDate).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewBill;
        private Panel panel1;
        private Label labelTime;
        private Button buttonCreateBill;
        private Label labelNumberDay;
        private Label labelCustomerName;
        private NumericUpDown rentDate;
        private TextBox tbNameCar;
        private DateTimePicker dtpRentDate;
        private Label label1;
        private Label label2;
        private TextBox tbTypeCar;
        private TextBox tbMoney;
        private Label lbNameCar;
        private Button button1;
        private TextBox tbCCCD;
    }
}