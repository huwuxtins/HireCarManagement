using BUS;
using DAO;
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
    public partial class fAddCustomercs : Form
    {
        BUS_Customer BUS_Customer = new BUS_Customer();
        public fAddCustomercs()
        {
            InitializeComponent();
        }

        private void fAddCustomercs_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string phoneNumber = tbPhoneNumber.Text;
            string address = tbAddress.Text;
            string cccd = tbCCCD.Text;

            DTO_Customer customer = new DTO_Customer(Guid.NewGuid(), name, phoneNumber, address, cccd);
            BUS_Customer.createAccount(customer);
            MessageBox.Show("Add customer successfully!");
            Hide();
        }
    }
}
