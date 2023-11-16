using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_Car
    {
        #region 1. Show all products 
        public DataTable showAllCars()
        {
            string statement = "usp_ShowAllCars";
            return DataProvider.Instance.ExecuteStoredProcedureSelect(statement);
        }
        #endregion

        #region 2. Insert car
        public void insertCar(DTO_Car car)
        {
            string statement = "insertCar @ID , @Name , @Feature , @Fuel , @Type , @Brand , @IsFree , @ImageLink , @FeatureId , @car.HaveCamera , @car.HaveMap , @car.HaveFlyWindown , @car.HaveUSB , @car.HaveBluetooth , @car.HaveTruckContainer, @car.HaveCamera360 , @car.HaveSpeedWarning , @car.HaveRearCamera";
            DataProvider.Instance.ExecuteStoredProcedure(statement, new object[] { 
                car.Id,
                car.Name, 
                car.Fuel,
                car.Type, 
                car.Brand,
                car.IsFree,
                car.ImageLink,
                Guid.NewGuid().ToString(),
                car.HaveCamera ,
                car.HaveMap ,
                car.HaveFlyWindown ,
                car.HaveUSB ,
                car.HaveBluetooth ,
                car.HaveTruckContainer ,
                car.HaveCamera360 ,
                car.HaveSpeedWarning ,
                car.HaveRearCamera });
        }
        #endregion  

        #region 3. Update product
        public void updateProduct(DTO_Car car)
        {
            string statement = "updateCar @ID , @Name , @Feature , @Fuel , @Type , @Brand , @IsFree , @ImageLink , @FeatureId , @car.HaveCamera , @car.HaveMap , @car.HaveFlyWindown , @car.HaveUSB , @car.HaveBluetooth , @car.HaveTruckContainer, @car.HaveCamera360 , @car.HaveSpeedWarning , @car.HaveRearCamera";
            DataProvider.Instance.ExecuteStoredProcedure(statement, new object[] {
                car.Id,
                car.Name,
                car.Fuel,
                car.Type,
                car.Brand,
                car.IsFree,
                car.ImageLink,
                Guid.NewGuid().ToString(),
                car.HaveCamera ,
                car.HaveMap ,
                car.HaveFlyWindown ,
                car.HaveUSB ,
                car.HaveBluetooth ,
                car.HaveTruckContainer ,
                car.HaveCamera360 ,
                car.HaveSpeedWarning ,
                car.HaveRearCamera });
        }
        #endregion

        #region 4. Delete product
        public void deleteCar(DTO_Car car)
        {
            string statement = "deleteCar @ID";
            DataProvider.Instance.ExecuteStoredProcedure(statement, new object[] { car.Id });
        }
        #endregion
    }
}
