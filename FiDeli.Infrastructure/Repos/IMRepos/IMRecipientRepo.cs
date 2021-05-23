using FiDeli.Application.Services.Interfaces.RepositoryInterfaces;
using FiDeli.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Infrastructure.Repos.IMRepos
{
    public class IMRecipientRepo :
        IMLocalisableRepository<Recipient>,
        IRecipientRepo
    {

        public IMRecipientRepo()
        {
            _entities.Add(new Recipient("dawid", "holewa", "725272885", "dawid@gmail.com"));
            _entities.Add(new Recipient("a", "bvvvvv", "125272885", "dawid2@gmail.com"));
            _entities.Add(new Recipient("ccc", "dddd", "225272885", "dawid3@gmail.com"));
            _entities.Add(new Recipient("mmm", "aaaa", "325272885", "dawi4d@gmail.com"));

        }
    }
}
