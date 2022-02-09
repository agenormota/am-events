using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AM.Events.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AM.Events.API.Data
{
    public class DataContext : DbContext
    {
         public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<Event> Events { get; set; }
    }
}