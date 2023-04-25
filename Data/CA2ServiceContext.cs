using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CA2WebService;

namespace CA2Service.Data
{
    public class CA2ServiceContext : DbContext
    {
        public CA2ServiceContext (DbContextOptions<CA2ServiceContext> options)
            : base(options)
        {
        }

        public DbSet<CA2WebService.Library> Library { get; set; }

        public DbSet<CA2WebService.Book> Book { get; set; }
    }
}
