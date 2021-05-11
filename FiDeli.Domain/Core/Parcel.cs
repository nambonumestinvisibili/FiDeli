using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Domain
{
    public class Parcel : Entity
    {
        public Size Size { get; set; }
        public ParcelLocker CurrentLocker { get; set; }
        public IParcelStatus ParcelStatus { get; set; }


    }
}
