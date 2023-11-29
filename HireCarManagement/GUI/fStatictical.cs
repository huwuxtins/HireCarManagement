using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.DataVisualization.Charting;

namespace DoubleT.GUI
{
    public partial class fStatictical : Form
    {
        readonly BUS_Schedule BUS_Schedule = new BUS_Schedule();
        readonly BUS_Car bUS_Car = new BUS_Car();
        public fStatictical()
        {
            InitializeComponent();
        }

        private void fStatictical_Load(object sender, EventArgs e)
        {
            buildChart(sender, e);
            buildChartCar(sender, e);
        }

        private void buildChart(object sender, EventArgs e)
        {
            // Convert DateTime from date pickers
            DateTime from = Convert.ToDateTime(dtpFrom.Text);
            DateTime to = Convert.ToDateTime(dtpTo.Text);

            // Retrieve data from the business logic layer
            DataTable data = BUS_Schedule.getScheduleFromTo(from, to);
            chart_report.DataSource = data;

            // Bind the data to the chart
            chart_report.DataBind();
        }

        private void buildChartCar(object sender, EventArgs e)
        {

            // Retrieve data from the business logic layer
            DataTable data = bUS_Car.getCarByType();
            chart_car.DataSource = data;

            // Bind the data to the chart
            chart_car.DataBind();
        }

        private void btnStatic_Click(object sender, EventArgs e)
        {
            buildChart(sender, e);
        }
    }
}
