using Gabo.Models.Structure;
using Microsoft.EntityFrameworkCore;

namespace Gabo.Infrastructure.Context
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/ef/core/get-started/?tabs=netcore-cli
    /// </summary>
    public class GaboContext : DbContext
    {
        // [To apply migrations]
        // cd Gabo.Infrastructure
        // dotnet ef migrations add InitialCreate
        // dotnet ef database update

        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=GaboDatabase.db");
    }
}
