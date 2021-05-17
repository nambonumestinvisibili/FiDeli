using FiDeli.Domain;
using FiDeli.Domain.Core.Commissions;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Infrastructure.Repos.MongoRepos
{
    public class MongoCommissionerRepo :
        MongoLocalisableRepo<Commissioner>,
        ILocalisableRepo<Commissioner>
    {
        public MongoCommissionerRepo(IMongoClient client) : base(client)
        {
        }

    }

    public class MongoCommissionRepo :
        MongoEntityRepo<Commission>,
        IEntityRepo<Commission>
    {
        public MongoCommissionRepo(IMongoClient client) : base(client)
        {
        }

    }

    public class MongoDelivererRepo :
        MongoLocalisableRepo<Deliverer>,
        ILocalisableRepo<Deliverer>
    {
        public MongoDelivererRepo(IMongoClient client) : base(client)
        {
        }
    }

    public class MongoRecipientRepo :
        MongoLocalisableRepo<Recipient>,
        ILocalisableRepo<Recipient>
    {
        public MongoRecipientRepo(IMongoClient client) : base(client)
        {
        }
    }
}
