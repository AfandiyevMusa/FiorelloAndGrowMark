using System;
using GrowMark_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace GrowMark_Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {
        }
        public DbSet<Slider> sliders { get; set; }
        public DbSet<Features> features { get; set; }
        public DbSet<Services> services { get; set; }
        public DbSet<TeamMembers> teamMembers { get; set; }
        public DbSet<ProjectDetails> projectDetails { get; set; }
    }
}

