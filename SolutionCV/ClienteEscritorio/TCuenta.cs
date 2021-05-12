using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteEscritorio
{
    public partial class TCuenta
    {
        public string DatosCompletos()
        {
            return Usuario + " " + Seudonimo;
        }
    }
}
