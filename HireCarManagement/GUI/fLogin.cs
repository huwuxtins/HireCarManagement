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

namespace DoubleT.GUI
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        BUS_Employee bus_employee = new BUS_Employee();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string password = tbPassword.Text;

            var employee = bus_employee.loginAccount(new DTO_Employee(email, password));
            if (!employee.Name.Equals(""))
            {
                this.Hide();
                fHome fhome = new fHome(employee);
                fhome.Show();
            }
            else
            {
                MessageBox.Show("Email or password is not correct, please check then try again");
            }
        }

        private void exit(object sender, EventArgs e)
        {
            Close();
        }
    }
}
