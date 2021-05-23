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
            
        }

        public Commission FindCommissionByParcelCode(ParcelCode parcelCode)
        {
            return _entities.Where(x => x.Parcel.CommissionerCode == parcelCode ||
            x.Parcel.DeliverersCodes.Contains(parcelCode) || x.Parcel.RecipientCode == parcelCode)
                .FirstOrDefault();
        }
    }
}
