using FiDeli.Application.Services.Interfaces.RepositoryInterfaces;
using FiDeli.Domain;
using FiDeli.Infrastructure.Repos.IMRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.ApplicationTests
{
    public class Utils
    {
        public ICommissionerRepo CommissionerRepo { get; }
        public IRecipientRepo recipientRepo { get; }
        public IParcelLockerRepo parcelLockerRepo { get; }
        public IParcelRepo parcelRepo { get; }
        public IDelivererRepo delivererRepo { get; }
        public ICommissionRepo commissionRepo { get; }
        public Utils()
        {
            CommissionerRepo = new IMCommissionerRepo();
            recipientRepo = new IMRecipientRepo();
            parcelRepo = new IMParcelRepo();
            parcelLockerRepo = new IMParcelLockerRepo();
            delivererRepo = new IMDelivererRepo();
            commissionRepo = new IMCommissionRepo();
        }
    }
}
