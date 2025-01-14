using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion
{
    public class ClassProducto
    {
        public ClassProducto() { }
        public string NombreArticulo { get; set; }
        public decimal PrecioArticulo { get; set; }
        public int CantidadArticulo { get; set; }
        public decimal TotalArticulo { get; set; }
    }
}
