using Praksa.Dal.Domain;
using Praksa.Domain;
using System.Collections.Generic;

namespace Praksa.Dal.Context
{
    public class EShopDbContext
    {
        public List<User> Users { get; set; }
        public List<Account> Accounts { get; set; }
    }
}
