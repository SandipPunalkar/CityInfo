using CityInfo.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityInfo.API.DbContexts
{
    public class CityInfoContext : DbContext
    {
        public CityInfoContext(DbContextOptions<CityInfoContext> options): base(options)
        {

        }

        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<PointOfInterest> PointsOfInterest { get; set; } = null!;

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("connectionstring");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
