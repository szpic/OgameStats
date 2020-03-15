using Microsoft.EntityFrameworkCore;
using OgameStats.DataBase.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgameStats.DataBase
{
    public class OgameStatsContext  : DbContext
    {

        public OgameStatsContext(DbContextOptions<OgameStatsContext> options) : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure default schema
            modelBuilder.HasDefaultSchema("dbo");

            //Map entity to table
            modelBuilder.Entity<Player>().ToTable("Players");
        }
    }
}
