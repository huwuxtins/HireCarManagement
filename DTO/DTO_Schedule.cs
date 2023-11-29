using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Schedule
    {
        public Guid Id { get; set; }
        public DateTime HiredAt { get; set; }
        public DateTime ReturnedAt { get; set; }
        public float Price { get; set; }
        public bool IsPaid { get; set; }
        public Guid CustomerId { get; set; }
        public Guid CarId { get; set; }

        public DTO_Schedule(Guid id, DateTime hiredAt, DateTime returnedAt, float price, bool isPaid, Guid customerId, Guid carId)
        {
            Id = id;
            HiredAt = hiredAt;
            ReturnedAt = returnedAt;
            Price = price;
            IsPaid = isPaid;
            CustomerId = customerId;
            CarId = carId;
        }

        public DTO_Schedule(Guid id, DateTime hiredAt, DateTime returnedAt, int price, bool isPaid)
        {
            Id = id;
            HiredAt = hiredAt;
            ReturnedAt = returnedAt;
            Price = price;
            IsPaid = isPaid;
        }
    }
}
