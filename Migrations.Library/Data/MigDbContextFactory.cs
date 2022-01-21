using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Migrations.Library.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations.Library.Data
{
    public class MigDbContextFactory : IDesignTimeDbContextFactory<MigDbContext>
    {
        public const string _appSettingPath =
            @"D:\DotNetDev\MigrationApp\Migrations.Web\appsettings.json";

        public MigDbContext CreateDbContext(string[] args)
        {
            // DbContextOptions<MigDbContext> options
            var optionsBuilder = new DbContextOptionsBuilder<MigDbContext>();
            optionsBuilder.UseSqlServer(new DbConnector(_appSettingPath).GetConnectionString());
            return new MigDbContext(optionsBuilder.Options);
        }
    }
}
