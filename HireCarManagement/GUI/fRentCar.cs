using BUS;
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
    public partial class fRentCar : Form
    {
        BUS_Schedule BUS_Schedule = new BUS_Schedule();
        public fRentCar()
        {
            InitializeComponent();
        }

        private void load(object sender, EventArgs e)
        {
            DataTable schedules = BUS_Schedule.showAllSchedules();
            dgvSchedule.DataSource = schedules;
        }
    }
}
