using Microsoft.EntityFrameworkCore;
using MixSample.Model;

namespace MixSample.DbContextLayer
{
    public class MixedDbContext: DbContext
    {
        

        public MixedDbContext()
        {

        }
        public MixedDbContext (DbContextOptions<MixedDbContext> dbContextOptions ): base( dbContextOptions)
        {

        }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {

        }


        public DbSet< WeatherForecast> weatherForecasts { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Book> books { get; set; }  


    }
}
