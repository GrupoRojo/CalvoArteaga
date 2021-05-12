using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Uso:  CapaDatos
using CapaDatos;
//Buffer de memoria
//parece q ya no lo necesita por q en la interfaz ya lo implementa
//using System.Data; //por si la funcion retorna un DataSet = tabla

namespace CapaNegocio
{
    public class NInfo : Interaces.IInfo
    {
        //declaro objeto datos ; para manipular procesimientos almacenados
        private Datos datos = new DatosSQL();
        //Mensaje con propiedad de solo lectura
        private string mensaje;
        public string Mensaje
        {
            get { return mensaje; }
        }

        //Metodos con los que trabajare:
        public DataSet ListarInfo(int CodCuenta)
        {
            // Traes la fila encontrada o el CodError y el Mensaje
            return datos.TraerDataSet("spListarInfo", CodCuenta);
        }

        public bool ActualizarInfo(EInfo entInfo)
        {
            // Traes la fila encontrada o el CodError y el Mensaje
            DataRow fila = datos.TraerDataRow("spActualizarInfo", entInfo.Apellidos, entInfo.Nombres, entInfo.Nacimiento, entInfo.Sexo, entInfo.EstadoCivil, entInfo.DNI, entInfo.Direccion, entInfo.Informacion, entInfo.CodUbigeo, entInfo.CodCuenta);
            // Obtengo el CodError y Mensaje de fila
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool ActualizarImagen(EInfo entInfo)
        {
            // Traes la fila encontrada o el CodError y el Mensaje
            DataRow fila = datos.TraerDataRow("spActualizarImagen", entInfo.Foto, entInfo.CodCuenta);
            // Obtengo el CodError y Mensaje de fila
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }
    }
}
