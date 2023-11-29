using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HireCarManagement.GUI
{
    public partial class AddEmployee : Form
    {
        BUS_Employee BUS_Employee = new();
        DTO_Employee employee;
        public event EventHandler FormClosedEvent;
        public AddEmployee()
        {
            InitializeComponent();
        }

        public AddEmployee(DTO_Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void FormLoad(object sender, EventArgs e)
        {
            if(employee != null)
            {
                btnAdd.Visible = false;
                btnSave.Visible = true;
                tbName.Text = employee.Name;
                tbEmail.Text = employee.Email;
                tbPassword.Text = employee.Password;
                cbbROLE.Text = employee.ROLE;
            }
            else
            {
                btnAdd.Visible = true;
                btnSave.Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DTO_Employee employee = new DTO_Employee()
            {
                Id = Guid.NewGuid(),
                Name = tbName.Text,
                Email = tbEmail.Text,
                Password = tbPassword.Text,
                ROLE = cbbROLE.Text,
            };

            BUS_Employee.createAccount(employee);
            MessageBox.Show("Add employee successuly!");

            Hide();
            OnFormClosedEvent();
        }

        protected virtual void OnFormClosedEvent()
        {
            FormClosedEvent?.Invoke(this, EventArgs.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employee.Name = tbName.Text;
            employee.Email = tbEmail.Text;
            employee.Password = tbPassword.Text;
            employee.ROLE = cbbROLE.Text;   
            BUS_Employee.updateAccout(employee);
            MessageBox.Show("Update employee successuly!");

            Hide();
            OnFormClosedEvent();
        }
    }
}
