using System;
using Fiorello.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiorello.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {
        }
        public DbSet<Slider> sliders { get; set; }
        public DbSet<SlidersInfo> slidersInfos { get; set; }
        public DbSet<Blog> blogs { get; set; }
        public DbSet<Experts> experts { get; set; }
        public DbSet<Valentine> valentines { get; set; }
        public DbSet<About> abouts { get; set; }
        public DbSet<Instagram> instagrams { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Image> images { get; set; }
        public DbSet<Discount> discounts { get; set; }
    }
}

