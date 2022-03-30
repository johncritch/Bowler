using System;
using Microsoft.EntityFrameworkCore;

namespace Bowler.Models
{
    public class BowlersDbContext: DbContext
    {
        public BowlersDbContext(DbContextOptions<BowlersDbContext> options) : base(options)
        {

        }

        public DbSet<Bowlers> Bowlers { get; set; }
        public DbSet<Teams> Teams { get; set; }
    }
}
