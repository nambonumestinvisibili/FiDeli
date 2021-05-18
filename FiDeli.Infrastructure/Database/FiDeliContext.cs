using FiDeli.Domain;
using FiDeli.Domain.Core.Commissions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Infrastructure.Repos.Database
{
    public class FiDeliContext : DbContext
    {
        public FiDeliContext(DbContextOptions<FiDeliContext> options) : base(options)
        {
        }

        public DbSet<Commission> Commissions { get; set; }
        public DbSet<Deliverer> Deliverers { get; set; }
    }
}
