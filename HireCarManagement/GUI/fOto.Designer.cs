namespace DoubleT.GUI
{
    partial class FOto
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
            panelChonOto = new Panel();
            btnTruck = new Button();
            btnMPV = new Button();
            btnSUV = new Button();
            btnCUV = new Button();
            btnHatchback = new Button();
            btnSedan = new Button();
            btnMini = new Button();
            labelLoaiXe = new Label();
            labelTinhNang = new Label();
            labelNhienLieu = new Label();
            tbSearch = new TextBox();
            panel1 = new Panel();
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
            btnSearch = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panelThaoTac = new Panel();
            btnBook = new Button();
            btnEdit = new Button();
            btnRemove = new Button();
            btnAdd = new Button();
            flpCar = new FlowLayoutPanel();
            panelChonOto.SuspendLayout();
            panel1.SuspendLayout();
            paneChonNhienLieu.SuspendLayout();
            panelChonTinhNang.SuspendLayout();
            panelThaoTac.SuspendLayout();
            SuspendLayout();
            // 
            // panelChonOto
            // 
            panelChonOto.AutoScroll = true;
            panelChonOto.Controls.Add(btnTruck);
            panelChonOto.Controls.Add(btnMPV);
            panelChonOto.Controls.Add(btnSUV);
            panelChonOto.Controls.Add(btnCUV);
            panelChonOto.Controls.Add(btnHatchback);
            panelChonOto.Controls.Add(btnSedan);
            panelChonOto.Controls.Add(btnMini);
            panelChonOto.Location = new Point(5, 99);
            panelChonOto.Name = "panelChonOto";
            panelChonOto.Size = new Size(525, 188);
            panelChonOto.TabIndex = 12;
            // 
            // btnTruck
            // 
            btnTruck.Location = new Point(255, 92);
            btnTruck.Name = "btnTruck";
            btnTruck.Size = new Size(131, 96);
            btnTruck.TabIndex = 5;
            btnTruck.Text = "Bán tải";
            btnTruck.UseVisualStyleBackColor = true;
            btnTruck.Click += btnTruck_Click;
            // 
            // btnMPV
            // 
            btnMPV.Location = new Point(128, 92);
            btnMPV.Name = "btnMPV";
            btnMPV.Size = new Size(131, 96);
            btnMPV.TabIndex = 7;
            btnMPV.Text = "7 chỗ (MPV gầm thấp)";
            btnMPV.UseVisualStyleBackColor = true;
            btnMPV.Click += btnMPV_Click;
            // 
            // btnSUV
            // 
            btnSUV.Location = new Point(0, 92);
            btnSUV.Name = "btnSUV";
            btnSUV.Size = new Size(131, 96);
            btnSUV.TabIndex = 6;
            btnSUV.Text = "7 chỗ (SUV gầm cao)";
            btnSUV.UseVisualStyleBackColor = true;
            btnSUV.Click += btnSUV_Click;
            // 
            // btnCUV
            // 
            btnCUV.Location = new Point(383, 0);
            btnCUV.Name = "btnCUV";
            btnCUV.Size = new Size(131, 96);
            btnCUV.TabIndex = 3;
            btnCUV.Text = "5 chỗ (CUV gầm cao)";
            btnCUV.UseVisualStyleBackColor = true;
            btnCUV.Click += btnCUV_Click;
            // 
            // btnHatchback
            // 
            btnHatchback.Location = new Point(255, 0);
            btnHatchback.Name = "btnHatchback";
            btnHatchback.Size = new Size(131, 96);
            btnHatchback.TabIndex = 2;
            btnHatchback.Text = "4 chỗ (HatchBack)";
            btnHatchback.UseVisualStyleBackColor = true;
            btnHatchback.Click += btnHatchback_Click;
            // 
            // btnSedan
            // 
            btnSedan.Location = new Point(128, 0);
            btnSedan.Name = "btnSedan";
            btnSedan.Size = new Size(131, 96);
            btnSedan.TabIndex = 1;
            btnSedan.Text = "4 chỗ (Sedan)";
            btnSedan.UseVisualStyleBackColor = true;
            btnSedan.Click += btnSedan_Click;
            // 
            // btnMini
            // 
            btnMini.Location = new Point(0, 0);
            btnMini.Name = "btnMini";
            btnMini.Size = new Size(131, 96);
            btnMini.TabIndex = 0;
            btnMini.Text = "4 chỗ (Mini)";
            btnMini.UseVisualStyleBackColor = true;
            btnMini.Click += btnMini_Click;
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
            // tbSearch
            // 
            tbSearch.Location = new Point(11, 22);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(289, 27);
            tbSearch.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.Controls.Add(paneChonNhienLieu);
            panel1.Controls.Add(panelChonTinhNang);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(tbSearch);
            panel1.Controls.Add(labelNhienLieu);
            panel1.Controls.Add(labelTinhNang);
            panel1.Controls.Add(labelLoaiXe);
            panel1.Controls.Add(panelChonOto);
            panel1.Location = new Point(22, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(533, 576);
            panel1.TabIndex = 14;
            // 
            // paneChonNhienLieu
            // 
            paneChonNhienLieu.Controls.Add(rbtnElec);
            paneChonNhienLieu.Controls.Add(rbtnDiesel);
            paneChonNhienLieu.Controls.Add(rbtnGasoline);
            paneChonNhienLieu.Location = new Point(5, 513);
            paneChonNhienLieu.Name = "paneChonNhienLieu";
            paneChonNhienLieu.Size = new Size(528, 48);
            paneChonNhienLieu.TabIndex = 15;
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
            rbtnElec.Click += SearchByFuel;
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
            rbtnDiesel.Click += SearchByFuel;
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
            rbtnGasoline.Click += SearchByFuel;
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
            panelChonTinhNang.Location = new Point(5, 329);
            panelChonTinhNang.Name = "panelChonTinhNang";
            panelChonTinhNang.Padding = new Padding(5, 0, 0, 0);
            panelChonTinhNang.Size = new Size(528, 140);
            panelChonTinhNang.TabIndex = 20;
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
            chb360Cam.CheckedChanged += SearchByFeatures;
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
            chbRearCam.CheckedChanged += SearchByFeatures;
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
            chbTruckContainer.CheckedChanged += SearchByFeatures;
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
            chbBluetooth.CheckedChanged += SearchByFeatures;
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
            chbUSB.CheckedChanged += SearchByFeatures;
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
            chbFlyWindow.CheckedChanged += SearchByFeatures;
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
            chbSpeedWarning.CheckedChanged += SearchByFeatures;
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
            chbCam.CheckedChanged += SearchByFeatures;
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
            chbMap.CheckedChanged += SearchByFeatures;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(306, 22);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // panelThaoTac
            // 
            panelThaoTac.Controls.Add(btnBook);
            panelThaoTac.Controls.Add(btnEdit);
            panelThaoTac.Controls.Add(btnRemove);
            panelThaoTac.Controls.Add(btnAdd);
            panelThaoTac.Location = new Point(561, 616);
            panelThaoTac.Name = "panelThaoTac";
            panelThaoTac.Size = new Size(560, 55);
            panelThaoTac.TabIndex = 15;
            // 
            // btnBook
            // 
            btnBook.Location = new Point(439, 13);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(94, 29);
            btnBook.TabIndex = 3;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += buttonPickCar_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(303, 13);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += buttonEdit_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(149, 13);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 13);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // flpCar
            // 
            flpCar.AutoScroll = true;
            flpCar.BackColor = Color.Silver;
            flpCar.FlowDirection = FlowDirection.TopDown;
            flpCar.Location = new Point(561, 34);
            flpCar.Name = "flpCar";
            flpCar.Size = new Size(505, 576);
            flpCar.TabIndex = 16;
            flpCar.WrapContents = false;
            // 
            // FOto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 678);
            Controls.Add(flpCar);
            Controls.Add(panelThaoTac);
            Controls.Add(panel1);
            Name = "FOto";
            Text = "Oto";
            Load += load;
            panelChonOto.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            paneChonNhienLieu.ResumeLayout(false);
            paneChonNhienLieu.PerformLayout();
            panelChonTinhNang.ResumeLayout(false);
            panelChonTinhNang.PerformLayout();
            panelThaoTac.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelChonOto;
        private Button btnTruck;
        private Button btnMPV;
        private Button btnSUV;
        private Button btnCUV;
        private Button btnHatchback;
        private Button btnSedan;
        private Button btnMini;
        private Label labelLoaiXe;
        private Label labelTinhNang;
        private Label labelNhienLieu;
        private TextBox tbSearch;
        private Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panelThaoTac;
        private Button btnBook;
        private Button btnEdit;
        private Button btnRemove;
        private Button btnAdd;
        private FlowLayoutPanel flpCar;
        private Button btnSearch;
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
        private Panel paneChonNhienLieu;
        private RadioButton rbtnElec;
        private RadioButton rbtnDiesel;
        private RadioButton rbtnGasoline;
    }
}