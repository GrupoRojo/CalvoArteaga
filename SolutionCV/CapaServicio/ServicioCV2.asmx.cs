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
    /// Descripción breve de ServicioCV2
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioCV2 : System.Web.Services.WebService
    {
        //-----------------------------------------------------------------------
        //  Entidades y Negocios +/
        //-----------------------------------------------------------------------

        //Instancio las Entidades para usar sus Atributos
        private EEstudio entEstudio = new EEstudio();
        private ETrabajo entTrabajo = new ETrabajo();
        private EHabilidad entHabilidad = new EHabilidad();
        private ETelefono entTelefono = new ETelefono();
        private ECorreo entCorreo = new ECorreo();
        private ERedSocial entRedSocial = new ERedSocial();

        //Instancio los Negocios para usar sus Funciones
        private NEstudio negEstudio = new NEstudio();
        private NTrabajo negTrabajo = new NTrabajo();
        private NHabilidad negHabilidad = new NHabilidad();
        private NTelefono negTelefono = new NTelefono();
        private NCorreo negCorreo = new NCorreo();
        private NRedSocial negRedSocial = new NRedSocial();

        //-----------------------------------------------------------------------
        //  Funciones Privadas de Convercion  +/
        //-----------------------------------------------------------------------

        private char aCaracter(string txt)
        {
            try
            {
                char[] arreglo = txt.Trim().ToUpper().ToCharArray();
                return arreglo[0];
            }
            catch { return 'V'; }
        }
        private int aNumero(string txt)
        {
            try { return Convert.ToInt32(txt); }
            catch { return 0; }
        }
        private DateTime aFecha(string fecha)
        {
            try { return Convert.ToDateTime(fecha); }
            catch { return new DateTime(); }
        }

        //-----------------------------------------------------------------------
        //  Funciones de Estudio  +/
        //-----------------------------------------------------------------------

        [WebMethod(Description = "EstudioListar")]
        public DataSet EstudioListar(int CodCuenta)
        {
            return negEstudio.ListarEstudio(CodCuenta);
        }
        //-----------------------------------------------------------------------
        [WebMethod(Description = "EstudioInsertar")]
        public string[] EstudioInsertar(string Vision, string Institucion, string Facultad, string Carrera, string inicio, string Fin, int CodCuenta)
        {
            entEstudio.Vision = aCaracter(Vision);
            entEstudio.Institucion = Institucion;
            entEstudio.Facultad = Facultad;
            entEstudio.Carrera = Carrera;
            entEstudio.Inicio = aFecha(inicio);
            entEstudio.Fin = aFecha(Fin);
            entEstudio.CodCuenta = CodCuenta;
            string[] arreglo = new string[2];
            arreglo[0] = negEstudio.InsertarEstudio(entEstudio).ToString().ToUpper();
            arreglo[1] = negEstudio.Mensaje;
            return arreglo;
        }
        //-----------------------------------------------------------------------
        [WebMethod(Description = "EstudioActualizar")]
        public string[] EstudioActualizar(int CodEstudio, string Vision, string Institucion, string Facultad, string Carrera, string inicio, string Fin, int CodCuenta)
        {
            entEstudio.CodEstudio = CodEstudio;
            entEstudio.Vision = aCaracter(Vision);
            entEstudio.Institucion = Institucion;
            entEstudio.Facultad = Facultad;
            entEstudio.Carrera = Carrera;
            entEstudio.Inicio = aFecha(inicio);
            entEstudio.Fin = aFecha(Fin);
            entEstudio.CodCuenta = CodCuenta;
            string[] arreglo = new string[2];
            arreglo[0] = negEstudio.ActualizarEstudio(entEstudio).ToString().ToUpper();
            arreglo[1] = negEstudio.Mensaje;
            return arreglo;
        }
        //-----------------------------------------------------------------------
        [WebMethod(Description = "EstudioEliminar")]
        public string[] EstudioEliminar(int CodEstudio)
        {
            entEstudio.CodEstudio = CodEstudio;
            string[] arreglo = new string[2];
            arreglo[0] = negEstudio.EliminarEstudio(entEstudio).ToString().ToUpper();
            arreglo[1] = negEstudio.Mensaje;
            return arreglo;
        }

        //-----------------------------------------------------------------------
        //  Funciones de Trabajo  +/
        //-----------------------------------------------------------------------

        [WebMethod(Description = "TrabajoListar")]
        public DataSet TrabajoListar(int CodCuenta)
        {
            return negTrabajo.ListarTrabajo(CodCuenta);
        }
        //-----------------------------------------------------------------------
        [WebMethod(Description = "TrabajoInsertar")]
        public string[] TrabajoInsertar(string Vision, string Empresa, string Puesto, string Supervisor, string Inicio, string Fin, int CodCuenta)
        {
            entTrabajo.Vision = aCaracter(Vision);
            entTrabajo.Empresa = Empresa;
            entTrabajo.Puesto = Puesto;
            entTrabajo.Supervisor = Supervisor;
            entTrabajo.Inicio = aFecha(Inicio);
            entTrabajo.Fin = aFecha(Fin);
            entTrabajo.CodCuenta = CodCuenta;
            string[] arreglo = new string[2];
            arreglo[0] = negTrabajo.InsertarTrabajo(entTrabajo).ToString().ToUpper();
            arreglo[1] = negTrabajo.Mensaje;
            return arreglo;
        }
        //-----------------------------------------------------------------------
        [WebMethod(Description = "TrabajoActualizar")]
        public string[] TrabajoActualizar(int CodTrabajo, string Vision, string Empresa, string Puesto, string Supervisor, string Inicio, string Fin, int CodCuenta)
        {
            entTrabajo.CodTrabajo = CodTrabajo;
            entTrabajo.Vision = aCaracter(Vision);
            entTrabajo.Empresa = Empresa;
            entTrabajo.Puesto = Puesto;
            entTrabajo.Supervisor = Supervisor;
            entTrabajo.Inicio = aFecha(Inicio);
            entTrabajo.Fin = aFecha(Fin);
            entTrabajo.CodCuenta = CodCuenta;
            string[] arreglo = new string[2];
            arreglo[0] = negTrabajo.ActualizarTrabajo(entTrabajo).ToString().ToUpper();
            arreglo[1] = negTrabajo.Mensaje;
            return arreglo;
        }
        //-----------------------------------------------------------------------
        [WebMethod(Description = "TrabajoEliminar")]
        public string[] TrabajoEliminar(int CodTrabajo)
        {
            entTrabajo.CodTrabajo = CodTrabajo;
            string[] arreglo = new string[2];
            arreglo[0] = negTrabajo.EliminarTrabajo(entTrabajo).ToString().ToUpper();
            arreglo[1] = negTrabajo.Mensaje;
            return arreglo;
        }
    }
}
