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
    public class NUbigeo : Interaces.IUbigeo
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
        public DataSet ListarDepartamentos()
        {
            return datos.TraerDataSet("spListarDepartamentos");
        }
        
        public DataSet ListarProvincias(EUbigeo entUbigeo)
        {
            return datos.TraerDataSet("spListarProvincias", entUbigeo.CodDepartamento);
        }

        public DataSet ListarDistritos(EUbigeo entUbigeo)
        {
            return datos.TraerDataSet("spListarDistritos", entUbigeo.CodDepartamento, entUbigeo.CodProvincia);
        }

        public DataSet ListarLugar(EUbigeo entUbigeo)
        {
            return datos.TraerDataSet("spListarLugar", entUbigeo.CodUbigeo);
        }

    }
}
