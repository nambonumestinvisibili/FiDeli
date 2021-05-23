using FiDeli.Application.Services.Interfaces.RepositoryInterfaces;
using FiDeli.Domain;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Infrastructure.Repos.IMRepos
{
    public class IMDelivererRepo : IMLocalisableRepository<Deliverer>, IDelivererRepo
    {

        public IMDelivererRepo()
        {
            _entities.Add(new Deliverer ("da", "dadad", "11111112", "qwqqw@wp.pl")
            {
                Id = new Random().Next(),
                EmailAddress = "a@b.com",
                CurrentLocation = GeoLocation.TryCreate(4, 34)

            });

            _entities.Add(new Deliverer("daaaaaaaaaa", "daaaaaaaadad", "111111124", "aaaawqqw@wp.pl")
            {
                Id = new Random().Next(),
                CurrentLocation = GeoLocation.TryCreate(10, 20)
            });
        }

        
    }
}
