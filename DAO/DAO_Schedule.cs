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

            string statement = "insertSchedule @ID , @HiredAt , @ReturnedAt , @Price , @CarId";
            DataProvider.Instance.ExecuteStoredProcedureSelect(statement, new object[]
            {
                schedule.Id,
                schedule.HiredAt,
                schedule.ReturnedAt,
                schedule.Price,
                schedule.CarId
            });
        }
        #endregion


        #region 3. Update schedule
        public void updateSchedule(DTO_Schedule schedule)
        {
            string statement = "updateSchedule @ID , @HiredAt , @ReturnedAt , @Price , @CarId";
            DataProvider.Instance.ExecuteStoredProcedureSelect(statement, new object[]
            {
                schedule.Id,
                schedule.HiredAt,
                schedule.ReturnedAt,
                schedule.Price,
                schedule.CarId
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
    }
}
