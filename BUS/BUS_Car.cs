using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Car
    {
        DAO_Car dAO_car = new DAO_Car();

        #region 1. Show all car
        public void showAllProduct(List<DTO_Car> cars)
        {
            cars.Clear();
            foreach (DataRow row in dAO_car.showAllCars().Rows)
            {
                DTO_Car car = new DTO_Car(
                    Guid.Parse(row[0].ToString()),
                    (string)row[1],
                    (string)row[2],
                    (string)row[3],
                    (string)row[4],
                    (bool)row[5],
                    (int)row[6],
                    (string)row[7],
                    Guid.Parse(row[8].ToString()),
                    (bool)row[9],
                    (bool)row[10],
                    (bool)row[11],
                    (bool)row[12],
                    (bool)row[13],
                    (bool)row[14],
                    (bool)row[15],
                    (bool)row[16],
                    (bool)row[17]);
                cars.Add(car);
            }
        }
        #endregion

        #region 2. Insert product
        public void insertProduct(DTO_Car car)
        {
            dAO_car.insertCar(car);
        }
        #endregion

        #region 3. update Product
        public void updateProduct(DTO_Car car)
        {
            dAO_car.updateProduct(car);
        }
        #endregion

        #region 4. Delete product
        public DAO_Car deleteProduct(DTO_Car car)
        {
            DAO_Car dAO_product = new DAO_Car();
            dAO_car.deleteCar(car);
            return dAO_product;
        }
        #endregion

        #region 5. Get Car by Id
        public DTO_Car getCarById(Guid carId)
        {
            DTO_Car car = new DTO_Car();
            foreach (DataRow row in dAO_car.getCarById(carId).Rows)
            {
                car =  new DTO_Car(
                    Guid.Parse(row[0].ToString()),
                    (string)row[1],
                    (string)row[2],
                    (string)row[3],
                    (string)row[4],
                    (bool)row[5],
                    (int)row[6],
                    (string)row[7],
                    Guid.Parse(row[8].ToString()),
                    (bool)row[9],
                    (bool)row[10],
                    (bool)row[11],
                    (bool)row[12],
                    (bool)row[13],
                    (bool)row[14],
                    (bool)row[15],
                    (bool)row[16],
                    (bool)row[17]);
                break;
            }
            return car;
        }
        #endregion

        #region 6. Return Car
        public void returnCar(Guid id)
        {
            dAO_car.returnCar(id);
        }
        #endregion

        #region 7. Get car by type
        public DataTable getCarByType()
        {
            return dAO_car.getCarByType();
        }
        #endregion
    }
}
