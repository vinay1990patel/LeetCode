using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Options;
using MixSample.Controllers;
using MixSample.Model;

namespace MixSample.DbContextLayer
{
    public class MixedDbContext: IdentityDbContext<ApplicationUser>
    {


        public MixedDbContext()
        {

        }
        public MixedDbContext (DbContextOptions<MixedDbContext> dbContextOptions ): base( dbContextOptions)
        {
             

        }



      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Employee>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<WeatherForecast>()
                               .HasNoKey();
            modelBuilder.Entity<Book>()
                         .HasKey(p => p.Id);

            base.OnModelCreating(modelBuilder);
           
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            //if (!dbContextOptionsBuilder.IsConfigured)
            //{
            //    IConfigurationRoot configuration = new ConfigurationBuilder()
            //       .SetBasePath(Directory.GetCurrentDirectory())
            //       .AddJsonFile("appsettings.json")
            //       .Build();
            //    var connectionString = configuration.GetConnectionString("MixedDbContextConnectionString");
            //    dbContextOptionsBuilder.UseSqlServer(connectionString);
            //}

            base.OnConfiguring(dbContextOptionsBuilder);
        }


        public DbSet< WeatherForecast> weatherForecasts { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Book> books { get; set; }  
        public DbSet<ApplicationUser> applicationUsers { get; set; }


    }
}
