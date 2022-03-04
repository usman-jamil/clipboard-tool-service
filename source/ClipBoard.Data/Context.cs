using System;
using ClipBoard.Domain;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;



namespace ClipBoard.Data
{
     public class Context:DbContext
    {
        public DbSet<Clip> Clips { get; set; }
        public DbSet<Resource> Resources { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=postgres;UserId=postgres;Password=postgres;");
        }
    }
}
