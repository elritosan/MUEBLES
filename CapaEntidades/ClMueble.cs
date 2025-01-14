using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ClMueble
    {
        public int IdMueble { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public decimal Altura { get; set; }
        public decimal Ancho { get; set; }
        public decimal Profundidad { get; set; }
        public decimal Peso { get; set; }
        public string Estilo { get; set; }
        public decimal PrecioCoste { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public byte[] Foto { get; set; }
        public string Descripcion { get; set; }
    }
}
