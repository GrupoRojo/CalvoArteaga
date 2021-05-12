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
    interface IUbigeo
    {
        //Declaro metodos para una Clase (Herencia y Polomorfismo)
        DataSet ListarDepartamentos();
        DataSet ListarProvincias(EUbigeo entUbigeo);
        DataSet ListarDistritos(EUbigeo entUbigeo);
        DataSet ListarLugar(EUbigeo entUbigeo);
    }
}
