using FiDeli.Domain;
using FiDeli.Domain.Core.Commissions;
using System;

namespace FiDeli.Application.Services.Interfaces
{
    public interface ICommissionCreator
    {
        public Commission CreateCommission();
    }

    
}
