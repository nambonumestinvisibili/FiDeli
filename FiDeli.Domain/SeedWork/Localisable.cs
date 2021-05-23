using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Domain.SeedWork
{
    public abstract class Localisable : Entity
    {
        public GeoLocation CurrentLocation { get; set; }

        public bool IsClose(GeoLocation location, double meters)
        {
            
            return Distance(location) <= meters;
        }

        public double Distance(GeoLocation location) {
            
            return Math.Sqrt(
                Math.Pow((CurrentLocation.Longitude - location.Longitude), 2) +
                Math.Pow((CurrentLocation.Latitude - location.Latitude), 2));
        }
    }
}
