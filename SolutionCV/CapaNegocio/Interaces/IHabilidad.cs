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
    interface IHabilidad
    {
        //Declaro metodos para una Clase (Herencia y Polomorfismo)
        DataSet ListarHabilidad(int CodCuenta);
        bool InsertarHabilidad(EHabilidad entHabilidad);
        bool ActualizarHabilidad(EHabilidad entHabilidad);
        bool EliminarHabilidad(EHabilidad entHabilidad);
    }
}
