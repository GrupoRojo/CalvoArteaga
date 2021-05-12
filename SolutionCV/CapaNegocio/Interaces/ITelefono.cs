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
    interface ITelefono
    {
        //Declaro metodos para una Clase (Herencia y Polomorfismo)
        DataSet ListarTelefono(int CodCuenta);
        bool InsertarTelefono(ETelefono entTelefono);
        bool ActualizarTelefono(ETelefono entTelefono);
        bool EliminarTelefono(ETelefono entTelefono);
    }
}
