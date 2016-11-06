using System;
using TechLibrary.Interfaces;

namespace TechLibrary.Data.Entities.Vehicle
{
    public class Transmission : IVehicleEntity
    {
        public Transmission(Manufacturer manufacturer, Guid id)
        {
            ID = id;
            Manufacturer = manufacturer;
        }

        public string Name { get; set; }
        public TransmissionType TransmissionType { get; set; }

        public int Gears { get; set; }

        public Guid ID { get; set; }

        public Manufacturer Manufacturer { get; set; }


    }
}
