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
    public class EEstudio
    {
        [DataMember] //y se genera sus miembros
        public int CodEstudio { get; set; }

        [DataMember]
        public char Vision { get; set; }

        [DataMember]
        public string Institucion { get; set; }

        [DataMember]
        public string Facultad { get; set; }

        [DataMember]
        public string Carrera { get; set; }

        [DataMember]
        public DateTime Inicio { get; set; }

        [DataMember]
        public DateTime Fin { get; set; }

        [DataMember] //pertenece a una cuenta
        public int CodCuenta { get; set; }
    }
}
