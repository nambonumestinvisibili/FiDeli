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
            _entities.Add(new Deliverer
            {
                Id = Guid.NewGuid(),
                EmailAddress = "a@b.com",
                FirstName = "da",
                Surname = "Ho",
                PhoneNumber = "111111111",
                CurrentLocation = GeoLocation.TryCreate(4, 34)

            });

            _entities.Add(new Deliverer
            {
                Id = Guid.NewGuid(),
                EmailAddress = "b@b.com",
                FirstName = "ca",
                Surname = "de",
                PhoneNumber = "121111111",
                CurrentLocation = GeoLocation.TryCreate(10, 20)
            });
        }

        
    }
}
