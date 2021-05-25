using FiDeli.Application.Services.Interfaces.RepositoryInterfaces;
using FiDeli.Domain.Core;
using FiDeli.Domain.Core.Commissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Infrastructure.Repos.IMRepos
{
    public class IMCommissionRepo : IMEntityRepository<Commission>, ICommissionRepo
    {
        public IMCommissionRepo()
        {
            Populate();
        }

        public async void Populate()
        {
            var cmr = (await new IMCommissionerRepo().FindAll()).First();
            var rcp = (await new IMRecipientRepo().FindAll()).First();
            var parlock = (await new IMParcelLockerRepo().FindAll()).First();
            var parc = (await new IMParcelRepo().FindAll()).First();

            Commission commission = new Commission()
            {
                Commissioner = cmr,
                Recipient = rcp,
                Price = 10,
                TargetParceLocker = parlock,
                Parcel = parc,
                CommissionStatus = Domain.Statuses.CommissionStatus.Draft,
                DeliveryStatus = Domain.DeliveryStatus.NotStarted,
                Id = 1

            };

            _entities.Add(commission);
        }

        public Commission FindCommissionByParcelCode(ParcelCode parcelCode)
        {
            return _entities.Where(x => x.Parcel.CommissionerCode == parcelCode ||
            x.Parcel.DeliverersCodes.Contains(parcelCode) || x.Parcel.RecipientCode == parcelCode)
                .FirstOrDefault();
        }
    }
}
