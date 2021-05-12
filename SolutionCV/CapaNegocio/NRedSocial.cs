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
    public class NRedSocial : Interaces.IRedSocial
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
        public DataSet ListarRedSocial(int CodCuenta)
        {
            return datos.TraerDataSet("spListarRedSocial", CodCuenta);
        }

        public bool InsertarRedSocial(ERedSocial entRedSocial)
        {
            // Trae la fila encontrada con el CodError y el Mensaje
            DataRow fila = datos.TraerDataRow("spInsertarRedSocial", entRedSocial.Vision, entRedSocial.Tipo, entRedSocial.Ruta, entRedSocial.CodCuenta);
            // Obtengo el CodError y Mensaje de fila
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool ActualizarRedSocial(ERedSocial entRedSocial)
        {
            // Trae la fila encontrada con el CodError y el Mensaje
            DataRow fila = datos.TraerDataRow("spActualizarRedSocial", entRedSocial.CodRedSocial, entRedSocial.Vision, entRedSocial.Tipo, entRedSocial.Ruta, entRedSocial.CodCuenta);
            // Obtengo el CodError y Mensaje de fila
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool EliminarRedSocial(ERedSocial entRedSocial)
        {
            // Trae la fila encontrada con el CodError y el Mensaje
            DataRow fila = datos.TraerDataRow("spEliminarRedSocial", entRedSocial.CodCuenta);
            // Obtengo el CodError y Mensaje de fila
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }
        
    }
}
