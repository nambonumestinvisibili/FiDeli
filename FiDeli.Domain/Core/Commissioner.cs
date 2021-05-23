using FiDeli.Domain.Core.Commissions;
using FiDeli.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Domain
{
    public class Commissioner : Person, IAggregateRoot
    {
        public Commissioner(string firstName, string surname, string phoneNumber, string emailAddress) :
            base(firstName, surname, phoneNumber, emailAddress)
        {
        }

        public List<Commission> DraftCommisions { get; set; }
        public List<Commission> Commissions { get; set; }

        public Commission CreateDraftCommission(Recipient recipient, ParcelLocker targetParcelLocker, decimal price)
        {
            Commission commission = new Commission { Recipient = recipient, TargetParceLocker = targetParcelLocker, Price = price };

            DraftCommisions.Add(commission);
            return commission;
        }       

        public Commission FinishDraftCommission(Commission commission, ParcelLocker sourceParcelLocker)
        {
            DraftCommisions.Remove(commission);
            commission.SourceParcelLocker = sourceParcelLocker;
            Commissions.Add(commission);
            return commission;
        }
        
    }
}
