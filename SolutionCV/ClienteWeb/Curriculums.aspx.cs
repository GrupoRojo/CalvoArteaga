using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Buffer de memoria
using System.Data; //por si la funcion retorna un DataSet = tabla

namespace ClienteWeb
{
    
    public partial class Curriculums : System.Web.UI.Page
    {
        //Hago la referencia a mi Servicio para usar sus metodos
        private RefServicio3.ServicioCV3SoapClient ServicioCV3 = new RefServicio3.ServicioCV3SoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            dgvTabla.AutoGenerateColumns = true;
            dgvTabla.DataSource = ServicioCV3.PersonaGeneral().Tables[0];
            dgvTabla.DataBind();
        }
    }
}