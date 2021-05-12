using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteEscritorio
{
    public partial class TCorreo
    {
        public string DatosCompletos()
        {
            return Correo + " " + Tipo;
        }
    }
}
