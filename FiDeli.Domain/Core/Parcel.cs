using FiDeli.Domain.Core;
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

        public ParcelCode CommissionerCode {get;set;}
        public ParcelCode RecipientCode { get; set; }
        public List<ParcelCode> DeliverersCodes { get; set; }

        public bool CanBeOpenedBy<T>(ParcelCode code) where T : Person {
            if (typeof(T) == typeof(Commissioner))
            {
                return CommissionerCode == code;
            }
            else if (typeof(T) == typeof(Deliverer))
            {
                return DeliverersCodes.Contains(code);
            }
            else if (typeof(T) == typeof(Recipient))
            {
                return RecipientCode == code;
            }
            return false;

        }
    }
}
