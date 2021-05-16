using FiDeli.Domain;
using FiDeli.Domain.Core.Commissions;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Infrastructure.Repos
{
    public interface ICommissionRepo : IEntityRepo<Commission>
    {
    }
    public interface IDelivererRepo : ILocalisableRepo<Deliverer>
    {
    }
    public interface IParcelLocker : ILocalisableRepo<ParcelLocker>
    {
    }
    public interface ICommissioner : ILocalisableRepo<Commissioner>
    {
    }
    public interface IRecipient : ILocalisableRepo<Recipient> 
    { 
    }



}
