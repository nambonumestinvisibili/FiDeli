﻿using FiDeli.Domain;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Application.Services.Interfaces.RepositoryInterfaces

{
    public interface IEntityRepo<T> where T : Entity
    {
        Task<ICollection<T>> FindAll();
        Task<T> FindById(Guid id);
        Task Add(T item);
        Task Update(T item);
        Task Delete(T item);

    }

    public interface ILocalisableRepo<T> : IEntityRepo<T> where T : Entity
    {
        Task<T> FindCloseToTheLocation(GeoLocation location);
    }
}