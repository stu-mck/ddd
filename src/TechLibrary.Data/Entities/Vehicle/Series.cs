using System;
using System.Collections.Generic;
using TechLibrary.Interfaces;

namespace TechLibrary.Data.Entities.Vehicle
{
    public class Series : IVehicleEntity
    {
        public Series(ModelFamily modelFamily, Guid id)
        {
            ID = id;
            ModelFamily = modelFamily;
        }

        public string Name { get; set; }
        public ModelFamily ModelFamily { get; set; }

        public Guid ID { get; set; }

        public int Doors { get; set; }

        public BodyType BodyType { get; set; }

        public List<TimedAssociation> Engines { get; set; }

        public List<TimedAssociation> Transmissions { get; set; }
        
        public TimeRange TimeRange { get; set; }
         
    }
}
