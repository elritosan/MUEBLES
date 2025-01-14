using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaBaseDatos
{
    public class ClOperaciones
    {
        ClConexion oConexion = new ClConexion();

        public List<ClCliente> ExisteUsuario(string AuxCorreo, string AuxContrasenia, string AuxCedula)
        {
            try
            {
                oConexion.Abrir();
                string query = "SELECT * FROM Clientes WHERE (correo_electronico = @Correo OR @Correo IS NULL) AND (contrasenia = @AuxContrasenia OR @AuxContrasenia IS NULL) AND (cedula = @AuxCedula OR @AuxCedula IS NULL)";
                SqlCommand CadenaConsulta = new SqlCommand(query, oConexion.conectar);
                SqlDataReader LeerDato = CadenaConsulta.ExecuteReader();

                List<ClCliente> oListaE = new List<ClCliente>();


                while (LeerDato.Read())
                {
                    ClCliente oE = new ClCliente();

                    oE.Cedula = Convert.ToString(LeerDato["cedula"]);
                    oE.Nombre = Convert.ToString(LeerDato["nombre"]);
                    oE.Apellido = Convert.ToString(LeerDato["apellido"]);
                    oE.Ciudad = Convert.ToString(LeerDato["ciudad"]);
                    oE.Edad = Convert.ToInt16(LeerDato["edad"]);
                    oE.FechaNacimiento = Convert.ToDateTime(LeerDato["fecha_nacimiento"]);
                    oE.CorreoElectronico = Convert.ToString(LeerDato["correo_electronico"]);
                    oE.Contrasenia = Convert.ToString(LeerDato["contrasenia"]);
                    oE.tipo_user = Convert.ToString(LeerDato["tipo_user"]);

                    oListaE.Add(oE);
                }
                oConexion.Cerrar();
                return oListaE;
            }
            catch (Exception ex)
            {
                oConexion.Cerrar();
                Console.WriteLine("Error Al Obtener la Información", ex.Message);
                return null;
            }
        }
        public List<ClCliente> ValidarUsuario(string Correo, string AuxContrasenia)
        {
            try
            {
                oConexion.Abrir();
                string query = "SELECT * FROM Clientes WHERE correo_electronico = @Correo AND contrasenia = @Contrasenia";
                SqlCommand CadenaConsulta = new SqlCommand(query, oConexion.conectar);

                // Agregar parámetros
                CadenaConsulta.Parameters.AddWithValue("@Correo", Correo);
                CadenaConsulta.Parameters.AddWithValue("@Contrasenia", AuxContrasenia);

                SqlDataReader LeerDato = CadenaConsulta.ExecuteReader();

                List<ClCliente> oListaE = new List<ClCliente>();


                while (LeerDato.Read())
                {
                    ClCliente oE = new ClCliente();

                    oE.Cedula = Convert.ToString(LeerDato["cedula"]);
                    oE.Nombre = Convert.ToString(LeerDato["nombre"]);
                    oE.Apellido = Convert.ToString(LeerDato["apellido"]);
                    oE.Ciudad = Convert.ToString(LeerDato["ciudad"]);
                    oE.Edad = Convert.ToInt16(LeerDato["edad"]);
                    oE.FechaNacimiento = Convert.ToDateTime(LeerDato["fecha_nacimiento"]);
                    oE.CorreoElectronico = Convert.ToString(LeerDato["correo_electronico"]);
                    oE.Contrasenia = Convert.ToString(LeerDato["contrasenia"]);
                    oE.tipo_user = Convert.ToString(LeerDato["tipo_user"]);

                    Console.WriteLine(Convert.ToString(LeerDato["cedula"]));

                    oListaE.Add(oE);
                }
                oConexion.Cerrar();
                return oListaE;
            }
            catch (Exception ex)
            {
                oConexion.Cerrar();
                Console.WriteLine("Error Al Obtener la Información", ex.Message);
                return null;
            }
        }

        /*
        public void InsertarDatos(ClMueble Datos)
        {
            oConexion.Abrir();
            string SqlCad = "INSERT into Muebles (id_mueble,nombre,tipo,material,color,altura,ancho,profundidad,peso,estilo,precio_coste,precio_venta,cantidad_stock,foto,descripcion) " +
                "VALUES ('" + Datos.IdMueble + "','" + Datos.Nombre + "','" + Datos.Tipo + "','" + Datos.Material + "','" + Datos.Color + "','" + Datos.Altura + "','" + Datos.Ancho + "','" + Datos.Profundidad + "'," +
                "'" + Datos.Peso + "','" + Datos.Estilo + "','" + Datos.PrecioCoste + "','" + Datos.PrecioVenta + "','" + Datos.Cantidad + "','" + Datos.Foto + "','" + Datos.Descripcion + "')";
            SqlCommand ComSql = new SqlCommand(SqlCad, oConexion.conectar);
            ComSql.ExecuteNonQuery();
            oConexion.Cerrar();
        }
        */

        public void InsertarDatos(ClMueble Datos)
        {
            oConexion.Abrir();
            string SqlCad = "INSERT INTO Muebles (id_mueble, nombre, tipo, material, color, altura, ancho, profundidad, peso, estilo, precio_coste, precio_venta, cantidad_stock, foto, descripcion) " +
                "VALUES (@IdMueble, @Nombre, @Tipo, @Material, @Color, @Altura, @Ancho, @Profundidad, @Peso, @Estilo, @PrecioCoste, @PrecioVenta, @Cantidad, @Foto, @Descripcion)";

            using (SqlCommand ComSql = new SqlCommand(SqlCad, oConexion.conectar))
            {
                ComSql.Parameters.AddWithValue("@IdMueble", Datos.IdMueble);
                ComSql.Parameters.AddWithValue("@Nombre", Datos.Nombre);
                ComSql.Parameters.AddWithValue("@Tipo", Datos.Tipo);
                ComSql.Parameters.AddWithValue("@Material", Datos.Material);
                ComSql.Parameters.AddWithValue("@Color", Datos.Color);
                ComSql.Parameters.AddWithValue("@Altura", Datos.Altura);
                ComSql.Parameters.AddWithValue("@Ancho", Datos.Ancho);
                ComSql.Parameters.AddWithValue("@Profundidad", Datos.Profundidad);
                ComSql.Parameters.AddWithValue("@Peso", Datos.Peso);
                ComSql.Parameters.AddWithValue("@Estilo", Datos.Estilo);
                ComSql.Parameters.AddWithValue("@PrecioCoste", Datos.PrecioCoste);
                ComSql.Parameters.AddWithValue("@PrecioVenta", Datos.PrecioVenta);
                ComSql.Parameters.AddWithValue("@Cantidad", Datos.Cantidad);
                ComSql.Parameters.AddWithValue("@Foto", Datos.Foto); // Asegúrate de que Datos.Foto es un byte[]
                ComSql.Parameters.AddWithValue("@Descripcion", Datos.Descripcion);

                ComSql.ExecuteNonQuery();
            }

            oConexion.Cerrar();
        }

        public List<ClMueble> BuscarMueble(int IdMueble)
        {
            try
            {
                oConexion.Abrir();
                string query = "SELECT * FROM Muebles WHERE id_mueble = @Id_Mueble";
                SqlCommand CadenaConsulta = new SqlCommand(query, oConexion.conectar);

                // Agregar parámetros
                CadenaConsulta.Parameters.AddWithValue("@Id_Mueble", IdMueble);

                SqlDataReader LeerDato = CadenaConsulta.ExecuteReader();

                List<ClMueble> oListaE = new List<ClMueble>();

                while (LeerDato.Read())
                {
                    ClMueble oE = new ClMueble();

                    oE.IdMueble = Convert.ToInt32(LeerDato["id_mueble"]);
                    oE.Nombre = Convert.ToString(LeerDato["nombre"]);
                    oE.Tipo = Convert.ToString(LeerDato["tipo"]);
                    oE.Material = Convert.ToString(LeerDato["material"]);
                    oE.Color = Convert.ToString(LeerDato["color"]);
                    oE.Altura = Convert.ToDecimal(LeerDato["altura"]);
                    oE.Ancho = Convert.ToDecimal(LeerDato["ancho"]);
                    oE.Profundidad = Convert.ToDecimal(LeerDato["profundidad"]);
                    oE.Peso = Convert.ToDecimal(LeerDato["peso"]);
                    oE.Estilo = Convert.ToString(LeerDato["estilo"]);
                    oE.PrecioCoste = Convert.ToDecimal(LeerDato["precio_coste"]);
                    oE.PrecioVenta = Convert.ToDecimal(LeerDato["precio_venta"]);
                    oE.Cantidad = Convert.ToInt32(LeerDato["cantidad_stock"]);
                    oE.Foto = (byte[])LeerDato["foto"];
                    oE.Descripcion = Convert.ToString(LeerDato["descripcion"]);


                    oListaE.Add(oE);
                }
                oConexion.Cerrar();
                return oListaE;
            }
            catch (Exception ex)
            {
                oConexion.Cerrar();
                Console.WriteLine("Error Al Obtener la Información de muebles", ex.Message);
                return null;
            }
        }

        public void EliminarMueble(int IdMueble)
        {
            try
            {
                oConexion.Abrir();
                string query = "DELETE FROM Muebles WHERE id_mueble = @Id_Mueble;";
                SqlCommand CadenaInsercion = new SqlCommand(query, oConexion.conectar);
                // Parámetros para la inserción
                CadenaInsercion.Parameters.AddWithValue("@Id_Mueble", IdMueble);

                // Ejecutar la consulta
                CadenaInsercion.ExecuteNonQuery();
                oConexion.Cerrar();
            }
            catch (Exception ex)
            {
                oConexion.Cerrar();
                Console.WriteLine("Error Al Obtener la Información", ex.Message);
            }
        }

        public void EditarMueble(ClMueble oMueble)
        {
            try
            {
                oConexion.Abrir();
                string query = "UPDATE Muebles SET id_mueble = @IdMueble, nombre = @Nombre, foto = @Foto, tipo = @Tipo, material = @Material," +
                    " color = @Color, altura =@Altura, ancho=@Ancho, profundidad=@Profundidad,peso = @Peso, estilo = @Estilo, precio_coste = @PrecioCoste, " +
                    "precio_venta = @PrecioVenta, cantidad_stock=@Cantidad, descripcion=@Descripcion WHERE id_mueble = @IdMueble";
                SqlCommand CadenaConsulta = new SqlCommand(query, oConexion.conectar);
                // Parámetros para la inserción
                CadenaConsulta.Parameters.AddWithValue("@IdMueble", oMueble.IdMueble);
                CadenaConsulta.Parameters.AddWithValue("@Nombre", oMueble.Nombre);
                CadenaConsulta.Parameters.AddWithValue("@Foto", oMueble.Foto);
                CadenaConsulta.Parameters.AddWithValue("@Tipo", oMueble.Tipo);
                CadenaConsulta.Parameters.AddWithValue("@Material", oMueble.Material);
                CadenaConsulta.Parameters.AddWithValue("@Color", oMueble.Color);
                CadenaConsulta.Parameters.AddWithValue("@Altura", oMueble.Altura);
                CadenaConsulta.Parameters.AddWithValue("@Ancho", oMueble.Ancho);
                CadenaConsulta.Parameters.AddWithValue("@Profundidad", oMueble.Profundidad);
                CadenaConsulta.Parameters.AddWithValue("@Peso", oMueble.Peso);
                CadenaConsulta.Parameters.AddWithValue("@Estilo", oMueble.Estilo);
                CadenaConsulta.Parameters.AddWithValue("@PrecioCoste", oMueble.PrecioCoste);
                CadenaConsulta.Parameters.AddWithValue("@PrecioVenta", oMueble.PrecioVenta);
                CadenaConsulta.Parameters.AddWithValue("@Cantidad", oMueble.Cantidad);
                CadenaConsulta.Parameters.AddWithValue("@Descripcion", oMueble.Descripcion);


                CadenaConsulta.ExecuteNonQuery();
                oConexion.Cerrar();
            }
            catch (Exception ex)
            {
                oConexion.Cerrar();
                Console.WriteLine("Error Al Obtener la Información", ex.Message);
            }
        }

        public List<ClMueble> BuscarMuebleNombre(string NomMueble)
        {
            try
            {
                oConexion.Abrir();
                string query = "SELECT * FROM Muebles WHERE nombre = @Nombre";
                SqlCommand CadenaConsulta = new SqlCommand(query, oConexion.conectar);

                // Agregar parámetros
                CadenaConsulta.Parameters.AddWithValue("@Nombre", NomMueble);

                SqlDataReader LeerDato = CadenaConsulta.ExecuteReader();

                List<ClMueble> oListaE = new List<ClMueble>();

                while (LeerDato.Read())
                {
                    ClMueble oE = new ClMueble();

                    oE.IdMueble = Convert.ToInt32(LeerDato["id_mueble"]);
                    oE.Nombre = Convert.ToString(LeerDato["nombre"]);
                    oE.Tipo = Convert.ToString(LeerDato["tipo"]);
                    oE.Material = Convert.ToString(LeerDato["material"]);
                    oE.Color = Convert.ToString(LeerDato["color"]);
                    oE.Altura = Convert.ToDecimal(LeerDato["altura"]);
                    oE.Ancho = Convert.ToDecimal(LeerDato["ancho"]);
                    oE.Profundidad = Convert.ToDecimal(LeerDato["profundidad"]);
                    oE.Peso = Convert.ToDecimal(LeerDato["peso"]);
                    oE.Estilo = Convert.ToString(LeerDato["estilo"]);
                    oE.PrecioCoste = Convert.ToDecimal(LeerDato["precio_coste"]);
                    oE.PrecioVenta = Convert.ToDecimal(LeerDato["precio_venta"]);
                    oE.Cantidad = Convert.ToInt32(LeerDato["cantidad_stock"]);
                    oE.Foto = (byte[])LeerDato["foto"];
                    oE.Descripcion = Convert.ToString(LeerDato["descripcion"]);


                    oListaE.Add(oE);
                }
                oConexion.Cerrar();
                return oListaE;
            }
            catch (Exception ex)
            {
                oConexion.Cerrar();
                Console.WriteLine("Error Al Obtener la Información de muebles", ex.Message);
                return null;
            }
        }

        public void Registrar(ClCliente Datos)
        {
            oConexion.Abrir();
            string query = "INSERT INTO Clientes (cedula, nombre, apellido, ciudad,edad, fecha_nacimiento, correo_electronico, contrasenia,tipo_user) VALUES " +
             "('" + Datos.Cedula + "','" + Datos.Nombre + "','" + Datos.Apellido + "','" + Datos.Ciudad + "','" + Datos.Edad + "','" + Datos.FechaNacimiento.ToString("yyyy-MM-dd") + "','" + Datos.CorreoElectronico + "','" + Datos.Contrasenia + "','" + Datos.tipo_user + "'  )";
            SqlCommand CadenaConsulta = new SqlCommand(query, oConexion.conectar);
            CadenaConsulta.ExecuteNonQuery();
            oConexion.Cerrar();
        }

        /*public List<ClMueble> MuebleNombre(string NomMueble)
        {
            try
            {
                oConexion.Abrir();
                string query = "SELECT * FROM Muebles WHERE nombre = @Nombre";
                SqlCommand CadenaConsulta = new SqlCommand(query, oConexion.conectar);

                // Agregar parámetros
                CadenaConsulta.Parameters.AddWithValue("@Nombre", NomMueble);

                SqlDataReader LeerDato = CadenaConsulta.ExecuteReader();

                List<ClMueble> oListaE = new List<ClMueble>();

                while (LeerDato.Read())
                {
                    ClMueble oE = new ClMueble();

                    oE.IdMueble = Convert.ToInt32(LeerDato["id_mueble"]);
                    oE.Nombre = Convert.ToString(LeerDato["nombre"]);
                    oE.Tipo = Convert.ToString(LeerDato["tipo"]);
                    oE.Material = Convert.ToString(LeerDato["material"]);
                    oE.Estilo = Convert.ToString(LeerDato["estilo"]);
                    oE.PrecioVenta = Convert.ToDecimal(LeerDato["precio_venta"]);
                    oE.Cantidad = Convert.ToInt32(LeerDato["cantidad_stock"]);
                    oE.Foto = (byte[])LeerDato["foto"];


                    oListaE.Add(oE);
                }
                oConexion.Cerrar();
                return oListaE;
            }
            catch (Exception ex)
            {
                oConexion.Cerrar();
                Console.WriteLine("Error Al Obtener la Información de muebles", ex.Message);
                return null;
            }
        }*/

        public List<ClCliente> BuscarCliente(string Cliente)
        {
            try
            {
                oConexion.Abrir();
                string query = "SELECT * FROM Clientes WHERE cedula = @Cedula";
                SqlCommand CadenaConsulta = new SqlCommand(query, oConexion.conectar);

                // Agregar parámetros
                CadenaConsulta.Parameters.AddWithValue("@Cedula", Cliente);

                SqlDataReader LeerDato = CadenaConsulta.ExecuteReader();

                List<ClCliente> oListaE = new List<ClCliente>();

                while (LeerDato.Read())
                {
                    ClCliente oE = new ClCliente();

                    oE.Cedula = Convert.ToString(LeerDato["cedula"]);
                    oE.Nombre = Convert.ToString(LeerDato["nombre"]);
                    oE.Apellido = Convert.ToString(LeerDato["apellido"]);
                    oE.Ciudad = Convert.ToString(LeerDato["ciudad"]);
                    oE.Edad = Convert.ToInt32(LeerDato["edad"]);
                    oE.CorreoElectronico = Convert.ToString(LeerDato["correo_electronico"]);


                    oListaE.Add(oE);
                }
                oConexion.Cerrar();
                return oListaE;
            }
            catch (Exception ex)
            {
                oConexion.Cerrar();
                Console.WriteLine("Error Al Obtener la Información de muebles", ex.Message);
                return null;
            }
        }

        public List<ClMueble> FiltarMueblePorEstilo(string EstiloMueble)
        {
            try
            {
                oConexion.Abrir();
                string query = "SELECT * FROM Muebles WHERE estilo = @Estilo";
                SqlCommand CadenaConsulta = new SqlCommand(query, oConexion.conectar);

                // Agregar parámetros
                CadenaConsulta.Parameters.AddWithValue("@Estilo", EstiloMueble);

                SqlDataReader LeerDato = CadenaConsulta.ExecuteReader();

                List<ClMueble> oListaE = new List<ClMueble>();

                while (LeerDato.Read())
                {
                    ClMueble oE = new ClMueble();

                    oE.IdMueble = Convert.ToInt32(LeerDato["id_mueble"]);
                    oE.Nombre = Convert.ToString(LeerDato["nombre"]);
                    oE.Tipo = Convert.ToString(LeerDato["tipo"]);
                    oE.Material = Convert.ToString(LeerDato["material"]);
                    oE.Estilo = Convert.ToString(LeerDato["estilo"]);
                    oE.PrecioVenta = Convert.ToDecimal(LeerDato["precio_venta"]);
                    oE.Cantidad = Convert.ToInt32(LeerDato["cantidad_stock"]);
                    oE.Foto = (byte[])LeerDato["foto"];


                    oListaE.Add(oE);
                }
                oConexion.Cerrar();
                return oListaE;
            }
            catch (Exception ex)
            {
                oConexion.Cerrar();
                Console.WriteLine("Error Al Obtener la Información de muebles", ex.Message);
                return null;
            }
        }

        public void setFACTURA_CLIENTE(ClassCOMPRA_CLIENTES Datos)
        {
            oConexion.Abrir();
            string SqlCad = "INSERT INTO Compra_Clientes VALUES (@id_compra,@cedula)";

            using (SqlCommand ComSql = new SqlCommand(SqlCad, oConexion.conectar))
            {
                ComSql.Parameters.AddWithValue("@id_compra", Datos.IdFacturaFC);
                ComSql.Parameters.AddWithValue("@cedula", Datos.CedulaFC);

                ComSql.ExecuteNonQuery();
            }

            oConexion.Cerrar();
        }

        public void setFACTURA_ARTICULO(ClassCOMPRA_MUEBLES Datos)
        {
            oConexion.Abrir();
            string SqlCad = "INSERT INTO Compra_Muebles VALUES (@id_compra,@id_mueble,@cantidad,@total)";

            using (SqlCommand ComSql = new SqlCommand(SqlCad, oConexion.conectar))
            {
                ComSql.Parameters.AddWithValue("@id_compra", Datos.IdFacturaFA);
                ComSql.Parameters.AddWithValue("@id_mueble", Datos.CodigoFA);
                ComSql.Parameters.AddWithValue("@cantidad", Datos.CantidadFA);
                ComSql.Parameters.AddWithValue("@total", Datos.TotalFA);

                ComSql.ExecuteNonQuery();
            }

            oConexion.Cerrar();
        }

        public void setFACTURA(ClassFACTURA Datos)
        {
            oConexion.Abrir();
            string SqlCad = "INSERT INTO Compras VALUES (@fecha_compra)";

            using (SqlCommand ComSql = new SqlCommand(SqlCad, oConexion.conectar))
            {
                ComSql.Parameters.AddWithValue("@fecha_compra", Datos.FechaActualFACTURA);

                ComSql.ExecuteNonQuery();
            }

            oConexion.Cerrar();
        }

        public int RetonarUltimaCompra()
        {
            try
            {
                oConexion.Abrir();
                string query = "SELECT Max(id_compra) as UltimoId FROM Compras";
                SqlCommand CadenaConsulta = new SqlCommand(query, oConexion.conectar);

                int UltimoId = 0;

                SqlDataReader LeerDato = CadenaConsulta.ExecuteReader();

                while (LeerDato.Read())
                {
                    UltimoId = Convert.ToInt32(LeerDato["UltimoId"]);
                }
                oConexion.Cerrar();
                return UltimoId+1;
            }
            catch (Exception ex)
            {
                oConexion.Cerrar();
                Console.WriteLine("Error Al Obtener la Información de muebles", ex.Message);
                return 0;
            }
        }

    }
}
