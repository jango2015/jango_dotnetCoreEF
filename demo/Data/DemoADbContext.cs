using demo.Models;
using Microsoft.EntityFrameworkCore;

namespace demo.Data
{
    public class DemoADbContext : DbContext
    {
        public DemoADbContext(DbContextOptions<DemoADbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            // var builder = new ConfigurationBuilder()
            //         .AddJsonFile("../appsettings.json", optional: false, reloadOnChange: true);
            // var configuration = builder.Build();
            // optionBuilder.UseSqlite(configuration.GetConnectionString("ConnectionB"));
            base.OnConfiguring(optionBuilder);
        }
        public virtual DbSet<DemoA> DemoAs { get; set; }
    }
}