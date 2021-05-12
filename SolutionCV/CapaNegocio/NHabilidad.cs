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
    public class NHabilidad : Interaces.IHabilidad
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
        public DataSet ListarHabilidad(int CodCuenta)
        {
            return datos.TraerDataSet("spListarHabilidad", CodCuenta);
        }

        public bool InsertarHabilidad(EHabilidad entHabilidad)
        {
            // Trae la fila encontrada con el CodError y el Mensaje
            DataRow fila = datos.TraerDataRow("spInsertarHabilidad", entHabilidad.Vision, entHabilidad.Nombre, entHabilidad.Nivel, entHabilidad.CodCuenta);
            // Obtengo el CodError y Mensaje de fila
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool ActualizarHabilidad(EHabilidad entHabilidad)
        {
            // Trae la fila encontrada con el CodError y el Mensaje
            DataRow fila = datos.TraerDataRow("spActualizarHabilidad", entHabilidad.CodHabilidad, entHabilidad.Vision, entHabilidad.Nombre, entHabilidad.Nivel, entHabilidad.CodCuenta);
            // Obtengo el CodError y Mensaje de fila
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool EliminarHabilidad(EHabilidad entHabilidad)
        {
            // Trae la fila encontrada con el CodError y el Mensaje
            DataRow fila = datos.TraerDataRow("spEliminarHabilidad", entHabilidad.CodHabilidad);
            // Obtengo el CodError y Mensaje de fila
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

    }
}
