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
    public partial class fCustomer : Form
    {
        BUS_Customer bUS_Customer = new();
        DataTable customers;
        public fCustomer()
        {
            InitializeComponent();
        }

        private void fCustomer_Load(object sender, EventArgs e)
        {
            customers = bUS_Customer.showAllCustomer();
            dgvCustomer.DataSource = customers;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchStr = tbSearch.Text;
            List<DTO_Customer> searchCustomer = new();
            foreach(DataRow row in customers.Rows)
            {
                searchCustomer.Add(new DTO_Customer(
                    Guid.Parse(row[0].ToString()),
                    row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString()));
            }
            searchCustomer = searchCustomer.Where(customer => customer.Name.Contains(searchStr)).ToList();
            dgvCustomer.DataSource=searchCustomer;
        }
    }
}
