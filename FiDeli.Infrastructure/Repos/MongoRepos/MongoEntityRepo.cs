using FiDeli.Application.Services.Interfaces.RepositoryInterfaces;
using FiDeli.Domain;
using FiDeli.Domain.SeedWork;
using MongoDB.Driver;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Infrastructure.Repos.MongoRepos
{
    public abstract class MongoEntityRepo<T> : IEntityRepo<T> where T : Entity
    {
        public IMongoDatabase MongoDatabase { get; }
        protected IMongoCollection<T> _collection;
        public virtual string GetCollectionName()
        {
            return nameof(T);
        }

        public MongoEntityRepo(IMongoClient client)
        {
            MongoDatabase = client.GetDatabase("mydb");
            _collection = MongoDatabase.GetCollection<T>(GetCollectionName());
        }

        public async Task Add(T item)
        {
            await _collection.InsertOneAsync(item);
        }

        public async Task Delete(T item)
        {
            await _collection.DeleteOneAsync(x => x.Id == item.Id);
        }

        public async Task<ICollection<T>> FindAll()
        {
            var res = await _collection.FindAsync<T>(_ => true);
            return (ICollection<T>) res.ToListAsync();
        }

        public async Task<T> FindById(int id)
        {
            var res = await _collection.FindAsync(x => x.Id == id);
            return res.FirstOrDefault();
        }

        public async Task Update(T item)
        {
            await _collection.FindOneAndReplaceAsync(x => x.Id == item.Id, item);
        }

        public Task<bool> Exists(int Id)
        {
            throw new NotImplementedException();
        }
    }

    public abstract class MongoLocalisableRepo<T> :
        MongoEntityRepo<T>,
        ILocalisableRepo<T> where T : Localisable
    {
        protected MongoLocalisableRepo(IMongoClient client) : base(client)
        {
        }

        public async Task<T> FindCloseToTheLocation(GeoLocation location)
        {
            var res = await _collection.FindAsync<T>(x => x.CurrentLocation == location);
            return res.FirstOrDefault();
        }
    }
}
