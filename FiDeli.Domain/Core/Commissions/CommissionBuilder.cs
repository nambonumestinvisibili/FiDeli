//using FiDeli.Domain.Statuses;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FiDeli.Domain.Core.Commissions
//{
//    public class CommissionBuilder
//    {
//        public Commissioner Commissioner;
//        public Recipient Recipient;
//        public ParcelLocker TargetParceLocker;
//        public ParcelLocker SourceParcelLocker;
//        public CommissionStatus CommissionStatus;
//        public IDeliveryStatus DeliveryStatus;
//        public decimal Price;
//        public Parcel Parcel;

//        public CommissionBuilder()
//        {
//            CommissionStatus = CommissionStatus.Draft;
//        }

//        public CommissionBuilder SetCommissioner(Commissioner commissioner)
//        {
//            Commissioner = commissioner;
//            return this;
//        }

//        public CommissionBuilder SetRecipient(Recipient recipient)
//        {
//            Recipient = recipient;
//            return this;
//        }

//        public CommissionBuilder SetTargetParcelLocker(ParcelLocker parcelLocker)
//        {
//            TargetParceLocker = parcelLocker;
//            return this;
//        }

//        public CommissionBuilder SetSourceParcelLocker(ParcelLocker parcelLocker)
//        {
//            SourceParcelLocker = parcelLocker;
//            return this;
//        }

//        public CommissionBuilder SetPrice(decimal price)
//        {
//            Price = price;
//            return this;
//        }

//        public Commission Build()
//        {
//            if (Commissioner is null || Parcel is null ||
//                Recipient is null || SourceParcelLocker is null || TargetParceLocker is null)
//            {
//                throw new Exception("");
//            }
//            return new Commission
//            {
//                //Id = Guid.NewGuid(),
//                Commissioner = Commissioner,
//                CommissionStatus = CommissionStatus,
//                Parcel = Parcel,
//                Price = Price,
//                Recipient = Recipient,
//                SourceParcelLocker = SourceParcelLocker,
//                TargetParceLocker = TargetParceLocker,
//                DeliveryStatus = DeliveryStatus
//            };
//        }
//    }
//}
