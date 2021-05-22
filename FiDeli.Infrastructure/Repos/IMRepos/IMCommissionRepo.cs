using FiDeli.Application.Services.Interfaces.RepositoryInterfaces;
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
            _entities.Add(new Commission());
            _entities.Add(new Commission());
            _entities.Add(new Commission());

        }


    }
}
