using Microsoft.EntityFrameworkCore;
using Praksa.Dal.Domain;
using Praksa.Domain;
using System.Collections.Generic;

namespace Praksa.Dal.Context
{
    public class EShopDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
