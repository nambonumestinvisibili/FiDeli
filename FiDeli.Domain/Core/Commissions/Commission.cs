using FiDeli.Domain.SeedWork;
using FiDeli.Domain.Statuses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Domain.Core.Commissions
{
    public class Commission : Entity, IAggregateRoot
    {
        public Commissioner Commissioner { get; set; }
        public Recipient Recipient { get; set; }
        public ParcelLocker TargetParceLocker { get; set; }
        public ParcelLocker SourceParcelLocker { get; set; }
        public CommissionStatus CommissionStatus { get; set; }
        public DeliveryStatus DeliveryStatus { get; set; } //prolly state design pattern
        public decimal Price { get; set; }
        public Parcel Parcel { get; set; }

      
    }

    
}
