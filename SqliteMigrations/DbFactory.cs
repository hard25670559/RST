using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using RSTRepsitory;

namespace SqliteMigrations
{
    public class DbFactory : IDesignTimeDbContextFactory<RSTContext>
    {
        public DbFactory()
        {
        }

        public RSTContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<RSTContext> optionsBuilder = new DbContextOptionsBuilder<RSTContext>();
            optionsBuilder.UseSqlite("Data Source=/Users/hardanonymous/Projects/RepositoryServiceTest/RSTAPI/RST.db", options => options.MigrationsAssembly(typeof(DbFactory).Namespace));

            return new RSTContext(optionsBuilder.Options);
        }
    }
}
