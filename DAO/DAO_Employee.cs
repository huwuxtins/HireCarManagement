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
            string statement = "loginAccountEmployee @email , @password";
            return DataProvider.Instance.ExecuteStoredProcedureSelect(statement, new object[] { employee.Email, employee.Password });
        }
        #endregion

        #region 2. create account for user
        public void registerAccountEmployee(DTO_Employee employee)
        {
            string statement = "registerAccountEmployee @ID , @Name , @Email , @Password , @ROLE";
            DataProvider.Instance.ExecuteStoredProcedure(statement, new object[] { employee.Id, employee.Name, employee.Email, employee.Password, employee.ROLE});
        }
        #endregion

        #region 3. Check account
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

        #region 4. Get all Employee
        public DataTable getAllEmployee()
        {
            string statement = "getAllEmployee";
            return DataProvider.Instance.ExecuteStoredProcedureSelect(statement);
        }
        #endregion

        #region 5. Update Employee
        public void updateEmployee(DTO_Employee employee)
        {
            string statement = "updateAccountEmployee @ID , @Name , @Email , @Password , @ROLE"; 
            DataProvider.Instance.ExecuteStoredProcedure(statement, new object[] { employee.Id, employee.Name, employee.Email, employee.Password, employee.ROLE });
        }
        #endregion
    }
}
