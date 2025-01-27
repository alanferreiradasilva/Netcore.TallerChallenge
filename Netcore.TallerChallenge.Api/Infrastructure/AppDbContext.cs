using Microsoft.EntityFrameworkCore;
using Netcore.TallerChallenge.Api.Abstractions;
using System;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace Netcore.TallerChallenge.Api.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
          : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("inmemory");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var users = new List<User> {
                new User { Id = 1, Name = "John Doe", Username = "johnd", Password = "123456" },
                new User { Id = 2, Name = "Maria Test", Username = "mariat", Password = "123456" },
                new User { Id = 3, Name = "Carlos Garcia", Username = "carlosg", Password = "123456" },
            };

            modelBuilder.Entity<User>().HasData(users);
        }
    }
}
