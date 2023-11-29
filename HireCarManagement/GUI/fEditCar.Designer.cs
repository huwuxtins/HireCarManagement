namespace DoubleT.GUI
{
    partial class fEditCar
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
            tbBrand = new TextBox();
            lbBrand = new Label();
            btnSave = new Button();
            tbPrice = new TextBox();
            tbName = new TextBox();
            lbPrice = new Label();
            lbName = new Label();
            cbbType = new ComboBox();
            labelNhienLieu = new Label();
            lbFeature = new Label();
            lbType = new Label();
            paneChonNhienLieu = new Panel();
            rbtnElec = new RadioButton();
            rbtnDiesel = new RadioButton();
            rbtnGasoline = new RadioButton();
            panelChonTinhNang = new Panel();
            chb360Cam = new CheckBox();
            chbRearCam = new CheckBox();
            chbTruckContainer = new CheckBox();
            chbBluetooth = new CheckBox();
            chbUSB = new CheckBox();
            chbFlyWindow = new CheckBox();
            chbSpeedWarning = new CheckBox();
            chbCam = new CheckBox();
            chbMap = new CheckBox();
            panel1.SuspendLayout();
            paneChonNhienLieu.SuspendLayout();
            panelChonTinhNang.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tbBrand);
            panel1.Controls.Add(lbBrand);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(tbPrice);
            panel1.Controls.Add(tbName);
            panel1.Controls.Add(lbPrice);
            panel1.Controls.Add(lbName);
            panel1.Controls.Add(cbbType);
            panel1.Controls.Add(labelNhienLieu);
            panel1.Controls.Add(lbFeature);
            panel1.Controls.Add(lbType);
            panel1.Controls.Add(paneChonNhienLieu);
            panel1.Controls.Add(panelChonTinhNang);
            panel1.Location = new Point(38, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(985, 648);
            panel1.TabIndex = 12;
            // 
            // tbBrand
            // 
            tbBrand.Location = new Point(430, 288);
            tbBrand.Name = "tbBrand";
            tbBrand.Size = new Size(194, 27);
            tbBrand.TabIndex = 27;
            // 
            // lbBrand
            // 
            lbBrand.AutoSize = true;
            lbBrand.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbBrand.Location = new Point(430, 248);
            lbBrand.Name = "lbBrand";
            lbBrand.Size = new Size(59, 20);
            lbBrand.TabIndex = 26;
            lbBrand.Text = "Brand: ";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(867, 589);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 25;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(119, 165);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(194, 27);
            tbPrice.TabIndex = 22;
            // 
            // tbName
            // 
            tbName.Location = new Point(119, 51);
            tbName.Name = "tbName";
            tbName.Size = new Size(194, 27);
            tbName.TabIndex = 21;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbPrice.Location = new Point(119, 130);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(138, 20);
            lbPrice.TabIndex = 20;
            lbPrice.Text = "Price (VND/date) :";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbName.Location = new Point(119, 16);
            lbName.Name = "lbName";
            lbName.Size = new Size(59, 20);
            lbName.TabIndex = 19;
            lbName.Text = "Name :";
            // 
            // cbbType
            // 
            cbbType.FormattingEnabled = true;
            cbbType.Items.AddRange(new object[] { "Mini", "Sedan", "Hatchback", "CUV", "SUV", "MPV", "Truck" });
            cbbType.Location = new Point(119, 287);
            cbbType.Name = "cbbType";
            cbbType.Size = new Size(151, 28);
            cbbType.TabIndex = 18;
            // 
            // labelNhienLieu
            // 
            labelNhienLieu.AutoSize = true;
            labelNhienLieu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNhienLieu.Location = new Point(119, 537);
            labelNhienLieu.Name = "labelNhienLieu";
            labelNhienLieu.Size = new Size(46, 20);
            labelNhienLieu.TabIndex = 17;
            labelNhienLieu.Text = "Fuel :";
            // 
            // lbFeature
            // 
            lbFeature.AutoSize = true;
            lbFeature.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbFeature.Location = new Point(119, 341);
            lbFeature.Name = "lbFeature";
            lbFeature.Size = new Size(77, 20);
            lbFeature.TabIndex = 16;
            lbFeature.Text = "Features :";
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbType.Location = new Point(119, 248);
            lbType.Name = "lbType";
            lbType.Size = new Size(50, 20);
            lbType.TabIndex = 15;
            lbType.Text = "Type :";
            // 
            // paneChonNhienLieu
            // 
            paneChonNhienLieu.Controls.Add(rbtnElec);
            paneChonNhienLieu.Controls.Add(rbtnDiesel);
            paneChonNhienLieu.Controls.Add(rbtnGasoline);
            paneChonNhienLieu.Location = new Point(119, 570);
            paneChonNhienLieu.Name = "paneChonNhienLieu";
            paneChonNhienLieu.Size = new Size(528, 48);
            paneChonNhienLieu.TabIndex = 14;
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
            // panelChonTinhNang
            // 
            panelChonTinhNang.Controls.Add(chb360Cam);
            panelChonTinhNang.Controls.Add(chbRearCam);
            panelChonTinhNang.Controls.Add(chbTruckContainer);
            panelChonTinhNang.Controls.Add(chbBluetooth);
            panelChonTinhNang.Controls.Add(chbUSB);
            panelChonTinhNang.Controls.Add(chbFlyWindow);
            panelChonTinhNang.Controls.Add(chbSpeedWarning);
            panelChonTinhNang.Controls.Add(chbCam);
            panelChonTinhNang.Controls.Add(chbMap);
            panelChonTinhNang.Location = new Point(119, 373);
            panelChonTinhNang.Name = "panelChonTinhNang";
            panelChonTinhNang.Padding = new Padding(5, 0, 0, 0);
            panelChonTinhNang.Size = new Size(528, 140);
            panelChonTinhNang.TabIndex = 13;
            // 
            // chb360Cam
            // 
            chb360Cam.AutoSize = true;
            chb360Cam.Location = new Point(311, 3);
            chb360Cam.Name = "chb360Cam";
            chb360Cam.Size = new Size(110, 24);
            chb360Cam.TabIndex = 13;
            chb360Cam.Text = "Camera 360";
            chb360Cam.UseVisualStyleBackColor = true;
            // 
            // chbRearCam
            // 
            chbRearCam.AutoSize = true;
            chbRearCam.Location = new Point(311, 30);
            chbRearCam.Name = "chbRearCam";
            chbRearCam.Size = new Size(114, 24);
            chbRearCam.TabIndex = 12;
            chbRearCam.Text = "Rear camera";
            chbRearCam.UseVisualStyleBackColor = true;
            // 
            // chbTruckContainer
            // 
            chbTruckContainer.AutoSize = true;
            chbTruckContainer.Location = new Point(311, 57);
            chbTruckContainer.Name = "chbTruckContainer";
            chbTruckContainer.Size = new Size(131, 24);
            chbTruckContainer.TabIndex = 9;
            chbTruckContainer.Text = "Truck container";
            chbTruckContainer.UseVisualStyleBackColor = true;
            // 
            // chbBluetooth
            // 
            chbBluetooth.AutoSize = true;
            chbBluetooth.Location = new Point(311, 84);
            chbBluetooth.Name = "chbBluetooth";
            chbBluetooth.Size = new Size(96, 24);
            chbBluetooth.TabIndex = 8;
            chbBluetooth.Text = "Bluetooth";
            chbBluetooth.UseVisualStyleBackColor = true;
            // 
            // chbUSB
            // 
            chbUSB.AutoSize = true;
            chbUSB.Location = new Point(23, 111);
            chbUSB.Name = "chbUSB";
            chbUSB.Size = new Size(58, 24);
            chbUSB.TabIndex = 4;
            chbUSB.Text = "USB";
            chbUSB.UseVisualStyleBackColor = true;
            // 
            // chbFlyWindow
            // 
            chbFlyWindow.AutoSize = true;
            chbFlyWindow.Location = new Point(23, 84);
            chbFlyWindow.Name = "chbFlyWindow";
            chbFlyWindow.Size = new Size(105, 24);
            chbFlyWindow.TabIndex = 3;
            chbFlyWindow.Text = "Fly window";
            chbFlyWindow.UseVisualStyleBackColor = true;
            // 
            // chbSpeedWarning
            // 
            chbSpeedWarning.AutoSize = true;
            chbSpeedWarning.Location = new Point(23, 57);
            chbSpeedWarning.Name = "chbSpeedWarning";
            chbSpeedWarning.Size = new Size(130, 24);
            chbSpeedWarning.TabIndex = 2;
            chbSpeedWarning.Text = "Speed warning";
            chbSpeedWarning.UseVisualStyleBackColor = true;
            // 
            // chbCam
            // 
            chbCam.AutoSize = true;
            chbCam.Location = new Point(23, 30);
            chbCam.Name = "chbCam";
            chbCam.Size = new Size(82, 24);
            chbCam.TabIndex = 1;
            chbCam.Text = "Camera";
            chbCam.UseVisualStyleBackColor = true;
            // 
            // chbMap
            // 
            chbMap.AutoSize = true;
            chbMap.Location = new Point(23, 3);
            chbMap.Name = "chbMap";
            chbMap.Size = new Size(61, 24);
            chbMap.TabIndex = 0;
            chbMap.Text = "Map";
            chbMap.UseVisualStyleBackColor = true;
            // 
            // fEditCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 678);
            Controls.Add(panel1);
            Name = "fEditCar";
            Text = "fEditCar";
            Load += fEditCar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            paneChonNhienLieu.ResumeLayout(false);
            paneChonNhienLieu.PerformLayout();
            panelChonTinhNang.ResumeLayout(false);
            panelChonTinhNang.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSave;
        private TextBox tbPrice;
        private TextBox tbName;
        private Label lbPrice;
        private Label lbName;
        private ComboBox cbbType;
        private Label labelNhienLieu;
        private Label lbFeature;
        private Label lbType;
        private Panel paneChonNhienLieu;
        private Panel panelChonTinhNang;
        private CheckBox chb360Cam;
        private CheckBox chbRearCam;
        private CheckBox chbTruckContainer;
        private CheckBox chbBluetooth;
        private CheckBox chbUSB;
        private CheckBox chbFlyWindow;
        private CheckBox chbSpeedWarning;
        private CheckBox chbCam;
        private CheckBox chbMap;
        private TextBox tbBrand;
        private Label lbBrand;
        private RadioButton rbtnDiesel;
        private RadioButton rbtnGasoline;
        private RadioButton rbtnElec;
    }
}