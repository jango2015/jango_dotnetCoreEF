using demo.Models;
using Microsoft.EntityFrameworkCore;

namespace demo.Data
{
    public class DemoBDbContext : DbContext
    {
        public DemoBDbContext(DbContextOptions<DemoBDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            // var builder = new ConfigurationBuilder()
            //          .AddJsonFile("../appsettings.json", optional: false, reloadOnChange: true);
            // var configuration = builder.Build();
            // optionBuilder.UseSqlite(configuration.GetConnectionString("ConnectionB"));
            base.OnConfiguring(optionBuilder);
        }
        public virtual DbSet<DemoB> DemoBs { get; set; }
    }
}