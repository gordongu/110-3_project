using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Protocols;

namespace WanderList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            FileInfo createFile = new FileInfo(@"scripts\create.sql");
            FileInfo insertFile = new FileInfo(@"scripts\insert.sql");

            string createScript = createFile.OpenText().ReadToEnd();
            string insertScript = insertFile.OpenText().ReadToEnd();

            try
            {
                //con.Open();
                //SqlCommand create = new SqlCommand(createScript, con);
                //create.ExecuteNonQuery();
                //SqlCommand insert = new SqlCommand(insertScript, con);
                //insert.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                con.Close();
            }


            BuildWebHost(args).Run();

        }

        public static IWebHost BuildWebHost(string[] args) => WebHost.CreateDefaultBuilder(args).UseStartup<Startup>().Build();

    }
}
