using System;
using System.Collections.Generic;
using TechLibrary.Interfaces;

namespace TechLibrary.Data.Entities.Vehicle
{
    public class Manufacturer : IVehicleEntity
    {
        public Manufacturer(Guid id)
        {
            ID = id;
        }
        public Guid ID { get; set; }

        public string Name { get; set; }

        public List<Engine> Engines { get; set; }

        public List<Transmission> Transmissions { get; set; }

        public List<ModelFamily> ModelFamilies { get; set; }

        public ModelFamily AddModelFamily(string name)
        {
            var mf = new ModelFamily(this, Guid.NewGuid());
            ModelFamilies.Add(mf);
            return mf;
        }

        public Engine AddEngine(string name, FuelType fuelType, int capacityInCCs)
        {
            var engine = new Engine(this, Guid.NewGuid())
            {
                FuelTye = fuelType,
                CapacityInCCs = capacityInCCs
            };
            Engines.Add(engine);
            return engine;
        }

        public Transmission AddTransmission(string name, TransmissionType transmissionType, int gears)
        {
            var trans = new Transmission(this, Guid.NewGuid())
            {
                Gears = gears,
                TransmissionType = transmissionType
            };
            Transmissions.Add(trans);
            return trans;
        }
    }
}
