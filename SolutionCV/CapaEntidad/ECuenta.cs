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
    public class ECuenta
    {
        [DataMember] //y se genera sus miembros
        public int CodCuenta { get; set; }

        [DataMember]
        public string CorreoSeguro { get; set; }

        [DataMember]
        public string Usuario { get; set; }

        [DataMember]
        public string Contrasena { get; set; }

        [DataMember]
        public char Estado { get; set; }

        [DataMember]
        public DateTime FechaRegistro { get; set; }

        [DataMember]
        public string Seudonimo { get; set; }

        [DataMember]
        public string Llave { get; set; }
    }
}
