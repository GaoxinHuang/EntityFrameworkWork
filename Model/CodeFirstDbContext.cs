using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CodeFirstDbContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Account> Account { get; set; }
    }
}
