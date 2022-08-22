using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SMECommerce.Models.EntityModels;
using SMECommerce.Models.EntityModels.Identity;

namespace SMECommerce.Databases.DbContexts
{
    public class SMECommerceDbContext : IdentityDbContext<AppUser,AppRole,int>
    {
        public SMECommerceDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string connectionString = @"Server=(local)\SQLEXPRESS;Database=SMECommerceDbRashed; Integrated Security=true";
            //optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<AppUser>(b =>
            {

                b.ToTable("AppUsers");
            });
        }
    }
}
