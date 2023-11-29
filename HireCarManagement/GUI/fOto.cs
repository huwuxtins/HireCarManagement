using BUS;
using DAO;
using DTO;
using HireCarManagement;
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
    public partial class FOto : Form
    {
        DTO_Employee employee;
        List<DTO_Car> cars = new List<DTO_Car>();
        BUS_Car bUS_Car = new BUS_Car();
        DTO_Car choosenCar;
        public FOto(DTO_Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void load(object sender, EventArgs e)
        {
            bUS_Car.showAllProduct(cars);
            flpCar.Controls.Clear();
            foreach (var car in cars)
            {
                Car carControl = new Car(car);
                carControl.MyCustomControlClick += ItemClickHandler;
                flpCar.Controls.Add(carControl);
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            fEditCar editCar = new(choosenCar, employee);
            editCar.FormClosedEvent += Form2_FormClosedEvent;
            editCar.Show();
        }

        private void ItemClickHandler(object sender, EventArgs e)
        {
            // This event handler will be called when an item in the FlowLayoutPanel is clicked.
            if (sender is Car car)
            {
                choosenCar = car.car;
                car.BackColor = car.BackColor.Equals(Color.Cyan) ? (Color.White) : (Color.Cyan);
            }
        }

        private void buttonPickCar_Click(object sender, EventArgs e)
        {
            AddBillForm billForm = new AddBillForm(choosenCar);
            billForm.Show();
        }
        private void Form2_FormClosedEvent(object sender, EventArgs e)
        {
            // Handle the event, e.g., reload Form1
            load(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddCar fAddCar = new fAddCar();
            fAddCar.FormClosedEvent += Form2_FormClosedEvent;
            fAddCar.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchStr = tbSearch.Text;
            List<DTO_Car> searchCars = cars.Where(car => car.Name.Contains(searchStr)).ToList();
            flpCar.Controls.Clear();
            foreach (DTO_Car car in searchCars)
            {
                Car carControl = new Car(car);
                carControl.MyCustomControlClick += ItemClickHandler;
                flpCar.Controls.Add(carControl);
            }
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            SearchByType("Mini");
        }

        private void btnSedan_Click(object sender, EventArgs e)
        {
            SearchByType("Sedan");
        }

        private void btnSUV_Click(object sender, EventArgs e)
        {
            SearchByType("SUV");
        }

        private void btnCUV_Click(object sender, EventArgs e)
        {
            SearchByType("CUV");
        }
        private void btnMPV_Click(object sender, EventArgs e)
        {
            SearchByType("MPV");
        }
        private void btnTruck_Click(object sender, EventArgs e)
        {
            SearchByType("Truck");
        }

        private void SearchByType(string type)
        {
            List<DTO_Car> searchCars = cars.Where(car => car.Type.Contains(type)).ToList();
            flpCar.Controls.Clear();
            foreach (DTO_Car car in searchCars)
            {
                Car carControl = new Car(car);
                carControl.MyCustomControlClick += ItemClickHandler;
                flpCar.Controls.Add(carControl);
            }
        }

        private void SearchByFeatures(object sender, EventArgs e)
        {
            List<DTO_Car> searchCars = cars.ToList();
            List<bool> opts = new();
            CheckBox[] checkBoxes = new CheckBox[]
            {
                chbCam, chbMap, chbFlyWindow,
                chbUSB, chbBluetooth, chbTruckContainer,
                chb360Cam, chbSpeedWarning, chbRearCam
            };

            if (chbCam.Checked)
            {
                searchCars = searchCars.Where(car => car.HaveCamera).ToList();
            }
            if (chbMap.Checked)
            {
                searchCars = searchCars.Where(car => car.HaveCamera).ToList();
            }
            if (chbFlyWindow.Checked)
            {
                searchCars = searchCars.Where(car => car.HaveFlyWindown).ToList();
            }
            if (chbUSB.Checked)
            {
                searchCars = searchCars.Where(car => car.HaveUSB).ToList();
            }
            if (chbBluetooth.Checked)
            {
                searchCars = searchCars.Where(car => car.HaveBluetooth).ToList();
            }
            if (chbTruckContainer.Checked)
            {
                searchCars = searchCars.Where(car => car.HaveTruckContainer).ToList();
            }
            if (chb360Cam.Checked)
            {
                searchCars = searchCars.Where(car => car.HaveCamera360).ToList();
            }
            if (chbSpeedWarning.Checked)
            {
                searchCars = searchCars.Where(car => car.HaveSpeedWarning).ToList();
            }
            if (chbRearCam.Checked)
            {
                searchCars = searchCars.Where(car => car.HaveRearCamera).ToList();
            }

            flpCar.Controls.Clear();
            foreach (DTO_Car car in searchCars)
            {
                Car carControl = new Car(car);
                carControl.MyCustomControlClick += ItemClickHandler;
                flpCar.Controls.Add(carControl);
            }
        }

        private void SearchByFuel(object sender, EventArgs e)
        {
            List<DTO_Car> searchCars = cars.ToList();
            RadioButton[] radioButtons = new RadioButton[]
            {
                rbtnGasoline, rbtnDiesel, rbtnElec
            };

            foreach (var c in radioButtons)
            {
                if (c.Checked)
                {
                    searchCars = searchCars.Where(car => car.Fuel.Equals(c.Text)).ToList();
                }
            }
            flpCar.Controls.Clear();
            foreach (DTO_Car car in searchCars)
            {
                Car carControl = new Car(car);
                carControl.MyCustomControlClick += ItemClickHandler;
                flpCar.Controls.Add(carControl);
            }
        }

        private void btnHatchback_Click(object sender, EventArgs e)
        {
            SearchByType("Hatchback");
        }
    }
}
