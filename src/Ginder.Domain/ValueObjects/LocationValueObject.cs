using System.Collections.Generic;

namespace Ginder.Domain.ValueObjects
{
    public class LocationValueObject : ValueObject
    {
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }

        public LocationValueObject(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Latitude;
            yield return Longitude;
        }
    }
}