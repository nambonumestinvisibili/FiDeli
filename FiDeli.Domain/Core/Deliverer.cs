using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FiDeli.Domain
{
    public class Deliverer : Person
    {
        GeoCoordinate CurrentLocation { get; set; } 
        List<Parcel> AssignedParcels { get; set; }
        List<Parcel> ParcelsInPossession { get; set; }
        public void AssignParcel(Parcel parcel)
        {

        }

        public void LeaveParcelIn(ParcelLocker parcelLocker, Parcel parcel)
        {

        }
    }
}
