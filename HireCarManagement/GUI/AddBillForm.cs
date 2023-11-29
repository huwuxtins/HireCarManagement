using BUS;
using DAO;
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
    public partial class AddBillForm : Form
    {
        DTO_Car car;
        DTO_Customer customer;
        BUS_Schedule BUS_Schedule = new BUS_Schedule();
        BUS_Customer BUS_Customer = new BUS_Customer();

        public AddBillForm(DTO_Car car)
        {
            InitializeComponent();
            this.car = car;
        }

        private void fBill_Load(object sender, EventArgs e)
        {
            tbNameCar.Text = car.Name;
            tbTypeCar.Text = car.Brand;
            dtpRentDate.Text = Convert.ToString(DateTime.Now);
            tbMoney.Text = car.Price.ToString();
        }

        private void buttonCreateBill_Click(object sender, EventArgs e)
        {
            DateTime hiredAt = Convert.ToDateTime(dtpRentDate.Text);
            int amountDate = Convert.ToInt32(rentDate.Value);
            if(customer != null && !customer.Name.Equals(""))
            {
                DTO_Schedule schedule = new DTO_Schedule(Guid.NewGuid(), hiredAt, hiredAt.AddDays(amountDate), car.Price * amountDate, false , customer.Id, car.Id);
                BUS_Schedule.insertSchedule(schedule);
                MessageBox.Show("Create bill successully");
            }
            else
            {
                MessageBox.Show("Please search Customer before create bill!");
            }
        }

        private void search(object sender, EventArgs e)
        {
            string cccd = tbCCCD.Text;
            customer = BUS_Customer.getCustomerByCCCD(cccd);
            if (customer.Name == null)
            {
                MessageBox.Show("CCCD isn't used to register with us");
                fAddCustomercs fAddCustomercs = new fAddCustomercs();
                fAddCustomercs.Show();
            }
            else
            {
                MessageBox.Show(customer.Name);
            }
        }

        private void rentDate_ValueChanged(object sender, EventArgs e)
        {
            tbMoney.Text = Convert.ToString(car.Price * Convert.ToInt32(rentDate.Value));
        }
    }
}
