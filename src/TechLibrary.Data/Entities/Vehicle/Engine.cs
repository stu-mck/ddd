using System;
using TechLibrary.Interfaces;

namespace TechLibrary.Data.Entities.Vehicle
{
    public class Engine : IVehicleEntity
    {
        public Engine(Manufacturer manufacturer, Guid id)
        {
            ID = id;
            Manufacturer = manufacturer;
        }

        public string Name { get; set; }

        public Manufacturer Manufacturer { get; set; }
        public Guid ID { get; set; }

        public FuelType FuelTye { get; set; }

        public int CapacityInCCs { get; set; }


    }
}
