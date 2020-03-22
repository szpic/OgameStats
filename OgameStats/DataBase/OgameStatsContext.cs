using Microsoft.EntityFrameworkCore;
using OgameStats.DataBase.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgameStats.DataBase
{
    public class OgameStatsContext : DbContext
    {

        public OgameStatsContext(DbContextOptions<OgameStatsContext> options) : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Planet> Planets { get; set; }
        public DbSet<Alliance> Alliances { get; set; }
        public DbSet<PlayerScore> HighScore { get; set; }
        public DbSet<Moon> Moons { get; set; }
        public DbSet<DataUpdates> DataUpdates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure default schema
            modelBuilder.HasDefaultSchema("dbo");

            //Map entity to table
            modelBuilder.Entity<Player>().ToTable("Players");
            modelBuilder.Entity<Planet>().ToTable("Planet");
            modelBuilder.Entity<Alliance>().ToTable("Alliance");
            modelBuilder.Entity<Moon>().ToTable("Moon");
            modelBuilder.Entity<PlayerScore>().ToTable("PlayerScore");
            modelBuilder.Entity<DataUpdates>().ToTable("DataUpdates");
        }

        protected DateTime? GetUpdateDate(string name)
        {
            return DataUpdates.Where(w => w.TableName == name).FirstOrDefault()?.UpdateTime;
        }
    }
}
