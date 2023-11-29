using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_Customer
    {
        #region 1. show all info of customer
        public DataTable showAllCustomer()
        {
            string statement = "showAllCustomer";
            return DataProvider.Instance.ExecuteStoredProcedureSelect(statement);
        }
        #endregion

        #region 2. create account for customer
        public void registerAccountCustomer(DTO_Customer customer)
        {
            string statement = "registerAccountCustomer @ID , @Name , @PhoneNumber , @Address , @CCCD";
            DataProvider.Instance.ExecuteStoredProcedure(statement, new object[] { 
                customer.Id, 
                customer.Name, 
                customer.PhoneNumber, 
                customer.Address,
                customer.CCCD});
        }
        #endregion

        #region 3. Login Account User
        public DataTable loginAccount(DTO_Customer customer)
        {
            DataTable dataTable = new DataTable();
            string statement = "loginAccountCustomer @numberPhone";
            dataTable = DataProvider.Instance.ExecuteStoredProcedureSelect(statement, new object[] { customer.PhoneNumber });
            return dataTable;
        }
        #endregion

        #region 4. update account for customer
        public void updateAccountCustomer(DTO_Customer customer)
        {
            string statement = "updateAccountCustomer @ID , @Name , @PhoneNumber , @Address , @CCCD";
            DataProvider.Instance.ExecuteStoredProcedure(statement, new object[] {
                customer.Id,
                customer.Name,
                customer.PhoneNumber,
                customer.Address,
                customer.CCCD});
        }
        #endregion

        #region 5. delete account for customer
        public void deleteAccountCustomer(DTO_Customer customer)
        {
            string statement = "deleteAccountCustomer @ID";
            DataProvider.Instance.ExecuteStoredProcedure(statement, new object[] { customer.Id });
        }
        #endregion

        #region 6. Check account
        public bool checkAccountCustomer(DTO_Customer customer)
        {
            string statement = "checkAccountCustomer @PhoneNumber";
            int count = Convert.ToInt32(DataProvider.Instance.ExecuteStoredProcedureScalar(statement, new object[] { customer.PhoneNumber }));
            if (count > 0)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region 7. Get Customer by CCCD
        public DataTable getCustomerByCCCD(string cccd)
        {
            string statement = "getCustomerByCCCD @cccd";
            return DataProvider.Instance.ExecuteStoredProcedureSelect(statement, new object[] { cccd });
        }
        #endregion
    }
}
