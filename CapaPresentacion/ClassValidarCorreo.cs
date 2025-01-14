using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CapaPresentacion
{
    public class ClassValidarCorreo
    {
        string Correo;
        public ClassValidarCorreo() { }

        public ClassValidarCorreo(string Correo)
        {
            this.Correo = Correo;
        }

        public bool ValidarCorreo()
        {
            string CadenaCorreo = Correo;

            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(CadenaCorreo, sFormato))
            {
                if (Regex.Replace(CadenaCorreo, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}
