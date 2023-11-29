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
            var employees = dAO_employee.loginAccountEmployee(employee);
            if(employees != null)
            {
                foreach (DataRow row in dAO_employee.loginAccountEmployee(employee).Rows)
                {
                    employee.Email = row[0].ToString();
                    employee.Name = row[1].ToString();
                    employee.ROLE = row[2].ToString();
                }
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

        #region 4. Show all employee
        public DataTable getAllEmployee()
        {
            return dAO_employee.getAllEmployee();
        }
        #endregion

        #region 5. Update employee
        public void updateAccout(DTO_Employee employee)
        {
            dAO_employee.updateEmployee(employee);
        }
        #endregion
    }
}
