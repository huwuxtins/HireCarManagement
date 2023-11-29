﻿namespace DoubleT.GUI
{
    partial class fAddCar
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
            btnImport = new Button();
            panel3 = new Panel();
            rbtnElec = new RadioButton();
            rbtnDiesel = new RadioButton();
            rbtnGasoline = new RadioButton();
            panel2 = new Panel();
            chb360Cam = new CheckBox();
            chbRearCam = new CheckBox();
            chbTruckContainer = new CheckBox();
            chbBluetooth = new CheckBox();
            chbUSB = new CheckBox();
            chbFlyWindow = new CheckBox();
            chbSpeedWarning = new CheckBox();
            chbCam = new CheckBox();
            chbMap = new CheckBox();
            tbName = new TextBox();
            lbName = new Label();
            btnAdd = new Button();
            tbPrice = new TextBox();
            tbBrand = new TextBox();
            lbPrice = new Label();
            lbBrand = new Label();
            cbbType = new ComboBox();
            labelNhienLieu = new Label();
            labelTinhNang = new Label();
            labelLoaiXe = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnImport);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(tbName);
            panel1.Controls.Add(lbName);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(tbPrice);
            panel1.Controls.Add(tbBrand);
            panel1.Controls.Add(lbPrice);
            panel1.Controls.Add(lbBrand);
            panel1.Controls.Add(cbbType);
            panel1.Controls.Add(labelNhienLieu);
            panel1.Controls.Add(labelTinhNang);
            panel1.Controls.Add(labelLoaiXe);
            panel1.Location = new Point(79, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(985, 648);
            panel1.TabIndex = 13;
            // 
            // btnImport
            // 
            btnImport.BackColor = Color.FromArgb(0, 192, 0);
            btnImport.Location = new Point(786, 23);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(160, 56);
            btnImport.TabIndex = 28;
            btnImport.Text = "Import from Excel";
            btnImport.UseVisualStyleBackColor = false;
            btnImport.Click += btnImport_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(rbtnElec);
            panel3.Controls.Add(rbtnDiesel);
            panel3.Controls.Add(rbtnGasoline);
            panel3.Location = new Point(119, 560);
            panel3.Name = "panel3";
            panel3.Size = new Size(528, 48);
            panel3.TabIndex = 15;
            // 
            // rbtnElec
            // 
            rbtnElec.AutoSize = true;
            rbtnElec.Location = new Point(386, 14);
            rbtnElec.Name = "rbtnElec";
            rbtnElec.Size = new Size(78, 24);
            rbtnElec.TabIndex = 29;
            rbtnElec.TabStop = true;
            rbtnElec.Text = "Electric";
            rbtnElec.UseVisualStyleBackColor = true;
            // 
            // rbtnDiesel
            // 
            rbtnDiesel.AutoSize = true;
            rbtnDiesel.Location = new Point(193, 14);
            rbtnDiesel.Name = "rbtnDiesel";
            rbtnDiesel.Size = new Size(71, 24);
            rbtnDiesel.TabIndex = 28;
            rbtnDiesel.TabStop = true;
            rbtnDiesel.Text = "Diesel";
            rbtnDiesel.UseVisualStyleBackColor = true;
            // 
            // rbtnGasoline
            // 
            rbtnGasoline.AutoSize = true;
            rbtnGasoline.Location = new Point(9, 14);
            rbtnGasoline.Name = "rbtnGasoline";
            rbtnGasoline.Size = new Size(87, 24);
            rbtnGasoline.TabIndex = 3;
            rbtnGasoline.TabStop = true;
            rbtnGasoline.Text = "Gasoline";
            rbtnGasoline.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(chb360Cam);
            panel2.Controls.Add(chbRearCam);
            panel2.Controls.Add(chbTruckContainer);
            panel2.Controls.Add(chbBluetooth);
            panel2.Controls.Add(chbUSB);
            panel2.Controls.Add(chbFlyWindow);
            panel2.Controls.Add(chbSpeedWarning);
            panel2.Controls.Add(chbCam);
            panel2.Controls.Add(chbMap);
            panel2.Location = new Point(119, 364);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5, 0, 0, 0);
            panel2.Size = new Size(528, 140);
            panel2.TabIndex = 14;
            // 
            // chb360Cam
            // 
            chb360Cam.AutoSize = true;
            chb360Cam.Location = new Point(316, 3);
            chb360Cam.Name = "chb360Cam";
            chb360Cam.Size = new Size(110, 24);
            chb360Cam.TabIndex = 13;
            chb360Cam.Text = "Camera 360";
            chb360Cam.UseVisualStyleBackColor = true;
            // 
            // chbRearCam
            // 
            chbRearCam.AutoSize = true;
            chbRearCam.Location = new Point(316, 30);
            chbRearCam.Name = "chbRearCam";
            chbRearCam.Size = new Size(114, 24);
            chbRearCam.TabIndex = 12;
            chbRearCam.Text = "Rear camera";
            chbRearCam.UseVisualStyleBackColor = true;
            // 
            // chbTruckContainer
            // 
            chbTruckContainer.AutoSize = true;
            chbTruckContainer.Location = new Point(316, 57);
            chbTruckContainer.Name = "chbTruckContainer";
            chbTruckContainer.Size = new Size(131, 24);
            chbTruckContainer.TabIndex = 9;
            chbTruckContainer.Text = "Truck container";
            chbTruckContainer.UseVisualStyleBackColor = true;
            // 
            // chbBluetooth
            // 
            chbBluetooth.AutoSize = true;
            chbBluetooth.Location = new Point(316, 84);
            chbBluetooth.Name = "chbBluetooth";
            chbBluetooth.Size = new Size(96, 24);
            chbBluetooth.TabIndex = 8;
            chbBluetooth.Text = "Bluetooth";
            chbBluetooth.UseVisualStyleBackColor = true;
            // 
            // chbUSB
            // 
            chbUSB.AutoSize = true;
            chbUSB.Location = new Point(28, 111);
            chbUSB.Name = "chbUSB";
            chbUSB.Size = new Size(58, 24);
            chbUSB.TabIndex = 4;
            chbUSB.Text = "USB";
            chbUSB.UseVisualStyleBackColor = true;
            // 
            // chbFlyWindow
            // 
            chbFlyWindow.AutoSize = true;
            chbFlyWindow.Location = new Point(28, 84);
            chbFlyWindow.Name = "chbFlyWindow";
            chbFlyWindow.Size = new Size(105, 24);
            chbFlyWindow.TabIndex = 3;
            chbFlyWindow.Text = "Fly window";
            chbFlyWindow.UseVisualStyleBackColor = true;
            // 
            // chbSpeedWarning
            // 
            chbSpeedWarning.AutoSize = true;
            chbSpeedWarning.Location = new Point(28, 57);
            chbSpeedWarning.Name = "chbSpeedWarning";
            chbSpeedWarning.Size = new Size(130, 24);
            chbSpeedWarning.TabIndex = 2;
            chbSpeedWarning.Text = "Speed warning";
            chbSpeedWarning.UseVisualStyleBackColor = true;
            // 
            // chbCam
            // 
            chbCam.AutoSize = true;
            chbCam.Location = new Point(28, 30);
            chbCam.Name = "chbCam";
            chbCam.Size = new Size(82, 24);
            chbCam.TabIndex = 1;
            chbCam.Text = "Camera";
            chbCam.UseVisualStyleBackColor = true;
            // 
            // chbMap
            // 
            chbMap.AutoSize = true;
            chbMap.Location = new Point(28, 3);
            chbMap.Name = "chbMap";
            chbMap.Size = new Size(61, 24);
            chbMap.TabIndex = 0;
            chbMap.Text = "Map";
            chbMap.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            tbName.Location = new Point(119, 52);
            tbName.Name = "tbName";
            tbName.Size = new Size(194, 27);
            tbName.TabIndex = 27;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbName.Location = new Point(119, 29);
            lbName.Name = "lbName";
            lbName.Size = new Size(59, 20);
            lbName.TabIndex = 26;
            lbName.Text = "Name: ";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 0, 192);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(841, 560);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(121, 48);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += BtnAdd_Click;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(119, 165);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(194, 27);
            tbPrice.TabIndex = 22;
            // 
            // tbBrand
            // 
            tbBrand.Location = new Point(435, 287);
            tbBrand.Name = "tbBrand";
            tbBrand.Size = new Size(194, 27);
            tbBrand.TabIndex = 21;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbPrice.Location = new Point(119, 130);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(126, 20);
            lbPrice.TabIndex = 20;
            lbPrice.Text = "Price VND/date :";
            // 
            // lbBrand
            // 
            lbBrand.AutoSize = true;
            lbBrand.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbBrand.Location = new Point(435, 248);
            lbBrand.Name = "lbBrand";
            lbBrand.Size = new Size(59, 20);
            lbBrand.TabIndex = 19;
            lbBrand.Text = "Brand: ";
            // 
            // cbbType
            // 
            cbbType.FormattingEnabled = true;
            cbbType.Items.AddRange(new object[] { "4 chổ (Mini)", "4 chổ (Sedan)", "4 chổ (Hatchback)", "5 chổ (CUV gầm cao)", "7 chổ (SUV gầm cao)", "7 chổ (MPV gầm thấp)", "Bán tải" });
            cbbType.Location = new Point(119, 287);
            cbbType.Name = "cbbType";
            cbbType.Size = new Size(194, 28);
            cbbType.TabIndex = 18;
            // 
            // labelNhienLieu
            // 
            labelNhienLieu.AutoSize = true;
            labelNhienLieu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNhienLieu.Location = new Point(119, 537);
            labelNhienLieu.Name = "labelNhienLieu";
            labelNhienLieu.Size = new Size(53, 20);
            labelNhienLieu.TabIndex = 17;
            labelNhienLieu.Text = "Fuels :";
            // 
            // labelTinhNang
            // 
            labelTinhNang.AutoSize = true;
            labelTinhNang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTinhNang.Location = new Point(119, 341);
            labelTinhNang.Name = "labelTinhNang";
            labelTinhNang.Size = new Size(77, 20);
            labelTinhNang.TabIndex = 16;
            labelTinhNang.Text = "Features :";
            // 
            // labelLoaiXe
            // 
            labelLoaiXe.AutoSize = true;
            labelLoaiXe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelLoaiXe.Location = new Point(119, 248);
            labelLoaiXe.Name = "labelLoaiXe";
            labelLoaiXe.Size = new Size(50, 20);
            labelLoaiXe.TabIndex = 15;
            labelLoaiXe.Text = "Type :";
            // 
            // fAddCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 678);
            Controls.Add(panel1);
            Name = "fAddCar";
            Text = "AddOto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAdd;
        private TextBox tbPrice;
        private TextBox tbBrand;
        private Label lbPrice;
        private Label lbBrand;
        private ComboBox cbbType;
        private Label labelNhienLieu;
        private Label labelTinhNang;
        private Label labelLoaiXe;
        private TextBox tbName;
        private Label lbName;
        private Panel panel2;
        private CheckBox chb360Cam;
        private CheckBox chbRearCam;
        private CheckBox chbTruckContainer;
        private CheckBox chbBluetooth;
        private CheckBox chbUSB;
        private CheckBox chbFlyWindow;
        private CheckBox chbSpeedWarning;
        private CheckBox chbCam;
        private CheckBox chbMap;
        private Panel panel3;
        private RadioButton rbtnElec;
        private RadioButton rbtnDiesel;
        private RadioButton rbtnGasoline;
        private Button btnImport;
    }
}