using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Employee
    {
        public DTO_Employee()
        {
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public DTO_Employee(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }

        public DTO_Employee(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
