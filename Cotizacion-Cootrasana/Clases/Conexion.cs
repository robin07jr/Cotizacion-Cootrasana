using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Cotizacion_Cootrasana.Clases
{
     class Conexion
    {
        MySqlConnection conex = new MySqlConnection();

        static string servidor = "localhost";
        static string bd = "cotizacion";
        static string usuario= "root";
        static string password = "";
        static string puerto = "3306";

        string cadenaconexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

       

        internal static void Close()
        {
            
        }

        internal static void Open()
        {
           
        }
    }

}
