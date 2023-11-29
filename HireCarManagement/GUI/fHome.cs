using DTO;
using HireCarManagement;
using HireCarManagement.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleT.GUI
{
    public partial class fHome : Form
    {
        DTO_Employee employee;
        public fHome(DTO_Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void buttonOto_Click(object sender, EventArgs e)
        {
            openChildForm(new FOto(employee));
        }

        private void buttonKhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new fCustomer());
        }

        private void buttonDonHang_Click(object sender, EventArgs e)
        {
            openChildForm(new BillsForm());
        }

        private void buttonLichTrinh_Click(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelChildForm.Controls.Add(childForm);

            childForm.BringToFront();
            childForm.Show();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            openChildForm(new fPayment());
        }

        private void buttonThongKe_Click(object sender, EventArgs e)
        {
            openChildForm(new fStatictical());
        }

        private void buttonThueXe_Click(object sender, EventArgs e)
        {
            openChildForm(new fRentCar());
        }

        private void buttonTinhTrangXe_Click(object sender, EventArgs e)
        {
            openChildForm(new FOto(employee));
        }

        private void load(object sender, EventArgs e)
        {
            if (employee.ROLE.Equals("ROLE_ADMIN"))
            {
                btnEmployee.Visible = true;
            }
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            openChildForm(new EmployeesForm());
        }
    }
}
