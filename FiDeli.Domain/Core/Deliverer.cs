using FiDeli.Domain.SeedWork;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FiDeli.Domain
{
    public class Deliverer : Person, IAggregateRoot
    {
        public GeoLocation CurrentLocation { get; set; } 
        public List<Parcel> AssignedParcels { get; set; }
        public List<Parcel> ParcelsInPossession { get; set; }
        public void AssignParcel(Parcel parcel)
        {
            AssignedParcels.Add(parcel);
        }
        
        public void ObtainParcel(Parcel parcel)
        {
            ParcelsInPossession.Add(parcel);
        }

        public void LeaveParcelIn(ParcelLocker parcelLocker, Parcel parcel)
        {
            AssignedParcels.Remove(parcel);
            ParcelsInPossession.Remove(parcel);
        }
    }
}
