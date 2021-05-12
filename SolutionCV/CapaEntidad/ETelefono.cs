using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Serializo para q sea multilenguaje, multiplataforma
using System.Runtime.Serialization;

namespace CapaEntidad
{
    [DataContract] //se genera un contrato
    public class ETelefono
    {
        [DataMember] //y se genera sus miembros
        public int CodTelefono { get; set; }

        [DataMember]
        public char Vision { get; set; }

        [DataMember]
        public string Tipo { get; set; }

        [DataMember]
        public string Numero { get; set; }

        [DataMember] //pertenece a una cuenta
        public int CodCuenta { get; set; }
    }
}
