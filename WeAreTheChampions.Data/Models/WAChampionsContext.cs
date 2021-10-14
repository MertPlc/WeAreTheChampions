using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Data
{
    public class WAChampionsContext : DbContext
    {
        public WAChampionsContext() : base("name=WAChampionsConnection")
        {

        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Color> Colors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>().HasRequired(x => x.Team1).WithMany(y => y.HomeMatches).HasForeignKey(z => z.Team1Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<Match>().HasRequired(x => x.Team2).WithMany(y => y.AwayMatches).HasForeignKey(z => z.Team2Id).WillCascadeOnDelete(false);
        }
    }
}
