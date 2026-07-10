using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TashGresOpto.Data.Context
{
    /// <summary>
    /// Factory ��� ᮧ����� DbContext �� �६� ����権
    /// </summary>
    public class OptoDbContextFactory : IDesignTimeDbContextFactory<OptoDbContext>
    {
        public OptoDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<OptoDbContext>();
            optionsBuilder.UseSqlite("Data Source=TashGresOpto.db");

            return new OptoDbContext(optionsBuilder.Options);
        }
    }
}
