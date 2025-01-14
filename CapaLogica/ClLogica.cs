using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBaseDatos;
using CapaEntidades;

namespace CapaLogica
{
    public class ClLogica
    {
        ClOperaciones oOperaciones = new ClOperaciones();
        public List<ClCliente> ExisteUsuario(string AuxCorreo, string AuxContrasenia, string AuxCedula)
        {
            return oOperaciones.ExisteUsuario(AuxCorreo, AuxContrasenia, AuxCedula);

        }

        public List<ClCliente> ValidarUsuario(string Correo, string AuxContrasenia)
        {
            return oOperaciones.ValidarUsuario(Correo, AuxContrasenia);
        }

        public void EnviarDatos(ClMueble Datos)
        {
            oOperaciones.InsertarDatos(Datos);
        }

        public List<ClMueble> BuscarMueble(int IdMueble)
        {
            return oOperaciones.BuscarMueble(IdMueble);
        }

        public void EliminarMueble(int IdMueble)
        {
            oOperaciones.EliminarMueble(IdMueble);
        }

        public void EditarMueble(ClMueble oMueble)
        {
            oOperaciones.EditarMueble(oMueble);
        }

        public List<ClMueble> BuscarMuebleNombre(string NomMueble)
        {
            return oOperaciones.BuscarMuebleNombre(NomMueble);
        }

        public void RegistrarUsuario(ClCliente DatosInsertados)
        {
            oOperaciones.Registrar(DatosInsertados);
        }

        public List<ClCliente> BuscarCliente(string Cliente)
        {
            return oOperaciones.BuscarCliente(Cliente);
        }

        /*public List<ClMueble> MuebleNombre(string NomMueble)
        {
            return oOperaciones.MuebleNombre(NomMueble);
        }*/

        public List<ClMueble> FiltarMueblePorEstilo(string EstiloMueble)
        {
            return oOperaciones.FiltarMueblePorEstilo(EstiloMueble);
        }

        public void setFACTURA(ClassFACTURA Datos)
        {
            oOperaciones.setFACTURA(Datos);
        }

        public void setFACTURA_ARTICULO(ClassCOMPRA_MUEBLES Datos)
        {
            oOperaciones.setFACTURA_ARTICULO(Datos);
        }

        public void setFACTURA_CLIENTE(ClassCOMPRA_CLIENTES Datos)
        {
            oOperaciones.setFACTURA_CLIENTE(Datos);
        }

        public int RetonarUltimaCompra()
        {
            return oOperaciones.RetonarUltimaCompra();
        }
    }
}
