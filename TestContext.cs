using Microsoft.EntityFrameworkCore;

namespace ConsoleApp {

    public class TestContext : DbContext
    {
        public DbSet<UnitTest>? UnitTests { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer($"Data Source=localhost,1433;Initial Catalog=master;User ID=SA;Password=AdM!n123;");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var tableUnitTest = modelBuilder?.Entity<UnitTest>();
            tableUnitTest?.HasKey(t => t.Id);
        }
    }

    public class UnitTest
    {
        public int Id {get;set;}
        public string? Name {get;set;}
    }
 }