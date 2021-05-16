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
    }
}
