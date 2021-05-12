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
    public class NCuenta : Interaces.ICuenta
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
        public bool ExisteCuenta(string usuario_o_correo, string contra)
        {
            // Traes la fila encontrada o el CodError y el Mensaje
            DataRow fila = datos.TraerDataRow("spExisteCuenta", usuario_o_correo, contra);
            // Obtengo el CodError y Mensaje de fila
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public DataSet InfoCuenta(ECuenta entCuenta)
        {
            return datos.TraerDataSet("spInfoCuenta", entCuenta.CodCuenta);
        }

        public bool InsertarCuenta(ECuenta entCuenta)
        {
            // Traes la fila encontrada o el CodError y el Mensaje
            DataRow fila = datos.TraerDataRow("spInsertarCuenta", entCuenta.CorreoSeguro, entCuenta.Usuario, entCuenta.Contrasena, DateTime.Now);
            // Obtengo el CodError y Mensaje de fila
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool DesactivarCuenta(ECuenta entCuenta)
        {
            // Traes la fila encontrada o el CodError y el Mensaje
            DataRow fila = datos.TraerDataRow("spDesactivarCuenta", entCuenta.CodCuenta);
            // Obtengo el CodError y Mensaje de fila
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool ReactivarCuenta(ECuenta entCuenta)
        {
            // Traes la fila encontrada o el CodError y el Mensaje
            DataRow fila = datos.TraerDataRow("spReactivarCuenta", entCuenta.CodCuenta);
            // Obtengo el CodError y Mensaje de fila
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }
        public bool ActualizarCuentaContra(ECuenta entCuenta, string NuevaContra)
        {
            // Traes la fila encontrada o el CodError y el Mensaje
            DataRow fila = datos.TraerDataRow("spActualizarCuentaContra", entCuenta.CodCuenta, entCuenta.Contrasena, NuevaContra);
            // Obtengo el CodError y Mensaje de fila
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool ActualizarCuentaSeudo(ECuenta entCuenta)
        {
            // Traes la fila encontrada o el CodError y el Mensaje
            DataRow fila = datos.TraerDataRow("spActualizarCuentaSeudo", entCuenta.CodCuenta, entCuenta.Seudonimo);
            // Obtengo el CodError y Mensaje de fila
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool ActualizarCuentaLlave(ECuenta entCuenta)
        {
            // Traes la fila encontrada o el CodError y el Mensaje
            DataRow fila = datos.TraerDataRow("spActualizarCuentaLlave", entCuenta.CodCuenta, entCuenta.Llave);
            // Obtengo el CodError y Mensaje de fila
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }
    }
}
