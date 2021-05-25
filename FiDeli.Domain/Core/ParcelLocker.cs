using FiDeli.Domain.Core;
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
        public List<Locker> Lockers { get; set; } = new List<Locker>();

        public bool ContainsLockerOfSize(Size size)
        {
            return Lockers.Exists(x => x.Size == size);
        }

        public Locker GetLockerOfSize(Size size)
        {
            return Lockers.Where(x => x.Size == size).FirstOrDefault();
        }

        public Locker GetLockerByParcelCode(ParcelCode code)
        {
            return Lockers.Where(x => x.ContainsParcelWithCode(code)).FirstOrDefault();
        }
    
    }
}
