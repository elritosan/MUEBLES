using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CapaEntidades
{
    public class ClassCOMPRA_MUEBLES
    {
        public int IdFacturaFA { get; set; }
        public int CodigoFA { get; set; }
        public int CantidadFA { get; set; }
        public decimal TotalFA { get; set; }
    }
}
