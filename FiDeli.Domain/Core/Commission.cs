using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Domain
{
    public class Commission : Entity //builder
    {
        public Commissioner Commissioner {get;set;}
        public Recipient Recipient { get; set; }
        public ParcelLocker TargetParceLocker { get; set; }
        public ParcelLocker SourceParcelLocker { get; set; }
        public IDeliveryStatus DeliveryStatus { get; set; } //prolly state design pattern
        public decimal Price { get; set; }
        public Parcel Parcel { get; set; }
        public void ChangeDeliveryStatus(DeliveryStatus deliveryStatus)
        {

        }
    }

    
}
