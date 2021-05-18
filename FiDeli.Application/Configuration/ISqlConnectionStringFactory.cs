using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Application.Configuration
{
    public interface ISqlConnectionStringFactory 
    {
        IDbConnection GetOpenConnection();
    }
}
