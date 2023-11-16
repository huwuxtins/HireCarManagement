using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_Employee
    {
        #region 1. Login Account Employee
        public DataTable loginAccountEmployee(DTO_Employee employee)
        {
            DataTable dataTable = new DataTable();
            string statement = "loginAccountEmployee @email";
            dataTable = DataProvider.Instance.ExecuteStoredProcedureSelect(statement, new object[] { employee.Email });
            return dataTable;
        }
        #endregion

        #region 2. create account for user
        public void registerAccountEmployee(DTO_Employee employee)
        {
            string statement = "registerAccountEmployee @ID , @Name , @Email , @Password";
            DataProvider.Instance.ExecuteStoredProcedure(statement, new object[] { employee.Id, employee.Name, employee.Email, employee.Password });
        }
        #endregion

        #region 6. Check account
        public bool checkAccount(DTO_Employee employee)
        {
            string statement = "checkAccountEmployee @Email";
            int count = Convert.ToInt32(DataProvider.Instance.ExecuteStoredProcedureScalar(statement, new object[] { employee.Email }));
            if (count > 0)
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
