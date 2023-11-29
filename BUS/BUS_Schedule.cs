using DAO;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Schedule
    {
        DAO_Schedule dAO_Schedule = new DAO_Schedule();

        #region 1.Get All schedule
        public DataTable showAllSchedules()
        {
            return dAO_Schedule.showAllSchedule();
        }
        #endregion

        #region 2. Insert Schedule
        public void insertSchedule(DTO_Schedule schedule)
        {
            dAO_Schedule.insertSchedule(schedule);
        }
        #endregion

        #region 3. Update Schedule
        public void updateSchedule(DTO_Schedule schedule)
        {
            dAO_Schedule.updateSchedule(schedule);
        }
        #endregion

        #region 4. Delete Schedule
        public void deleteSchedule(Guid id)
        {
            dAO_Schedule.deleteSchedule(id);
        }
        #endregion

        #region 5. Get Schedule from to
        public DataTable getScheduleFromTo(DateTime from, DateTime to)
        {
            return dAO_Schedule.getScheduleFromTo(from, to);
        }
        #endregion

        #region 6.Show bill
        public DataTable showBill()
        {
            return dAO_Schedule.showBill();
        }
        #endregion

        #region 7.Get schedule by CCCD
        public DataTable getSchedulesByCCCD(string cccd)
        {
            return dAO_Schedule.GetScheduleByCCCD(cccd);
        }
        #endregion
    }
}
