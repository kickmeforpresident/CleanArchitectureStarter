using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        public DbSet<Todo> Todos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().HasData(new Todo { Id = 1, Content = "First" });
            modelBuilder.Entity<Todo>().HasData(new Todo { Id = 2, Content = "Second" });
            modelBuilder.Entity<Todo>().HasData(new Todo { Id = 3, Content = "Third" });
        }
    }
}
