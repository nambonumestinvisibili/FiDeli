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
        ILocalisableRepo<Commissioner> 
    {

        public IMCommissionerRepo()
        {
            //_entities.Add()
        }
    }
}
