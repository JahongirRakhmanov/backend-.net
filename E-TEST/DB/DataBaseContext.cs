using E_TEST.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace E_TEST.DB
{
    public class DataBaseContext : DbContext
    {
        protected readonly IConfiguration _configuration;
        public DataBaseContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public DbSet<Region> regions { get; set; }
        public DbSet<School> branches { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString("PostgreSQL"));
        }
    }
}
