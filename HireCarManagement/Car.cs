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

namespace HireCarManagement
{
    public partial class Car : UserControl
    {
        public DTO_Car car;
        public event EventHandler MyCustomControlClick;
        public Car(DTO_Car car)
        {
            InitializeComponent();
            this.car = car;
        }

        private void load(object sender, EventArgs e)
        {
            lbNameCar.Text = car.Name;
            lbType.Text = car.Brand;
            lbPrice.Text = Convert.ToString(car.Price);
            lbFree.Text = car.IsFree ? "Empty" : "Renting";
            lbFree.BackColor = car.IsFree ? Color.Green : Color.Red;

            this.Click += click;
        }

        private void click(object sender, EventArgs e)
        {
            MyCustomControlClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
