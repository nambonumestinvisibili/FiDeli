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
            //_entities.Add()
        }
    }
}
