using EntityFrameworkCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Data
{
    public class FootballLeagueDbContext : DbContext
    {
        public FootballLeagueDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Combine(path, "FootballLeague_EfCore.db");
        }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Coach> Coaches { get; set; }

        //property path 
        public string DbPath { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Using Sqlite
            optionsBuilder.UseSqlite($"Data Source={DbPath}")
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging()// DONT use production workloads ; expose personal password and so on
                .EnableDetailedErrors() ;  //DONT use production workloads


            //f you're okay with ignoring the warning, you can suppress it by configuring warnings in your DbContext
            optionsBuilder.ConfigureWarnings(warnings =>
               warnings.Ignore(RelationalEventId.PendingModelChangesWarning));

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasData(
                 new Team { TeamId = 1,Name="Manchester United",CreatedDate=DateTimeOffset.UtcNow.DateTime },
                 new Team { TeamId = 2, Name = "Liverpool", CreatedDate = DateTimeOffset.UtcNow.DateTime },
                 new Team { TeamId = 3, Name = "Spur", CreatedDate = DateTimeOffset.UtcNow.DateTime }
                );

         

        }


    }
}
