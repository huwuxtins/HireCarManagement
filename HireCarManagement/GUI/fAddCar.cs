using BUS;
using DAO;
using OfficeOpenXml;
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
    public partial class fAddCar : Form
    {
        readonly BUS_Car bUS_Car = new();
        public event EventHandler FormClosedEvent;
        public fAddCar()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            DTO_Car car = new()
            {
                Name = tbName.Text,
                Brand = tbBrand.Text,
                Price = Convert.ToInt32(tbPrice.Text),
                Type = cbbType.Text,
                IsFree = true,
                ImageLink = ""
            };
            car.Id = Guid.NewGuid();
            if (rbtnGasoline.Checked)
            {
                car.Fuel = ("Gasoline");
            }
            else if (rbtnElec.Checked)
            {
                car.Fuel = ("Electric");
            }
            else if (rbtnDiesel.Checked)
            {
                car.Fuel = ("Diesel");
            }

            car.HaveCamera = chbCam.Checked;
            car.HaveMap = chbMap.Checked;
            car.HaveSpeedWarning = chbSpeedWarning.Checked;
            car.HaveFlyWindown = chbFlyWindow.Checked;
            car.HaveUSB = chbUSB.Checked;
            car.HaveBluetooth = chbBluetooth.Checked;
            car.HaveCamera360 = chb360Cam.Checked;
            car.HaveRearCamera = chbRearCam.Checked;
            car.HaveTruckContainer = chbTruckContainer.Checked;

            bUS_Car.insertProduct(car);
            Hide();
            OnFormClosedEvent();
        }
        protected virtual void OnFormClosedEvent()
        {
            FormClosedEvent?.Invoke(this, EventArgs.Empty);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
                openFileDialog.Title = "Select an Excel File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                    // Load the Excel file using EPPlus
                    using (ExcelPackage package = new ExcelPackage(new System.IO.FileInfo(filePath)))
                    {
                        // Assuming the data is in the first worksheet (index 0)
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                        // Get the number of rows and columns in the worksheet
                        int rows = worksheet.Dimension.Rows;
                        int columns = worksheet.Dimension.Columns;

                        for (int row = 2; row <= rows; row++)
                        {
                            DTO_Car car = new DTO_Car();
                            car.Id = Guid.NewGuid();
                            car.Name = worksheet.Cells[row, 1].Text;
                            car.Fuel = worksheet.Cells[row, 2].Text;
                            car.Type = worksheet.Cells[row, 3].Text;
                            car.Brand = worksheet.Cells[row, 4].Text;
                            MessageBox.Show(worksheet.Cells[row, 5].Text);
                            car.IsFree = Convert.ToBoolean(worksheet.Cells[row, 5].Text.Equals("1"));
                            car.Price = Convert.ToInt32(worksheet.Cells[row, 6].Text);
                            car.ImageLink = worksheet.Cells[row, 7].Text;
                            car.HaveCamera = Convert.ToBoolean(worksheet.Cells[row, 8].Text.Equals("1"));
                            car.HaveMap = Convert.ToBoolean(worksheet.Cells[row, 9].Text.Equals("1"));
                            car.HaveFlyWindown = Convert.ToBoolean(worksheet.Cells[row, 10].Text.Equals("1"));
                            car.HaveUSB = Convert.ToBoolean(worksheet.Cells[row, 11].Text.Equals("1"));
                            car.HaveBluetooth = Convert.ToBoolean(worksheet.Cells[row, 12].Text.Equals("1"));
                            car.HaveTruckContainer = Convert.ToBoolean(worksheet.Cells[row, 13].Text.Equals("1"));
                            car.HaveCamera360 = Convert.ToBoolean(worksheet.Cells[row, 14].Text.Equals("1"));
                            car.HaveSpeedWarning = Convert.ToBoolean(worksheet.Cells[row, 15].Text.Equals("1"));
                            car.HaveRearCamera = Convert.ToBoolean(worksheet.Cells[row, 16].Text.Equals("1"));

                            bUS_Car.insertProduct(car);
                        }


                    }
                }
            }
        }
    }
}
