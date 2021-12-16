using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BeerLeagueHockey.Models
{
    public class MyDatabaseContext : DbContext
    {
        public MyDatabaseContext (DbContextOptions<MyDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<BeerLeagueHockey.Models.Todo> Todo { get; set; }
    }
}
