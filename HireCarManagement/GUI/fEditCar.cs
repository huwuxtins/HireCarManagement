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
    public partial class fEditCar : Form
    {
        DTO_Car car;
        DTO_Employee employee;
        BUS_Car bus_car = new BUS_Car();
        public event EventHandler FormClosedEvent;
        public fEditCar(DTO_Car car, DTO_Employee employee)
        {
            InitializeComponent();
            this.car = car;
            this.employee = employee;
        }

        private void fEditCar_Load(object sender, EventArgs e)
        {
            car = bus_car.getCarById(car.Id);
            tbName.Text = car.Name;
            tbBrand.Text = car.Brand;
            tbPrice.Text = Convert.ToString(car.Price);
            cbbType.Text = car.Type;
            if (car.Fuel.Equals("Gasoline"))
            {
                rbtnGasoline.Checked = true;
            }
            else if (car.Fuel.Equals("Electric"))
            {
                rbtnElec.Checked = true;
            }
            else if (car.Fuel.Equals("Diesel"))
            {
                rbtnDiesel.Checked = true;
            }

            chbCam.Checked = car.HaveCamera;
            chbMap.Checked = car.HaveMap;
            chbSpeedWarning.Checked = car.HaveSpeedWarning;
            chbFlyWindow.Checked = car.HaveFlyWindown;
            chbUSB.Checked = car.HaveUSB;
            chbBluetooth.Checked = car.HaveBluetooth;
            chb360Cam.Checked = car.HaveCamera360;
            chbRearCam.Checked = car.HaveRearCamera;
            chbTruckContainer.Checked = car.HaveTruckContainer;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            car.Name = tbName.Text;
            car.Brand = tbBrand.Text;
            car.Price = Convert.ToInt32(tbPrice.Text);
            car.Type = cbbType.Text;
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
            bus_car.updateProduct(car);
            Hide(); 
            OnFormClosedEvent();
        }

        protected virtual void OnFormClosedEvent()
        {
            FormClosedEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
