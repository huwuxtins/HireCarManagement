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
        public Guid CarId { get; set; }

        public DTO_Schedule(Guid id, DateTime hiredAt, DateTime returnedAt, float price, Guid carId)
        {
            Id = id;
            HiredAt = hiredAt;
            ReturnedAt = returnedAt;
            Price = price;
            CarId = carId;
        }
    }
}
