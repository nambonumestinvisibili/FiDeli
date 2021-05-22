using FiDeli.Application.Services.Interfaces.RepositoryInterfaces;
using FiDeli.Domain;
using FiDeli.Domain.SeedWork;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Infrastructure.Repos.IMRepos
{
    public abstract class IMEntityRepository<T> : IEntityRepo<T> where T : Entity
    {
        protected List<T> _entities = new List<T>();

        public Task Add(T item)
        {
            _entities.Add(item);
            return Task.CompletedTask;
        }

        public Task Delete(T item)
        {
            _entities.Remove(item);
            return Task.CompletedTask;

        }

        public Task<ICollection<T>> FindAll()
        {
            return Task.FromResult((ICollection<T>)_entities);
        }

        public Task<T> FindById(Guid id)
        {
            return Task.FromResult(_entities
                .FirstOrDefault(x => x.Id == id));
        }

        public Task Update(T item)
        {
            int index = _entities.IndexOf(item);
            if (index != -1)
            {
                _entities[index] = item;
            }
            return Task.CompletedTask;
        }
    }

    public abstract class IMLocalisableRepository<T> :
        IMEntityRepository<T>, 
        ILocalisableRepo<T> where T : Localisable
    {
        public Task<T> FindCloseToTheLocation(GeoLocation location)
        {
            return Task.FromResult(_entities.Find(x => x.CurrentLocation == location));
        }
    }
}
