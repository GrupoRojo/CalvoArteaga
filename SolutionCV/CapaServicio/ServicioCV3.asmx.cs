using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
//Uso la CapaEnridad
using CapaEntidad;
//Uso la CapaNegocio
using CapaNegocio;
//Buffer de memoria
using System.Data; //por si la funcion retorna un DataSet = tabla

namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de ServicioCV3
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioCV3 : System.Web.Services.WebService
    {
        //-----------------------------------------------------------------------
        //  Entidades y Negocios +/
        //-----------------------------------------------------------------------

        private NVisitante negVisitante = new NVisitante();

        //-----------------------------------------------------------------------
        //  Funciones para Visitante  +/
        //-----------------------------------------------------------------------

        [WebMethod(Description = "PersonaGeneral")]
        public DataSet PersonaGeneral()
        {
            return negVisitante.PersonaGeneral();
        }
    }
}
