using Microsoft.EntityFrameworkCore;
using RepoLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoLayer.Context
{
    public class FundooDBContext:DbContext
    {
        public FundooDBContext(DbContextOptions options):base(options) { }

        public DbSet<UserTable> UserTable { get; set; }
        
    }
}
