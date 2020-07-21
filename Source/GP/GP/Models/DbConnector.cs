using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;


namespace GP.Models
{
    public class DbConnector
    {
        private static SqlConnection cnn = null;

        public static SqlConnection Connect()
        {
            string connectionString = null;
            var configuration = GetConfiguration();

            connectionString = configuration.GetSection("Data").GetSection("ConnectionString").Value;

            try
            {
                if (cnn == null)
                {
                    cnn = new SqlConnection(connectionString);
                }
                if (cnn.State != ConnectionState.Open)
                {
                    cnn.Open();
                }
                return cnn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return null;
        }

        public static IConfigurationRoot GetConfiguration()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            return builder.Build();
        }

    }
}
