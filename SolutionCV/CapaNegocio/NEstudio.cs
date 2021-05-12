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
    public class NEstudio : Interaces.IEstudio
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
        public DataSet ListarEstudio(int CodCuenta)
        {
            return datos.TraerDataSet("spListarEstudio", CodCuenta);
        }

        public bool InsertarEstudio(EEstudio entEstudio)
        {
            // Trae la fila encontrada con el CodError y el Mensaje
            DataRow fila = datos.TraerDataRow("spInsertarEstudio", entEstudio.Vision, entEstudio.Institucion, entEstudio.Facultad, entEstudio.Carrera, entEstudio.Inicio, entEstudio.Fin, entEstudio.CodCuenta);
            // Obtengo el CodError y Mensaje de fila
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool ActualizarEstudio(EEstudio entEstudio)
        {
            // Trae la fila encontrada con el CodError y el Mensaje
            DataRow fila = datos.TraerDataRow("spActualizarEstudio", entEstudio.CodEstudio, entEstudio.Vision, entEstudio.Institucion, entEstudio.Facultad, entEstudio.Carrera, entEstudio.Inicio, entEstudio.Fin, entEstudio.CodCuenta);
            // Obtengo el CodError y Mensaje de fila
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool EliminarEstudio(EEstudio entEstudio)
        {
            // Trae la fila encontrada con el CodError y el Mensaje
            DataRow fila = datos.TraerDataRow("spEliminarEstudio", entEstudio.CodEstudio);
            // Obtengo el CodError y Mensaje de fila
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

    }
}
