using FiDeli.Domain;
using FiDeli.Domain.Core;
using FiDeli.Domain.Core.Commissions;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Application.Services.Interfaces.RepositoryInterfaces
{
    public interface ICommissionRepo : IEntityRepo<Commission>
    {
        Commission FindCommissionByParcelCode(ParcelCode parcelCode);
    }
    public interface IDelivererRepo : ILocalisableRepo<Deliverer>
    {
    }
    public interface IParcelLockerRepo : ILocalisableRepo<ParcelLocker>
    {
    }
    public interface ICommissionerRepo : ILocalisableRepo<Commissioner>
    {
    }
    public interface IRecipientRepo : ILocalisableRepo<Recipient> 
    { 
    }

    public interface IParcelRepo : IEntityRepo<Parcel>
    {

    }


}
