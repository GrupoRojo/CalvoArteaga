using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//para autenticar 
using System.Web.Security;

namespace ClienteWeb
{
    public partial class Ingreso : System.Web.UI.Page
    {
        //Hago la referencia a mi Servicio para usar sus metodos
        private RefServicio1.ServicioCV1SoapClient ServicioCV1 = new RefServicio1.ServicioCV1SoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoadIngreso_Autenticar(object sender, AuthenticateEventArgs e)
        {
            //Autenticar sin base
            string usuario_oCorreo = LoadIngreso.UserName;
            string contrasena = LoadIngreso.Password;
            string[] Respuesta = ServicioCV1.CuentaExiste(usuario_oCorreo, contrasena);
            switch (Respuesta[0].ToUpper())
            {
                case "TRUE":
                    //Respuesta = (usuario|codigo) por eso lo separo con SPLIT
                    string[] cadena = Respuesta[1].Split('|');
                    Session["usuario"] = cadena[0];
                    Session["codigo"] = Int32.Parse(cadena[1]);

                    //reirecciono a Cuenta
                    FormsAuthentication.RedirectFromLoginPage(usuario_oCorreo, false);
                    break;
                case "FALSE":
                    LoadIngreso.FailureText = "Usuario o Contraseña Incorrecto";
                    break;
            }
        }
    }
}