using FiDeli.Domain;
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



}
