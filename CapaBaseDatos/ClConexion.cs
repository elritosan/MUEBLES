using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBaseDatos
{
    public class ClConexion
    {
        public string cadena = "Data Source= DESKTOP-INMNSS5\\SQLEXPRESS; Initial Catalog = BDMuebles; Integrated Security=True";
        public SqlConnection conectar = new SqlConnection();

        public ClConexion()
        {
            conectar.ConnectionString = cadena;
        }

        public void Abrir()
        {
            try
            {
                conectar.Open();
                Console.WriteLine("Conexión Abierta");
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Error al Conectar", ex.Message);
            }
        }

        public void Cerrar()
        {
            conectar.Close();
            Console.WriteLine("Conexion cerrada");
        }
    }
}
