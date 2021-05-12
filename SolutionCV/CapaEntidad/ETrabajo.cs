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
    public class ETrabajo
    {
        [DataMember] //y se genera sus miembros
        public int CodTrabajo { get; set; }

        [DataMember]
        public char Vision { get; set; }

        [DataMember]
        public string Empresa { get; set; }

        [DataMember]
        public string Puesto { get; set; }

        [DataMember]
        public string Supervisor { get; set; }

        [DataMember]
        public DateTime Inicio { get; set; }

        [DataMember]
        public DateTime Fin { get; set; }

        [DataMember] //pertenece a una cuenta
        public int CodCuenta { get; set; }
    }
}
