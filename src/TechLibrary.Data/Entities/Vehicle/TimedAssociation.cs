using TechLibrary.Interfaces;

namespace TechLibrary.Data.Entities.Vehicle
{
    public class TimedAssociation
    {
        public IVehicleEntity RelatedEntity { get; set; }

        public TimeRange TimeRange { get; set; }
    }
}
