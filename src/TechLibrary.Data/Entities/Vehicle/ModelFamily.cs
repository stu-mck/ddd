using System;
using System.Collections.Generic;
using TechLibrary.Interfaces;

namespace TechLibrary.Data.Entities.Vehicle
{
    public class ModelFamily : IVehicleEntity
    {
        public ModelFamily(Manufacturer manufacturer, Guid id)
        {
            ID = id;
            Manufacturer = manufacturer;
        }

        public Guid ID { get; set; }
        public string Name { get; set; }

        public Manufacturer Manufacturer { get; set; }

        public List<Series> Series { get; set; }

        public Series AddSeries(string name, int doors, BodyType bodyType)
        {
            var series = new Series(this, Guid.NewGuid()) 
            {
                BodyType = bodyType
            };
            Series.Add(series);
            return series;
        }
    }
}
