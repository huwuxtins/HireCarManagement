namespace DoubleT.GUI
{
    partial class fCustomer
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
            dgvCustomer = new DataGridView();
            tbSearch = new TextBox();
            panelThaoTac = new Panel();
            buttonEdit = new Button();
            buttonDelete = new Button();
            buttonAdd = new Button();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            panelThaoTac.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCustomer
            // 
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Location = new Point(149, 106);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.RowTemplate.Height = 29;
            dgvCustomer.Size = new Size(865, 435);
            dgvCustomer.TabIndex = 0;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(149, 52);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(245, 27);
            tbSearch.TabIndex = 1;
            // 
            // panelThaoTac
            // 
            panelThaoTac.Controls.Add(buttonEdit);
            panelThaoTac.Controls.Add(buttonDelete);
            panelThaoTac.Controls.Add(buttonAdd);
            panelThaoTac.Location = new Point(432, 563);
            panelThaoTac.Name = "panelThaoTac";
            panelThaoTac.Size = new Size(582, 87);
            panelThaoTac.TabIndex = 5;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(458, 36);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(94, 29);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Sửa";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(271, 36);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Xóa";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(67, 36);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Thêm ";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(400, 52);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // fCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1142, 678);
            Controls.Add(btnSearch);
            Controls.Add(panelThaoTac);
            Controls.Add(tbSearch);
            Controls.Add(dgvCustomer);
            Name = "fCustomer";
            Text = "fCustomer";
            Load += fCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            panelThaoTac.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCustomer;
        private TextBox tbSearch;
        private Panel panelThaoTac;
        private Button buttonEdit;
        private Button buttonDelete;
        private Button buttonAdd;
        private Button btnSearch;
    }
}