using FiDeli.Application.Services.Interfaces.RepositoryInterfaces;
using FiDeli.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Infrastructure.Repos.IMRepos
{
    public class IMCommissionerRepo : 
        IMLocalisableRepository<Commissioner>, 
        ICommissionerRepo 
    {

        public IMCommissionerRepo()
        {
            _entities.Add(new Commissioner("ab", "cd", "111111111", "aaa@gma.com"));
            _entities.Add(new Commissioner("bdd", "cddddd", "112111111", "aassssa@gma.com"));
            _entities.Add(new Commissioner("abvvv", "cdvvv", "111111131", "aaaaa@gma.com"));

        }
    }
}
