using CapaEntidades;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion
{
    public class ClassGenerarFactura
    {
        private ClLogica oBDSQL = new ClLogica();
        private List<ClassCOMPRA_MUEBLES> oListaFA = new List<ClassCOMPRA_MUEBLES>();

        //public ClassGenerarFactura() { }

        public ClassGenerarFactura(List<ClassCOMPRA_MUEBLES> oListaFA)
        {
            this.oListaFA = oListaFA;
        }

        public List<ClassCOMPRA_MUEBLES> AgruparPorIdYCodigo()
        {
            // Agrupar por IdFacturaFA y CodigoFA
            var grupos = oListaFA
                .GroupBy(item => new { item.IdFacturaFA, item.CodigoFA })
                .Select(grupo => new ClassCOMPRA_MUEBLES
                {
                    IdFacturaFA = grupo.Key.IdFacturaFA,
                    CodigoFA = grupo.Key.CodigoFA,
                    CantidadFA = grupo.Sum(item => item.CantidadFA),
                    TotalFA = grupo.Sum(item => item.TotalFA)
                })
                .ToList();

            return grupos;
        }

        public List<ClassProducto> RetornarListaProductos()
        {

            List<ClassProducto> oListaP = new List<ClassProducto>();

            List<ClassCOMPRA_MUEBLES> oAuxListaFA = AgruparPorIdYCodigo();



            int N = oAuxListaFA.Count();

            for (int i = 0; i < N; i++)
            {
                ClassProducto oP = new ClassProducto();

                List<ClMueble> MuebleBuscado = new List<ClMueble>();

                MuebleBuscado = oBDSQL.BuscarMueble(oAuxListaFA[i].CodigoFA);

                oP.NombreArticulo = MuebleBuscado[0].Nombre;
                oP.PrecioArticulo = MuebleBuscado[0].PrecioVenta;
                oP.CantidadArticulo = oAuxListaFA[i].CantidadFA;
                oP.TotalArticulo = oAuxListaFA[i].TotalFA;

                oListaP.Insert(i, oP);   
            }

            return oListaP;
        }
    }
}
