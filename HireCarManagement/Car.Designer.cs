namespace HireCarManagement
{
    partial class Car
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Car));
            ptbCar = new PictureBox();
            lbNameCar = new Label();
            lbPrice = new Label();
            lbType = new Label();
            label2 = new Label();
            lbFree = new Label();
            ((System.ComponentModel.ISupportInitialize)ptbCar).BeginInit();
            SuspendLayout();
            // 
            // ptbCar
            // 
            ptbCar.Image = (Image)resources.GetObject("ptbCar.Image");
            ptbCar.Location = new Point(16, 26);
            ptbCar.Name = "ptbCar";
            ptbCar.Size = new Size(100, 100);
            ptbCar.SizeMode = PictureBoxSizeMode.CenterImage;
            ptbCar.TabIndex = 0;
            ptbCar.TabStop = false;
            // 
            // lbNameCar
            // 
            lbNameCar.AutoSize = true;
            lbNameCar.Location = new Point(141, 26);
            lbNameCar.Name = "lbNameCar";
            lbNameCar.Size = new Size(88, 20);
            lbNameCar.TabIndex = 1;
            lbNameCar.Text = "Car's name: ";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(142, 106);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(48, 20);
            lbPrice.TabIndex = 2;
            lbPrice.Text = "Price :";
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Location = new Point(142, 66);
            lbType.Name = "lbType";
            lbType.Size = new Size(80, 20);
            lbType.TabIndex = 3;
            lbType.Text = "Car's type: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 106);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 4;
            label2.Text = "VND/date";
            // 
            // lbFree
            // 
            lbFree.AutoSize = true;
            lbFree.BackColor = Color.Lime;
            lbFree.ForeColor = SystemColors.ControlText;
            lbFree.Location = new Point(408, 96);
            lbFree.Name = "lbFree";
            lbFree.Padding = new Padding(5);
            lbFree.Size = new Size(61, 30);
            lbFree.TabIndex = 5;
            lbFree.Text = "Empty";
            // 
            // Car
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lbFree);
            Controls.Add(label2);
            Controls.Add(lbType);
            Controls.Add(lbPrice);
            Controls.Add(lbNameCar);
            Controls.Add(ptbCar);
            Name = "Car";
            Size = new Size(487, 150);
            Load += load;
            ((System.ComponentModel.ISupportInitialize)ptbCar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ptbCar;
        private Label lbNameCar;
        private Label lbPrice;
        private Label lbType;
        private Label label2;
        private Label lbFree;
    }
}
