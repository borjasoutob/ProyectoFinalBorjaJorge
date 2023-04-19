using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
namespace Acceso_Datos
{
    public class Prueba_json
    {
        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //Using hard coded connection string here 
            //optionsBuilder.UsesqlServer(@"Data Source= ;Initial Catalog= ;Integrated Security=true; ")

            //Reading connetion String from ASP.net Come MVC app's appsettings.json file in this class library

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            var dbConectionInfo = builder.Build().GetSection("ConnectionStrings").GetSection("DemoDBConnectionStrings").Value;

            //using retrieved connection info to Conect to Sql server
            optionsBuilder.UsesqlServer(dbConectionInfo);
        }
        */
    }
}
