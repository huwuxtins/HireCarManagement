namespace DoubleT.GUI
{
    partial class fCarCondition
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dataGridViewCarCondition = new DataGridView();
            panel1 = new Panel();
            textBoxSearch = new TextBox();
            labelNhienLieu = new Label();
            labelTinhNang = new Label();
            labelLoaiXe = new Label();
            paneChonNhienLieu = new Panel();
            checkBox17 = new CheckBox();
            checkBox16 = new CheckBox();
            checkBox15 = new CheckBox();
            panelChonTinhNang = new Panel();
            checkBox11 = new CheckBox();
            checkBox12 = new CheckBox();
            checkBox13 = new CheckBox();
            checkBox14 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox9 = new CheckBox();
            checkBox10 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            panelChonOto = new Panel();
            button6 = new Button();
            button8 = new Button();
            button7 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            buttonXem = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarCondition).BeginInit();
            panel1.SuspendLayout();
            paneChonNhienLieu.SuspendLayout();
            panelChonTinhNang.SuspendLayout();
            panelChonOto.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewCarCondition
            // 
            dataGridViewCarCondition.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCarCondition.Location = new Point(551, 38);
            dataGridViewCarCondition.Name = "dataGridViewCarCondition";
            dataGridViewCarCondition.RowHeadersWidth = 51;
            dataGridViewCarCondition.RowTemplate.Height = 29;
            dataGridViewCarCondition.Size = new Size(560, 576);
            dataGridViewCarCondition.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxSearch);
            panel1.Controls.Add(labelNhienLieu);
            panel1.Controls.Add(labelTinhNang);
            panel1.Controls.Add(labelLoaiXe);
            panel1.Controls.Add(paneChonNhienLieu);
            panel1.Controls.Add(panelChonTinhNang);
            panel1.Controls.Add(panelChonOto);
            panel1.Location = new Point(12, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(533, 576);
            panel1.TabIndex = 11;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(11, 22);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(269, 27);
            textBoxSearch.TabIndex = 18;
            // 
            // labelNhienLieu
            // 
            labelNhienLieu.AutoSize = true;
            labelNhienLieu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNhienLieu.Location = new Point(10, 490);
            labelNhienLieu.Name = "labelNhienLieu";
            labelNhienLieu.Size = new Size(88, 20);
            labelNhienLieu.TabIndex = 17;
            labelNhienLieu.Text = "Nhiên liệu :";
            // 
            // labelTinhNang
            // 
            labelTinhNang.AutoSize = true;
            labelTinhNang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTinhNang.Location = new Point(11, 306);
            labelTinhNang.Name = "labelTinhNang";
            labelTinhNang.Size = new Size(87, 20);
            labelTinhNang.TabIndex = 16;
            labelTinhNang.Text = "Tính năng :";
            // 
            // labelLoaiXe
            // 
            labelLoaiXe.AutoSize = true;
            labelLoaiXe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelLoaiXe.Location = new Point(11, 76);
            labelLoaiXe.Name = "labelLoaiXe";
            labelLoaiXe.Size = new Size(66, 20);
            labelLoaiXe.TabIndex = 15;
            labelLoaiXe.Text = "Loại xe :";
            labelLoaiXe.Click += labelLoaiXe_Click;
            // 
            // paneChonNhienLieu
            // 
            paneChonNhienLieu.Controls.Add(checkBox17);
            paneChonNhienLieu.Controls.Add(checkBox16);
            paneChonNhienLieu.Controls.Add(checkBox15);
            paneChonNhienLieu.Location = new Point(5, 513);
            paneChonNhienLieu.Name = "paneChonNhienLieu";
            paneChonNhienLieu.Size = new Size(514, 48);
            paneChonNhienLieu.TabIndex = 14;
            // 
            // checkBox17
            // 
            checkBox17.AutoSize = true;
            checkBox17.Location = new Point(371, 15);
            checkBox17.Name = "checkBox17";
            checkBox17.Size = new Size(62, 24);
            checkBox17.TabIndex = 2;
            checkBox17.Text = "Điện";
            checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            checkBox16.AutoSize = true;
            checkBox16.Location = new Point(178, 15);
            checkBox16.Name = "checkBox16";
            checkBox16.Size = new Size(103, 24);
            checkBox16.TabIndex = 1;
            checkBox16.Text = "Dầu Diesel";
            checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            checkBox15.AutoSize = true;
            checkBox15.Location = new Point(8, 15);
            checkBox15.Name = "checkBox15";
            checkBox15.Size = new Size(65, 24);
            checkBox15.TabIndex = 0;
            checkBox15.Text = "Xăng";
            checkBox15.UseVisualStyleBackColor = true;
            // 
            // panelChonTinhNang
            // 
            panelChonTinhNang.Controls.Add(checkBox11);
            panelChonTinhNang.Controls.Add(checkBox12);
            panelChonTinhNang.Controls.Add(checkBox13);
            panelChonTinhNang.Controls.Add(checkBox14);
            panelChonTinhNang.Controls.Add(checkBox6);
            panelChonTinhNang.Controls.Add(checkBox7);
            panelChonTinhNang.Controls.Add(checkBox8);
            panelChonTinhNang.Controls.Add(checkBox9);
            panelChonTinhNang.Controls.Add(checkBox10);
            panelChonTinhNang.Controls.Add(checkBox5);
            panelChonTinhNang.Controls.Add(checkBox4);
            panelChonTinhNang.Controls.Add(checkBox3);
            panelChonTinhNang.Controls.Add(checkBox2);
            panelChonTinhNang.Controls.Add(checkBox1);
            panelChonTinhNang.Location = new Point(5, 329);
            panelChonTinhNang.Name = "panelChonTinhNang";
            panelChonTinhNang.Padding = new Padding(5, 0, 0, 0);
            panelChonTinhNang.Size = new Size(528, 140);
            panelChonTinhNang.TabIndex = 13;
            // 
            // checkBox11
            // 
            checkBox11.AutoSize = true;
            checkBox11.Location = new Point(381, 3);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(125, 24);
            checkBox11.TabIndex = 14;
            checkBox11.Text = "Lốp dự phòng";
            checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            checkBox12.AutoSize = true;
            checkBox12.Location = new Point(381, 83);
            checkBox12.Name = "checkBox12";
            checkBox12.Size = new Size(110, 24);
            checkBox12.TabIndex = 13;
            checkBox12.Text = "Camera 360";
            checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            checkBox13.AutoSize = true;
            checkBox13.Location = new Point(381, 53);
            checkBox13.Name = "checkBox13";
            checkBox13.Size = new Size(102, 24);
            checkBox13.TabIndex = 12;
            checkBox13.Text = "Camera lùi";
            checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            checkBox14.AutoSize = true;
            checkBox14.Location = new Point(381, 28);
            checkBox14.Name = "checkBox14";
            checkBox14.Size = new Size(141, 24);
            checkBox14.TabIndex = 11;
            checkBox14.Text = "Cảnh báo tốc độ";
            checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(188, 113);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(170, 24);
            checkBox6.TabIndex = 9;
            checkBox6.Text = "Nắp thùng xe bán tải";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(188, 83);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(96, 24);
            checkBox7.TabIndex = 8;
            checkBox7.Text = "Bluetooth";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(188, 53);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(152, 24);
            checkBox8.TabIndex = 7;
            checkBox8.Text = "Camera hành trình";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Location = new Point(188, 28);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(153, 24);
            checkBox9.TabIndex = 6;
            checkBox9.Text = "Cảm biển va chạm";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Location = new Point(188, 3);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(107, 24);
            checkBox10.TabIndex = 5;
            checkBox10.Text = "Định vị GPS";
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(18, 113);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(119, 24);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "Khe cẩm USB";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(18, 83);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(103, 24);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Cửa số trời";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(18, 53);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(120, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Cảm biển lốp";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(18, 28);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(126, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Camera cập lề";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(18, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(78, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Bản đồ";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // panelChonOto
            // 
            panelChonOto.AutoScroll = true;
            panelChonOto.Controls.Add(button6);
            panelChonOto.Controls.Add(button8);
            panelChonOto.Controls.Add(button7);
            panelChonOto.Controls.Add(button4);
            panelChonOto.Controls.Add(button3);
            panelChonOto.Controls.Add(button2);
            panelChonOto.Controls.Add(button1);
            panelChonOto.Location = new Point(5, 99);
            panelChonOto.Name = "panelChonOto";
            panelChonOto.Size = new Size(514, 188);
            panelChonOto.TabIndex = 12;
            // 
            // button6
            // 
            button6.Location = new Point(255, 92);
            button6.Name = "button6";
            button6.Size = new Size(131, 96);
            button6.TabIndex = 5;
            button6.Text = "Bán tải";
            button6.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(128, 92);
            button8.Name = "button8";
            button8.Size = new Size(131, 96);
            button8.TabIndex = 7;
            button8.Text = "7 chỗ (MPV gầm thấp)";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(0, 92);
            button7.Name = "button7";
            button7.Size = new Size(131, 96);
            button7.TabIndex = 6;
            button7.Text = "7 chỗ (SUV gầm cao)";
            button7.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(383, 0);
            button4.Name = "button4";
            button4.Size = new Size(131, 96);
            button4.TabIndex = 3;
            button4.Text = "5 chỗ (CUV gầm cao)";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(255, 0);
            button3.Name = "button3";
            button3.Size = new Size(131, 96);
            button3.TabIndex = 2;
            button3.Text = "4 chỗ (HatchBack)";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(128, 0);
            button2.Name = "button2";
            button2.Size = new Size(131, 96);
            button2.TabIndex = 1;
            button2.Text = "4 chỗ (Sedan)";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(131, 96);
            button1.TabIndex = 0;
            button1.Text = "4 chỗ (Mini)";
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonXem
            // 
            buttonXem.Location = new Point(451, 620);
            buttonXem.Name = "buttonXem";
            buttonXem.Size = new Size(94, 29);
            buttonXem.TabIndex = 12;
            buttonXem.Text = "Xem";
            buttonXem.UseVisualStyleBackColor = true;
            buttonXem.Click += buttonXem_Click;
            // 
            // fCarCondition
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 678);
            Controls.Add(buttonXem);
            Controls.Add(panel1);
            Controls.Add(dataGridViewCarCondition);
            Name = "fCarCondition";
            Text = "fCarCondition";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarCondition).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            paneChonNhienLieu.ResumeLayout(false);
            paneChonNhienLieu.PerformLayout();
            panelChonTinhNang.ResumeLayout(false);
            panelChonTinhNang.PerformLayout();
            panelChonOto.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dataGridViewCarCondition;
        private Panel panel1;
        private TextBox textBoxSearch;
        private Label labelNhienLieu;
        private Label labelTinhNang;
        private Label labelLoaiXe;
        private Panel paneChonNhienLieu;
        private CheckBox checkBox17;
        private CheckBox checkBox16;
        private CheckBox checkBox15;
        private Panel panelChonTinhNang;
        private CheckBox checkBox11;
        private CheckBox checkBox12;
        private CheckBox checkBox13;
        private CheckBox checkBox14;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private CheckBox checkBox9;
        private CheckBox checkBox10;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Panel panelChonOto;
        private Button button6;
        private Button button8;
        private Button button7;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button buttonXem;
    }
}