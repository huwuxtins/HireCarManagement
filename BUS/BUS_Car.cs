using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
                DTO_Car product = new DTO_Car(
                    Guid.Parse(row[0].ToString()), 
                    (string)row[1], 
                    (string)row[2], 
                    (string)row[3], 
                    (string)row[4],
                    (bool)row[5], 
                    (string)row[6],
                    (bool)row[7],
                    (bool)row[8],
                    (bool)row[9],
                    (bool)row[10],
                    (bool)row[11],
                    (bool)row[12],
                    (bool)row[13],
                    (bool)row[14],
                    (bool)row[15]);
                cars.Add(product);
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
    }
}
