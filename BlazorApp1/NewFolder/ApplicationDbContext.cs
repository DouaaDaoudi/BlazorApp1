using System.Collections.Generic;
using BlazorApp1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.NewFolder
{
    public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<FruitList> Fruits { get; set; } = null!;
    }
}
