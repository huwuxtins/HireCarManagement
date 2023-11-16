using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Customer
    {
        DAO_Customer dAO_Customer = new DAO_Customer();

        #region 1. Get all customer
        public DataTable showAllCustomer()
        {
            return dAO_Customer.showAllCustomer();
        }
        #endregion

        #region 2. Create Account User
        public void createAccount(DTO_Customer customer)
        {
            dAO_Customer.registerAccountCustomer(customer);
        }
        #endregion

        #region 3. Login Account Customer
        public DTO_Customer loginAccount(DTO_Customer customer)
        {
            foreach (DataRow row in dAO_Customer.loginAccount(customer).Rows)
            {
                customer.Id = Guid.Parse(row[0].ToString());
                customer.PhoneNumber = row[1].ToString();
                customer.Name = row[2].ToString();
                customer.Address = row[3].ToString();
            }
            return customer;
        }
        #endregion

        #region 4. Check Account customer
        public bool checkAccount(DTO_Customer customer)
        {
            return dAO_Customer.checkAccountCustomer(customer);
        }
        #endregion

        #region 5. Update Account customer
        public void updateAccount(DTO_Customer customer)
        {
            dAO_Customer.updateAccountCustomer(customer);
        }
        #endregion

        #region 6. Delete Account customer
        public void deleteAccount(DTO_Customer customer)
        {
            dAO_Customer.deleteAccountCustomer(customer);
        }
        #endregion
    }
}
