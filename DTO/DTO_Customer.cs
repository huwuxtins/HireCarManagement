using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DTO_Customer
    {
        public Guid Id { get; set; }    
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string CCCD { get; set; }


        public DTO_Customer(Guid id, string name, string phoneNumber, string address, string cCCD)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
            CCCD = cCCD;
        }

        public DTO_Customer()
        {
        }
    }
}
