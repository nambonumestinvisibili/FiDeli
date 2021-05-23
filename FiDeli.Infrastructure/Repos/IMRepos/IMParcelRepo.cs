using FiDeli.Application.Services.Interfaces.RepositoryInterfaces;
using FiDeli.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Infrastructure.Repos.IMRepos
{
    public class IMParcelRepo : 
        IMEntityRepository<Parcel>,
        IParcelRepo
    {

        public IMParcelRepo()
        {
            for (int i = 0; i < 60; i++)
            {
                _entities.Add(new Parcel((Size)(i % 3)));
            }
        }
    }
}
