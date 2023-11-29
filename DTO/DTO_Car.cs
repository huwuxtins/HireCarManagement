using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DTO_Car
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Fuel { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public bool IsFree { get; set; }
        public int Price { get; set; }
        public string ImageLink { get; set; }
        public Guid FeatureId { get; set; }
        public bool HaveCamera { get; set; }
        public bool HaveMap { get; set; }
        public bool HaveFlyWindown { get; set; }
        public bool HaveUSB { get; set; }
        public bool HaveBluetooth { get; set; }
        public bool HaveTruckContainer { get; set; }
        public bool HaveCamera360 { get; set; }
        public bool HaveSpeedWarning { get; set; }
        public bool HaveRearCamera { get; set; }

        public DTO_Car() { }

        public DTO_Car(Guid id, string name, string fuel, string type, string brand, 
            bool isFree, int price, string imageLink, Guid FeatureId, bool haveCamera, bool haveMap,
            bool haveFlyWindown, bool haveUSB, bool haveBluetooth, bool haveTruckContainer, 
            bool haveCamera360, bool haveSpeedWarning, bool haveRearCamera)
        {
            Id = id;
            Name = name;
            Fuel = fuel;
            Type = type;
            Brand = brand;
            IsFree = isFree;
            Price = price;
            this.FeatureId = FeatureId;
            ImageLink = imageLink;
            HaveCamera = haveCamera;
            HaveMap = haveMap;
            HaveFlyWindown = haveFlyWindown;
            HaveUSB = haveUSB;
            HaveBluetooth = haveBluetooth;
            HaveTruckContainer = haveTruckContainer;
            HaveCamera360 = haveCamera360;
            HaveSpeedWarning = haveSpeedWarning;
            HaveRearCamera = haveRearCamera;
        }
    }
}
