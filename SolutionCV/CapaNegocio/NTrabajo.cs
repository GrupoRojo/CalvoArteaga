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
    public class NTrabajo : Interaces.ITrabajo
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
        public DataSet ListarTrabajo(int CodCuenta)
        {
            return datos.TraerDataSet("spListarTrabajo", CodCuenta);
        }

        public bool InsertarTrabajo(ETrabajo entTrabajo)
        {
            // Trae la fila encontrada con el CodError y el Mensaje
            DataRow fila = datos.TraerDataRow("spInsertarTrabajo", entTrabajo.Vision, entTrabajo.Empresa, entTrabajo.Puesto, entTrabajo.Supervisor, entTrabajo.Inicio, entTrabajo.Fin, entTrabajo.CodCuenta);
            // Obtengo el CodError y Mensaje de fila
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool ActualizarTrabajo(ETrabajo entTrabajo)
        {
            // Trae la fila encontrada con el CodError y el Mensaje
            DataRow fila = datos.TraerDataRow("spActualizarTrabajo", entTrabajo.CodTrabajo, entTrabajo.Vision, entTrabajo.Empresa, entTrabajo.Puesto, entTrabajo.Supervisor, entTrabajo.Inicio, entTrabajo.Fin, entTrabajo.CodCuenta);
            // Obtengo el CodError y Mensaje de fila
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool EliminarTrabajo(ETrabajo entTrabajo)
        {
            // Trae la fila encontrada con el CodError y el Mensaje
            DataRow fila = datos.TraerDataRow("spEliminarTrabajo", entTrabajo.CodTrabajo);
            // Obtengo el CodError y Mensaje de fila
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

    }
}
