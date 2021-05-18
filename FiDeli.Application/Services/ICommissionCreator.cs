using FiDeli.Domain;
using FiDeli.Domain.Core.Commissions;
using System;

namespace FiDeli.Application
{
    public interface ICommissionCreator
    {
        public Commission CreateCommission();
    }

    
}
