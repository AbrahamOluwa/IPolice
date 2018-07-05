using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using IPolice.Core.Entities;

namespace IPolice.Infrastructure.Data.Data
{
    public class WozaDbContext : DbContext
    {
        public WozaDbContext(DbContextOptions<WozaDbContext> options) : base(options)
        {
        }

        public DbSet<ArmyBarrack> ArmyBarracks { get; set; }
        public DbSet<CivilDefense> CivilDefenses { get; set; }
        public DbSet<FireServiceStation> FireServiceStations { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<LocalAgency> LocalAgencies { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<PoliceStation> PoliceStations { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
