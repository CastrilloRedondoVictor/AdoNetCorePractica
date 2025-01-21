using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace AdoNetCorePractica.Helpers
{
    public class ConfigurationHelper
    {
        public static string GetSqlTemplate()
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("configurations.json");
            IConfigurationRoot configurationRoot = builder.Build();
            string root = configurationRoot.GetConnectionString("SqlTemplate");
            return root;
        }
    }
}
