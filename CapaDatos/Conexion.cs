using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace CapaDatos
{

    //clase que se utiliza para realizar la conexion a la base de datos 
    public class Conexion
    {
        public static string cn = ConfigurationManager.ConnectionStrings["cadena"].ToString();
    }
}
