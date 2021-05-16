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
        public List<CommissionBuilder> DraftCommisions { get; set; }
        public List<Commission> Commissions { get; set; }

        public CommissionBuilder CreateDraftCommission(Recipient recipient, ParcelLocker targetParcelLocker, decimal price)
        {
            CommissionBuilder commissionBuilder = new CommissionBuilder()
                .SetCommissioner(this)
                .SetRecipient(recipient)
                .SetTargetParcelLocker(targetParcelLocker)
                .SetPrice(price);
            DraftCommisions.Add(commissionBuilder);
            return commissionBuilder;
        }       

        public Commission FinishDraftCommission(CommissionBuilder commissionBuilder, ParcelLocker targetParcelLocker)
        {
            DraftCommisions.Remove(commissionBuilder);
            var commission = commissionBuilder.SetTargetParcelLocker(targetParcelLocker).Build();
            Commissions.Add(commission);
            return commission;
        }
        
    }
}
