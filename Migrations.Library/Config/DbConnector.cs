using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations.Library.Config
{
    public class DbConnector
    {
        private readonly string _connectionString = string.Empty;

        public DbConnector(string appSettingPath)
        {
            var configBuilder = new ConfigurationBuilder();
            configBuilder.AddJsonFile(appSettingPath);

            _connectionString =
                configBuilder.Build()["ConnectionStrings:DefaultConnection"];
        }

        public string GetConnectionString() => _connectionString;
    }
}
