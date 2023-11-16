using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Employee
    {

        readonly DAO_Employee dAO_employee = new DAO_Employee();
        #region 1. Create Account Employee
        public void createAccount(DTO_Employee employee)
        {
            dAO_employee.registerAccountEmployee(employee);

        }
        #endregion

        #region 2. Login Account Employee
        public DTO_Employee loginAccount(DTO_Employee employee)
        {
            foreach (DataRow row in dAO_employee.loginAccountEmployee(employee).Rows)
            {
                employee.Email = row[0].ToString();
                employee.Name = row[1].ToString();
            }
            return employee;
        }
        #endregion


        #region 3. Check Account employee
        public bool checkAccount(DTO_Employee employee)
        {
            return dAO_employee.checkAccount(employee);
        }
        #endregion
    }
}
