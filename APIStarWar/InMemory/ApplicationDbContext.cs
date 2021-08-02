using APIStarWar.Controllers;
using APIStarWar.Models;
using APIStarWar.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StarWarsApiCSharp;
using System;
using System.Linq;
using System.Reflection;

namespace APIStarWar.InMemory
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Workshop> Workshops { get; set; }
        public DbSet<Models.Film> Films { get; set; }
        public DbSet<People> Peoples { get; set; }
        public DbSet<Models.Planet> Planets { get; set; }
        public DbSet<Models.Specie> Species { get; set; }
        public DbSet<Models.Starship> Starships { get; set; }
        public DbSet<Models.Vehicle> Vehicles { get; set; }
        public string DbPath { get; private set; }

        static ILoggerFactory ContextLoggerFactory
        => LoggerFactory.Create(b => b.AddConsole().AddFilter("", LogLevel.Information));
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> context) : base(context)
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}swapidb.sqlite";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}").UseLoggerFactory(ContextLoggerFactory);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedFilms();
            modelBuilder.SeedPeoples();
            modelBuilder.SeedPlanets();
            modelBuilder.SeedSpecies();
            modelBuilder.SeedStarships();
            modelBuilder.SeedVehicles();
        }

    }

}

