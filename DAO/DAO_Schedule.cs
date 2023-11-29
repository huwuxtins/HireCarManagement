using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_Schedule
    {
        #region 1. Show all products 
        public DataTable showAllSchedule()
        {
            string statement = "usp_ShowAllSchedule";
            return DataProvider.Instance.ExecuteStoredProcedureSelect(statement);
        }
        #endregion

        #region 2. Insert schedule
        public void insertSchedule(DTO_Schedule schedule)
        {

            string statement = "insertSchedule @ID , @HiredAt , @ReturnedAt , @Price , @IsPaid , @CustomerId , @CarId";
            DataProvider.Instance.ExecuteStoredProcedureSelect(statement, new object[]
            {
                schedule.Id,
                schedule.HiredAt,
                schedule.ReturnedAt,
                schedule.Price,
                schedule.IsPaid,
                schedule.CustomerId,
                schedule.CarId
            });
        }
        #endregion

        #region 3. Update schedule
        public void updateSchedule(DTO_Schedule schedule)
        {
            string statement = "updateSchedule @ID , @HiredAt , @ReturnedAt , @Price , @IsPaid";
            DataProvider.Instance.ExecuteStoredProcedureSelect(statement, new object[]
            {
                schedule.Id,
                schedule.HiredAt,
                schedule.ReturnedAt,
                schedule.Price,
                schedule.IsPaid
            });
        }
        #endregion

        #region 4. Delete schedule
        public void deleteSchedule(Guid id)
        {
            string statement = "deleteSchedule @ID";
            DataProvider.Instance.ExecuteStoredProcedureSelect(statement, new object[]{ id });
        }
        #endregion

        #region 5.Get Schedule from to
        public DataTable getScheduleFromTo(DateTime from, DateTime to)
        {
            string statement = "getScheduleFromTo @From , @To";
            return DataProvider.Instance.ExecuteStoredProcedureSelect(statement, new object[] {from, to});
        }
        #endregion

        #region 6. Show Bill
        public DataTable showBill()
        {
            string statement = "showBill";
            return DataProvider.Instance.ExecuteStoredProcedureSelect(statement);
        }
        #endregion

        #region 7. Get schedule by CCCD
        public DataTable GetScheduleByCCCD(string cccd)
        {
            string statement = "getScheduleByCustomer @CCCD";
            return DataProvider.Instance.ExecuteStoredProcedureSelect(statement, new object[] { cccd });
        }
        #endregion
    }
}
