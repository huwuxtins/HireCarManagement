using BUS;
using DTO;
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
    public partial class fPayment : Form
    {
        BUS_Schedule BUS_Schedule = new();
        public fPayment()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string cccd = tbCCCD.Text;
            DataTable schedules = BUS_Schedule.getSchedulesByCCCD(cccd);
            dgvSchedule.DataSource = schedules;

        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked area is a valid row (not header or empty space)
            if (e.RowIndex >= 0)
            {
                // Access the data of the clicked row using the RowIndex
                DataGridViewRow selectedRow = dgvSchedule.Rows[e.RowIndex];
                DetailBillForm detailBillForm = new DetailBillForm(
                    Guid.Parse(selectedRow.Cells[0].Value.ToString()),
                    selectedRow.Cells[1].Value.ToString(),
                    selectedRow.Cells[2].Value.ToString(),
                    selectedRow.Cells[3].Value.ToString(),
                    Convert.ToDateTime(selectedRow.Cells[4].Value.ToString()),
                    Convert.ToDateTime(selectedRow.Cells[5].Value.ToString()),
                    selectedRow.Cells[6].Value.ToString(),
                    Guid.Parse(selectedRow.Cells[7].Value.ToString())
                    );
                detailBillForm.Show();

            }
        }
    }
}
