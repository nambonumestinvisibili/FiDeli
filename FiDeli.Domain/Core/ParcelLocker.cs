using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Domain
{
    public class ParcelLocker : Entity
    {
        public GeoCoordinate Location { get; set; }
        public List<Locker> Lockers { get; set; }
    }
}
