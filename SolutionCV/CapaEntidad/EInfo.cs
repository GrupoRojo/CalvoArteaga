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
    public class EInfo
    {
        [DataMember] //y se genera sus miembros
        public int CodInfo { get; set; }

        [DataMember]
        public string Apellidos { get; set; }

        [DataMember]
        public string Nombres { get; set; }

        [DataMember]
        public DateTime Nacimiento { get; set; }

        [DataMember] 
        public char Sexo { get; set; }

        [DataMember]
        public char EstadoCivil { get; set; }

        [DataMember]
        public string DNI { get; set; }

        [DataMember]
        public string Direccion { get; set; }

        [DataMember]
        public string Informacion { get; set; }

        [DataMember] //las fotos se guardan en Arreglo de bytes
        public byte[] Foto { get; set; }

        [DataMember]
        public string CodUbigeo { get; set; }

        [DataMember] //pertenece a una cuenta
        public int CodCuenta { get; set; }

    }
}
