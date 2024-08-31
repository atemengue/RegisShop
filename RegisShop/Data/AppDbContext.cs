﻿using BethanysPieShopHRM.Shared.Domain;
using Microsoft.EntityFrameworkCore;

namespace RegisShop.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
    }
}
