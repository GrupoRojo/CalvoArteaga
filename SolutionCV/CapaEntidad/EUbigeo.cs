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
    public class EUbigeo
    {
        [DataMember]
        public string CodUbigeo { get; set; }
        [DataMember]
        public string CodDepartamento { get; set; }
        [DataMember]
        public string CodProvincia { get; set; }
        [DataMember]
        public string CodDistrito { get; set; }
        [DataMember]
        public string NomDepartamento { get; set; }
        [DataMember]
        public string NomProvincia { get; set; }
        [DataMember]
        public string NomDistrito { get; set; }
    }
}
