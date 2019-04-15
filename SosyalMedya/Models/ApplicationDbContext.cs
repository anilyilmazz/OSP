using Microsoft.EntityFrameworkCore;
using SosyalMedya.Models;
using System.Collections.Generic;
using YemekSepeti.Models;

namespace EFGetStarted.AspNetCore.NewDb.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }


        public DbSet<Users> Users { get; set; }
        public  DbSet<Restorant> Restorants { get; set; }
        public DbSet<Urunler> Urunlers { get; set; }
        public DbSet<Siparis> Siparis { get; set; }
    }
}