﻿using HouseRentingSystem.Infrastructure.Data.Configuration;
using HouseRentingSystem.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Agent> Agents { get; set; } = null!;
        public DbSet<House> Houses { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UsersConfiguration());
            builder.ApplyConfiguration(new AgentsConfiguration());
            builder.ApplyConfiguration(new CategoriesConfiguration());
            builder.ApplyConfiguration(new HousesConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
