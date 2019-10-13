using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using MoneyWatchdog.Models;

namespace MoneyWatchdog.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<GetCsvData> CsvData { get; set; }
        public DbSet<Budget> Budget { get; set; }
        public DbSet<MoneyWatchdog> MoneyWatchdog { get; set; }
    }
}