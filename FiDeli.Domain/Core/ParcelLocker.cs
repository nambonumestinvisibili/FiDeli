using FiDeli.Domain.SeedWork;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Device.Location;

namespace FiDeli.Domain
{
    public class ParcelLocker : Localisable
    {
        public GeoLocation Location { get; set; }
        public List<Locker> Lockers { get; set; }
    }
}
