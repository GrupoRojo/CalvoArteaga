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
    /// Descripción breve de ServicioCV1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioCV1 : System.Web.Services.WebService
    {
        //-----------------------------------------------------------------------
        //  Entidades y Negocios +/
        //-----------------------------------------------------------------------

        //Instancio las Entidades para usar sus Atributos
        private ECuenta entCuenta = new ECuenta();
        private EInfo entInfo = new EInfo();
        private EUbigeo entUbigeo = new EUbigeo();

        //Instancio los Negocios para usar sus Funciones
        private NCuenta negCuenta = new NCuenta();
        private NInfo negInfo = new NInfo();
        private NUbigeo negUbigeo = new NUbigeo();

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
        //  Funciones de Cuenta  +/
        //-----------------------------------------------------------------------

        [WebMethod(Description = "CuentaExiste")]
        public string[] CuentaExiste(string Usuario_o_Correo, string Contrasena)
        {
            string[] arreglo = new string[2];
            arreglo[0] = negCuenta.ExisteCuenta(Usuario_o_Correo, Contrasena).ToString().ToUpper();
            arreglo[1] = negCuenta.Mensaje;
            return arreglo;
        }
        //-----------------------------------------------------------------------
        [WebMethod(Description = "CuentaInformacion")]
        public DataSet CuentaInformacion(int CodCuenta)
        {
            entCuenta.CodCuenta = CodCuenta;
            return negCuenta.InfoCuenta(entCuenta);
        }
        //-----------------------------------------------------------------------
        [WebMethod(Description = "CuentaAgregar")]
        public string[] CuentaAgregar(string CorreoSeguro, string Usuario, string Contrasena)
        {
            entCuenta.CorreoSeguro = CorreoSeguro;
            entCuenta.Usuario = Usuario;
            entCuenta.Contrasena = Contrasena;
            string[] arreglo = new string[2];
            arreglo[0] = negCuenta.InsertarCuenta(entCuenta).ToString().ToUpper();
            arreglo[1] = negCuenta.Mensaje;
            return arreglo;
        }
        //-----------------------------------------------------------------------
        [WebMethod(Description = "CuentaDesactivar")]
        public string[] CuentaDesactivar(int CodCuenta)
        {
            entCuenta.CodCuenta = CodCuenta;
            string[] arreglo = new string[2];
            arreglo[0] = negCuenta.DesactivarCuenta(entCuenta).ToString().ToUpper();
            arreglo[1] = negCuenta.Mensaje;
            return arreglo;
        }
        //-----------------------------------------------------------------------
        [WebMethod(Description = "CuentaReactivar")]
        public string[] CuentaReactivar(int CodCuenta)
        {
            entCuenta.CodCuenta = CodCuenta;
            string[] arreglo = new string[2];
            arreglo[0] = negCuenta.ReactivarCuenta(entCuenta).ToString().ToUpper();
            arreglo[1] = negCuenta.Mensaje;
            return arreglo;
        }
        //-----------------------------------------------------------------------
        [WebMethod(Description = "CuentaActualizarContrasena")]
        public string[] CuentaActualizarContrasena(int CodCuenta, string Contrasena, string ContrasenaNueva)
        {
            entCuenta.CodCuenta = CodCuenta;
            entCuenta.Contrasena = Contrasena;
            string[] arreglo = new string[2];
            arreglo[0] = negCuenta.ActualizarCuentaContra(entCuenta, ContrasenaNueva).ToString().ToUpper();
            arreglo[1] = negCuenta.Mensaje;
            return arreglo;
        }
        //-----------------------------------------------------------------------
        [WebMethod(Description = "CuentaActualizarSeudonimo")]
        public string[] CuentaActualizarSeudonimo(int CodCuenta, string Seudonimo)
        {
            entCuenta.CodCuenta = CodCuenta;
            entCuenta.Seudonimo = Seudonimo;
            string[] arreglo = new string[2];
            arreglo[0] = negCuenta.ActualizarCuentaSeudo(entCuenta).ToString().ToUpper();
            arreglo[1] = negCuenta.Mensaje;
            return arreglo;
        }
        //-----------------------------------------------------------------------
        [WebMethod(Description = "CuentaActualizarLlave")]
        public string[] CuentaActualizarLlave(int CodCuenta, string Llave)
        {
            entCuenta.CodCuenta = CodCuenta;
            entCuenta.Llave = Llave;
            string[] arreglo = new string[2];
            arreglo[0] = negCuenta.ActualizarCuentaLlave(entCuenta).ToString().ToUpper();
            arreglo[1] = negCuenta.Mensaje;
            return arreglo;
        }

        //-----------------------------------------------------------------------
        //  Funciones de Info  +/
        //-----------------------------------------------------------------------

        [WebMethod(Description = "InfoListar")]
        public DataSet InfoListar(int CodCuenta)
        {
            return negInfo.ListarInfo(CodCuenta);
        }
        //-----------------------------------------------------------------------
        [WebMethod(Description = "InfoActualizar")]
        public string[] InfoActualizar(string Apellidos, string Nombres, string Nacimiento, string Sexo, string EstadoCivil, string DNI, string Direccion, string Informacion, int CodCuenta)
        {
            entInfo.Apellidos = Apellidos;
            entInfo.Nombres = Nombres;
            entInfo.Nacimiento = aFecha(Nacimiento);
            entInfo.Sexo = aCaracter(Sexo);
            entInfo.EstadoCivil = aCaracter(EstadoCivil);
            entInfo.DNI = DNI;
            entInfo.Direccion = Direccion;
            entInfo.Informacion = Informacion;
            entInfo.CodCuenta = CodCuenta;
            string[] arreglo = new string[2];
            arreglo[0] = negInfo.ActualizarInfo(entInfo).ToString().ToUpper();
            arreglo[1] = negInfo.Mensaje;
            return arreglo;
        }
        //-----------------------------------------------------------------------
        [WebMethod(Description = "InfoActualizarImagen")]
        public string[] InfoActualizarImagen(byte[] Foto, int CodCuenta)
        {
            entInfo.Foto = Foto;
            entInfo.CodCuenta = CodCuenta;
            string[] arreglo = new string[2];
            arreglo[0] = negInfo.ActualizarImagen(entInfo).ToString().ToUpper();
            arreglo[1] = negInfo.Mensaje;
            return arreglo;
        }

        //-----------------------------------------------------------------------
        //  Funciones de Ubigeo  +/
        //-----------------------------------------------------------------------

        [WebMethod(Description = "UbigeoDepartamentos")]
        public DataSet UbigeoDepartamentos()
        {
            return negUbigeo.ListarDepartamentos();
        }
        //-----------------------------------------------------------------------
        [WebMethod(Description = "UbigeoProvincias")]
        public DataSet UbigeoProvincias(string CodDepartamento)
        {
            entUbigeo.CodDepartamento = CodDepartamento;
            return negUbigeo.ListarProvincias(entUbigeo);
        }
        //-----------------------------------------------------------------------
        [WebMethod(Description = "UbigeoDistritos")]
        public DataSet UbigeoDistritos(string CodDepartamento, string CodProvincia)
        {
            entUbigeo.CodDepartamento = CodDepartamento;
            entUbigeo.CodProvincia = CodProvincia;
            return negUbigeo.ListarDistritos(entUbigeo);
        }
        //-----------------------------------------------------------------------
        [WebMethod(Description = "UbigeoLugar")]
        public DataSet UbigeoLugar(string CodUbigeo)
        {
            entUbigeo.CodUbigeo = CodUbigeo;
            return negUbigeo.ListarLugar(entUbigeo);
        }
    }
}
