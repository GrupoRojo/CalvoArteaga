using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//uso la Entidad
using CapaEntidad;
//Buffer de memoria
using System.Data; //por si la funcion retorna un DataSet = tabla

namespace CapaNegocio.Interaces
{
    interface ICuenta
    {
        //Declaro metodos para una Clase (Herencia y Polomorfismo)
        bool ExisteCuenta(string usuario_o_correo, string contra);
        DataSet InfoCuenta(ECuenta entCuenta);
        bool InsertarCuenta(ECuenta entCuenta);
        bool DesactivarCuenta(ECuenta entCuenta);
        bool ReactivarCuenta(ECuenta entCuenta);
        bool ActualizarCuentaContra(ECuenta entCuenta, string NuevaContra);
        bool ActualizarCuentaSeudo(ECuenta entCuenta);
        bool ActualizarCuentaLlave(ECuenta entCuenta);
        //notar que entCuenta es una entidad que pasa mediante parametro
    }
}
