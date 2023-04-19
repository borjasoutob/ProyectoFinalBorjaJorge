using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;


namespace Acceso_Datos
{
    public class Prueba_conexion
    {
       SqlConnection Conexion_xml = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["cnnString"].ConnectionString); 
    }
     
}
